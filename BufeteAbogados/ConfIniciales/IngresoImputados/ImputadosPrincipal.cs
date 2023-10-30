using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConfIniciales.IngresoImputados
{
    public partial class ImputadosPrincipal : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\INSTALADORPROCUSOYAPANGO\BASEPROCURADURIA\BASEPROCURADURIA.MDF;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds = new DataSet();
        SqlDataReader lector;

        int Imputadoid;
        int ImputadoValidado=-1;
        string GeneroHM;
        string GeneroDataGrid;
        string DPprincipal;
        string DPdatagrid;
       


        private Form currentChilForm; //Campo para almacenar el formulario hijo actual

        public ImputadosPrincipal()
        {
            InitializeComponent();          
            this.DoubleBuffered = true;
            gbImputado.Enabled = false;
            rdFemenino.Checked = true;
            btnEditarInfo.Enabled = false;
            DataGridViewIMPp.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
           




        }

        public ImputadosPrincipal(string DPTraerDelitos)
        {
            InitializeComponent();
            DPprincipal = DPTraerDelitos;
            lblDPinformacion.Text = DPTraerDelitos;
            txtDP_ImpPrincipal.Text = DPTraerDelitos;
            txtDP_ImpPrincipal.Enabled = false;
            btnSiguiente.Visible = true;
            btnEditarInfo.Enabled = true;
            rdFemenino.Checked = true;
            ComboAño.DropDownStyle = ComboBoxStyle.DropDownList;
            DataGridViewIMPp.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            //BTNcontinuarIMP1.Visible = true;

            try
            {
                con.Open();
                cmd = new SqlCommand("Select *from InfoPenal where DP= @DP",con);
                cmd.Parameters.AddWithValue("@DP",DPTraerDelitos);
                lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    txtDP_ImpPrincipal.Text = lector["DP"].ToString();
                    ComboAño.Text= lector["AÑO"].ToString();
                    txtTribunal_ImpPrincipal.Text = lector["TRIBUNAL"].ToString();
                    txtReferencia_ImpPrincipal.Text = lector["REFERENCIA"].ToString();
                    txtDcaso_ImpPrincipal.Text = lector["DefensorCaso"].ToString();
                    txtDproceso_ImpPrincipal.Text = lector["DefensorProceso"].ToString();
                }
                con.Close();
                displayTraerDelitos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        //Funciones
        private void displayData()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from IngresaIMP where DP like '"+DPprincipal+"'", con);
            //adpt = new SqlDataAdapter("select Name,Email from [Employee]", con);
            dt = new DataTable();
            adpt.Fill(dt);
            DataGridViewIMPp.DataSource = dt;
            con.Close();
        }

        private void displayTraerDelitos()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from IngresaIMP where DP like '"+DPprincipal+"'",con);
            //adpt = new SqlDataAdapter("select Name,Email from [Employee]", con);
            dt = new DataTable();
            adpt.Fill(dt);
            DataGridViewIMPp.DataSource = dt;
            con.Close();
        }


        //RadioButton
        private void Genero()
        {
            if(rdMasculino.Checked)
            {
                GeneroHM = "Masculino";

            }
            else if(rdFemenino.Checked)
            {
                GeneroHM = "Femenino";
            }
            else
            {
                GeneroHM = "";
            }
        }
        private void GeneroSeleccionado()
        {
            if (GeneroDataGrid == "Masculino")
            {
                rdMasculino.Checked = true;

            }
            else
            {
                rdFemenino.Checked = true;
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            rdFemenino.Checked = true;
        }
        //Deshabilitar controles
        private void Deshabilitar()
        {
            txtDP_ImpPrincipal.Enabled = false;
        }




        private void OpenChildForm(Form childForm)
        {
            try
            {
                if (currentChilForm != null)
                {
                    currentChilForm.Close();
                }
                currentChilForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                PanelImputadoPrincipal.Controls.Add(childForm);
                PanelImputadoPrincipal.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if(txtDP_ImpPrincipal.Enabled == true)
            {
                MessageBox.Show("Guarde el número de expediente si quiere continuar");
            }
            else
            {
                OpenChildForm(new ConfIniciales.IngresoImputados.DelitosVictimas(DPprincipal));
            }
 
           


        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string cDp = txtDP_ImpPrincipal.Text;
            string cTri = txtTribunal_ImpPrincipal.Text;
            string cRe = txtReferencia_ImpPrincipal.Text;
            string cDC = txtDcaso_ImpPrincipal.Text;
            string cDEP = txtDproceso_ImpPrincipal.Text;

            if (cDp == "" || cTri == "" || cDp == "" || cRe=="" || cDC=="" || cDEP=="")
            {
                MessageBox.Show("Por favor, ingrese los datos completos");
            }
            else
            {
                    adpt = new SqlDataAdapter("select * from InfoPenal where DP like '" + txtDP_ImpPrincipal.Text + "'", con);
                    adpt.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    if (i > 0)
                    {
                        if (txtDP_ImpPrincipal.Enabled == false)
                        {

                            MessageBox.Show("Continue ingresando la información al expediente");
                        }
                        else
                        {
                            MessageBox.Show(" DP N° " + txtDP_ImpPrincipal.Text + "YA EXISTE");
                            ds.Clear();

                        }
                    }
                    else
                    {
                        try
                        {

                            con.Open();
                            cmd = new SqlCommand("insert into InfoPenal values (@DP,@AÑO,@TRIBUNAL,@REFERENCIA,@DefensorCaso,@DefensorProceso)", con);
                            cmd.Parameters.AddWithValue("@DP", txtDP_ImpPrincipal.Text);
                            cmd.Parameters.AddWithValue("@AÑO", ComboAño.Text);
                            cmd.Parameters.AddWithValue("@TRIBUNAL", txtTribunal_ImpPrincipal.Text);
                            cmd.Parameters.AddWithValue("@REFERENCIA", txtReferencia_ImpPrincipal.Text);
                            cmd.Parameters.AddWithValue("@DefensorCaso", txtDcaso_ImpPrincipal.Text);
                            cmd.Parameters.AddWithValue("@DefensorProceso", txtDproceso_ImpPrincipal.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Su informacion se ha guardado correctamente");
                            con.Close();
                            DPprincipal = txtDP_ImpPrincipal.Text;
                            lblDPinformacion.Text = DPprincipal;
                            Deshabilitar();
                            btnEditarInfo.Enabled = true;
                            gbImputado.Enabled = true;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombre.Text == "" || txtApellido.Text == "")
                {
                    MessageBox.Show("Escriba el nombre y el apellido");
                }
                else
                {
                        Genero();
                        con.Open();
                        cmd = new SqlCommand("insert into IngresaIMP values(@DP,@NOMBRE,@APELLIDO,@TipoGenero)", con);
                        cmd.Parameters.AddWithValue("@DP", DPprincipal);
                        cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@APELLIDO", txtApellido.Text);
                        cmd.Parameters.AddWithValue("@TipoGenero", GeneroHM);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Su informacion se ha guardado correctamente");
                        con.Close();
                        Limpiar();
                        displayData();
                        ImputadoValidado = -1;
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDcaso_ImpPrincipal_TextChanged(object sender, EventArgs e)
        {
            int lonDC = txtDcaso_ImpPrincipal.Text.Length;
            if (lonDC >= 99)
            {
                MessageBox.Show("Ha escrito demasiado texto, Disminuya el texto");

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtApellido.Text == "")
                {
                    MessageBox.Show("Primero seleccione un registro de la tabla de la derecha");
                }
                else
                {
                    if (ImputadoValidado == -1)
                    {
                        MessageBox.Show("Seleccione un registro existente de la tabla");
                    }
                    else if (ImputadoValidado == 1)
                    {
                            Genero();
                            con.Open();
                            cmd = new SqlCommand("update IngresaIMP set NOMBRE=@NOMBRE,APELLIDO=@APELLIDO,TipoGenero=@TipoGenero where IdImputados=@IdImputados", con);
                            cmd.Parameters.AddWithValue("@IdImputados", Imputadoid);
                            cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@APELLIDO", txtApellido.Text);
                            cmd.Parameters.AddWithValue("@TipoGenero", GeneroHM);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("El registro se ha actualizado correctamente");
                            con.Close();
                            Limpiar();
                            displayData();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewIMPp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNombre.Text == "" && txtApellido.Text == "")
                {
                    MessageBox.Show("Primero seleccione un registro de la tabla de la derecha");
                }
                else
                {

                    if (ImputadoValidado == -1)
                    {
                        MessageBox.Show("Seleccione un registro existente de la tabla");
                    }
                    else if (ImputadoValidado == 1)
                    {

                        con.Open();
                        cmd = new SqlCommand("delete from IngresaIMP where IdImputados='"+Imputadoid+"'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("La información se elimino correctamente");
                        con.Close();
                        Limpiar();
                        displayData();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewIMPp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ImputadosPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEditarInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string cDpE = txtDP_ImpPrincipal.Text;
                string cTriE = txtTribunal_ImpPrincipal.Text;
                string cReE = txtReferencia_ImpPrincipal.Text;
                string cDCE = txtDcaso_ImpPrincipal.Text;
                string cDEPE = txtDproceso_ImpPrincipal.Text;

                if (cDpE== "" || cTriE == "" || cReE == "" || cDCE == "" || cDEPE == "")
                {
                    MessageBox.Show("Por favor, ingrese los datos completos");
                }
                else
                {
                        con.Open();
                        cmd = new SqlCommand("update InfoPenal set AÑO=@AÑO,TRIBUNAL=@TRIBUNAL,REFERENCIA=@REFERENCIA,DefensorCaso=@DefensorCaso,DefensorProceso=@DefensorProceso where DP=@DP", con);
                        cmd.Parameters.AddWithValue("@DP", txtDP_ImpPrincipal.Text);
                        cmd.Parameters.AddWithValue("@AÑO", ComboAño.Text);
                        cmd.Parameters.AddWithValue("@TRIBUNAL", txtTribunal_ImpPrincipal.Text);
                        cmd.Parameters.AddWithValue("@REFERENCIA", txtReferencia_ImpPrincipal.Text);
                        cmd.Parameters.AddWithValue("@DefensorCaso", txtDcaso_ImpPrincipal.Text);
                        cmd.Parameters.AddWithValue("@DefensorProceso", txtDproceso_ImpPrincipal.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("El registro se ha actualizado correctamente");
                        con.Close();
                    
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PanelImputadoPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDP_ImpPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtTribunal_ImpPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtDcaso_ImpPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtDproceso_ImpPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtReferencia_ImpPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtDP_ImpPrincipal_TextChanged(object sender, EventArgs e)
        {
            int lonDp = txtDP_ImpPrincipal.Text.Length;
            string ComillaSimple;
            ComillaSimple = txtDP_ImpPrincipal.Text;
            if (lonDp >= 99)
            {
                MessageBox.Show("Ha escrito demasiado texto, Disminuya el texto");
       
            }
            else if (ComillaSimple.Contains("'"))
            {
                MessageBox.Show("No puede ingresar comillas simples");
                txtDP_ImpPrincipal.Text = "";
            }
        }

        private void txtTribunal_ImpPrincipal_TextChanged(object sender, EventArgs e)
        {
            int lonTri = txtTribunal_ImpPrincipal.Text.Length;
            if (lonTri >= 99)
            {
                MessageBox.Show("Ha escrito demasiado texto, Disminuya el texto");

            }
        }

        private void txtReferencia_ImpPrincipal_TextChanged(object sender, EventArgs e)
        {
            int lonRe = txtReferencia_ImpPrincipal.Text.Length;
            if (lonRe >= 99)
            {
                MessageBox.Show("Ha escrito demasiado texto, Disminuya el texto");

            }
        }

        private void txtDproceso_ImpPrincipal_TextChanged(object sender, EventArgs e)
        {
            int lonDEP = txtDproceso_ImpPrincipal.Text.Length;
            if (lonDEP >= 99)
            {
                MessageBox.Show("Ha escrito demasiado texto, Disminuya el texto");

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            int lonNombre = txtNombre.Text.Length;
            string ComillaSimple;
            ComillaSimple = txtNombre.Text;
            if (lonNombre >= 99)
            {
                MessageBox.Show("Ha escrito demasiado texto, Disminuya el texto");

            }
            else if (ComillaSimple.Contains("'"))
            {
                MessageBox.Show("No puede ingresar comillas simples");
                txtNombre.Text = "";
            }

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            int lonApellido = txtApellido.Text.Length;
            string ComillaSimple;
            ComillaSimple = txtApellido.Text;

            if (lonApellido >= 99)
            {
                MessageBox.Show("Ha escrito demasiado texto, Disminuya el texto");

            }
            if (ComillaSimple.Contains("'"))
            {
                MessageBox.Show("No puede ingresar comillas simples");
                txtApellido.Text = "";
            }
        }

        private void DataGridViewIMPp_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = DataGridViewIMPp.Rows.GetRowCount(DataGridViewElementStates.Selected);
            try
            {
                if (DataGridViewIMPp.Rows.Count <= 0)
                {
                    MessageBox.Show("Seleccione un registro por favor");
                }
                else if (DataGridViewIMPp.Rows.Count > 0)
                {
                    if (selectedRowCount <= 0)
                    {
                        MessageBox.Show("Seleccione un registro");
                    }
                    else
                    {
                        if (DataGridViewIMPp.AreAllCellsSelected(true))
                        {
                            MessageBox.Show("All cells are selected", "Selected Cells");
                        }
                        else
                        {
                            if (DataGridViewIMPp.Rows[e.RowIndex].IsNewRow)
                            {
                                MessageBox.Show("Ultima fila seleccionada");

                            }
                            else
                            {
                                Imputadoid = Convert.ToInt32(DataGridViewIMPp.Rows[e.RowIndex].Cells[0].Value.ToString());
                                DPdatagrid = DataGridViewIMPp.Rows[e.RowIndex].Cells[1].Value.ToString();
                                txtNombre.Text = DataGridViewIMPp.Rows[e.RowIndex].Cells[2].Value.ToString();
                                txtApellido.Text = DataGridViewIMPp.Rows[e.RowIndex].Cells[3].Value.ToString();
                                GeneroDataGrid = DataGridViewIMPp.Rows[e.RowIndex].Cells[4].Value.ToString();
                                GeneroSeleccionado();
                                ImputadoValidado = 1;//ESPECIALLLLLLLLLLLLLL
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
