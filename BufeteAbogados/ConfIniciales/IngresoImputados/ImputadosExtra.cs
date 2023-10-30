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
    public partial class ImputadosExtra : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\INSTALADORPROCUSOYAPANGO\BASEPROCURADURIA\BASEPROCURADURIA.MDF;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds = new DataSet();
        SqlDataReader lector;

        private Form currentChilForm; //Campo para almacenar el formulario hijo actual
        string DPprincipal;

        int IdDeliVictimas;
        int IdImputadosSelect;
        int ImputadoValidado = -1;
        int IdTeoriasCaso;
        string HechoPunible;
        string Vicitma;
        string DpVariable;
        int ValidacionArriba;
        int ValidacionAbajo;


        public ImputadosExtra()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
           
            dgvFunciona.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            dgvTeorias.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;


            try
            {
                displayDataImputado();
                displayTeorias();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public ImputadosExtra(string DPfechaPrincipal)
        {
            InitializeComponent();
            dgvFunciona.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            dgvTeorias.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            DoubleBuffered = true;
            DPprincipal =DPfechaPrincipal;
            LabelInformacion.Text = DPfechaPrincipal;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;

            try
            {
                displayDataImputado();
                displayTeorias();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Función

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtSfiscalia.Text = "";
            txtSdefensor.Text = "";
            txtInfoExtra.Text = "";
        }
        private void LimpiarPrincipio()
        {
            txtName.Text = "";
            txtLastName.Text = "";
        }
        private void displayTeorias()
        {
            try
            {
                con.Open();
                adpt = new SqlDataAdapter("select IdTeoCasos,IdImputados,DP,NOMBRE,APELLIDO,TeoFiscalia,TeoDefensor,InfoExtra from TeoCasoComent where DP like '" + DPprincipal + "'", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dgvTeorias.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayDataImputado()
        {
            try
            {
                con.Open();
                adpt = new SqlDataAdapter("select * from DeliVictimas where DP like '" + DPprincipal + "'", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dgvFunciona.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void OpenChildForm(Form childForm)
        {
            try
            {

                if (currentChilForm != null)
                {
                    currentChilForm.Visible = false;
                }
                currentChilForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                PanelImputadosExtra.Controls.Add(childForm);
                PanelImputadosExtra.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ImputadosExtra_Load(object sender, EventArgs e)
        {

        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void PanelImputadosExtra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegresar_Click_1(object sender, EventArgs e)
        {
        }

        private void BtnSiguiente_Click_1(object sender, EventArgs e)
        {
        }
        private void BTNguardar_Click(object sender, EventArgs e)
        {
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void txtSfiscalia_TextChanged(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void PanelImputadosExtra_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void txtInfoExtra_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void txtInfoExtra_TextChanged_1(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void txtSdefensor_TextChanged(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewIMPp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void DataGridViewIMPp_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAgregar2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtApellido.Text == "")
                {
                    MessageBox.Show("Seleccione un registro");
                }
                else
                {

                    adpt = new SqlDataAdapter("select * from TeoCasoComent where IdImputados like '" + IdImputadosSelect + "'", con);
                    adpt.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    if (i > 0)
                    {
                            MessageBox.Show(" Ya ingreso un registro con ese nombre y apellido,Por favor seleccione otro registro");
                            ds.Clear();

                        
                    }
                    else
                    {





                        con.Open();
                        cmd = new SqlCommand("insert into TeoCasoComent values (@IdImputados,@DP,@NOMBRE,@APELLIDO,@TeoFiscalia,@TeoDefensor,@InfoExtra)", con);
                       
                        cmd.Parameters.AddWithValue("@IdImputados", IdImputadosSelect);
                        cmd.Parameters.AddWithValue("@DP", DpVariable);
                        cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@APELLIDO", txtApellido.Text);
                        cmd.Parameters.AddWithValue("@TeoFiscalia", txtSfiscalia.Text);
                        cmd.Parameters.AddWithValue("@TeoDefensor", txtSdefensor.Text);
                        cmd.Parameters.AddWithValue("@InfoExtra", txtInfoExtra.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Su informacion se ha guardado correctamente");
                        con.Close();
                        displayTeorias();
                        ImputadoValidado = -1;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtApellido.Text == "")
                {
                    MessageBox.Show("Seleccione un registro");
                }
                else
                {
                    if (ImputadoValidado == -1)
                    {
                        MessageBox.Show("Seleccione un registro existente de la tabla que se encuentra en el lado izquiedo de la pantalla");
                    }
                    else if (ImputadoValidado == 1)
                    {
                        con.Open();
                        cmd = new SqlCommand("update TeoCasoComent set TeoFiscalia=@TeoFiscalia,TeoDefensor=@TeoDefensor,InfoExtra=@InfoExtra where IdTeoCasos=@IdTeoCasos", con);
                        cmd.Parameters.AddWithValue("@IdTeoCasos", IdTeoriasCaso);
                        cmd.Parameters.AddWithValue("@TeoFiscalia", txtSfiscalia.Text);
                        cmd.Parameters.AddWithValue("@TeoDefensor", txtSdefensor.Text);
                        cmd.Parameters.AddWithValue("@InfoExtra", txtInfoExtra.Text);
                        //cmd.Parameters.AddWithValue("@InfoExtra", txtInfoExtra.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("El registro se ha actualizado correctamente");
                        con.Close();
                        displayTeorias();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                        MessageBox.Show("Seleccione un registro existente de la tabla que se encuentra en el lado izquiedo de la pantalla");
                    }
                    else if (ImputadoValidado == 1)
                    {

                        con.Open();
                        cmd = new SqlCommand("delete from TeoCasoComent where IdTeoCasos='" + IdTeoriasCaso + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("La información se elimino correctamente");
                        con.Close();
                        Limpiar();
                        displayTeorias();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSiguiente_Click_2(object sender, EventArgs e)
        {
            try
            {

                DialogResult GuardarCambios = MessageBox.Show("Antes de continuar asegúrese de guardar los cambios realizados, Si ya los guardo continue ( SI )", "OJO", MessageBoxButtons.YesNo);
                if (GuardarCambios == DialogResult.Yes)
                {
                    OpenChildForm(new ConfIniciales.IngresoImputados.PantallaFinalizacion());
                }
                else if (GuardarCambios == DialogResult.No)
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult GuardarCambios = MessageBox.Show("¿ Antes de regresar asegúrese de guardar los cambios realizados, Si ya los guardo continue ( SI )?", "OJO", MessageBoxButtons.YesNo);
                if (GuardarCambios == DialogResult.Yes)
                {
                    OpenChildForm(new ConfIniciales.IngresoImputados.FechasAudiencias(DPprincipal));
                }
                else if (GuardarCambios == DialogResult.No)
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDPApellido_TextChanged(object sender, EventArgs e)
        {
            string ComillaSimple;
            ComillaSimple = txtDPApellido.Text;

            if (ComillaSimple.Contains("'"))
            {
                MessageBox.Show("No puede ingresar comillas simples");
                txtDPApellido.Text = "";
            }
            else
            {
                try
                {
                    if (txtDPApellido.Text.Length > 0 || txtDPNombre.Text.Length > 0)
                    {
                        con.Open();
                        adpt = new SqlDataAdapter("select *from TeoCasoComent where APELLIDO like'" + txtDPApellido.Text + "%' AND DP like'" + DPprincipal + "%'", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvTeorias.DataSource = dt;
                    }
                    else if (txtDPNombre.Text.Length == 0 || txtDPApellido.Text.Length == 0)
                    {
                        displayTeorias();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void DataGridViewIMPp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTeorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Int32 selectedRowCount = dgvTeorias.Rows.GetRowCount(DataGridViewElementStates.Selected);
            try
            {
                if (dgvTeorias.Rows.Count <= 0)
                {
                    MessageBox.Show("Seleccione un registro por favor");
                }
                else if (dgvTeorias.Rows.Count > 0)
                {
                    if (selectedRowCount <= 0)
                    {
                        MessageBox.Show("Seleccione un registro");
                    }
                    else
                    {
                        if (dgvTeorias.AreAllCellsSelected(true))
                        {
                            MessageBox.Show("All cells are selected", "Selected Cells");
                        }
                        else
                        {
                            if (dgvTeorias.Rows[e.RowIndex].IsNewRow)
                            {
                                MessageBox.Show("Ultima fila seleccionada");

                            }
                            else
                            {

                                try
                                {

                                    DialogResult GuardarCambios = MessageBox.Show("¿ Esta seguro que desea seleccionar otro registro?, Si ya guardo la información de este registro, continúe ( SI )?", "OJO", MessageBoxButtons.YesNo);
                                    if (GuardarCambios == DialogResult.Yes)
                                    {

                                        IdImputadosSelect = Convert.ToInt32(dgvTeorias.Rows[e.RowIndex].Cells[1].Value.ToString());
                                        IdTeoriasCaso = Convert.ToInt32(dgvTeorias.Rows[e.RowIndex].Cells[0].Value.ToString());
                                        DpVariable = dgvTeorias.Rows[e.RowIndex].Cells[2].Value.ToString();
                                        txtNombre.Text = dgvTeorias.Rows[e.RowIndex].Cells[3].Value.ToString();
                                        txtApellido.Text = dgvTeorias.Rows[e.RowIndex].Cells[4].Value.ToString();
                                        txtSfiscalia.Text = dgvTeorias.Rows[e.RowIndex].Cells[5].Value.ToString();
                                        txtSdefensor.Text = dgvTeorias.Rows[e.RowIndex].Cells[6].Value.ToString();
                                        txtInfoExtra.Text = dgvTeorias.Rows[e.RowIndex].Cells[7].Value.ToString();
                                        LBLNOMBRE.Text = dgvTeorias.Rows[e.RowIndex].Cells[3].Value.ToString();
                                        LABELAPELLIDO.Text = dgvTeorias.Rows[e.RowIndex].Cells[4].Value.ToString();
                                        LBLREGISTRO.Text = dgvTeorias.Rows[e.RowIndex].Cells[1].Value.ToString();
                                        lblRegistration2.Text = dgvTeorias.Rows[e.RowIndex].Cells[1].Value.ToString();
                                        LBLTABLA.Text = "DE ABAJO";
                                        lblTablaInterme.Text = "DE ABAJO";
                                        ImputadoValidado = 1;//ESPECIALLLLLLLLLLLLLL
                                    }
                                    else if (GuardarCambios == DialogResult.No)
                                    {

                                    }
                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

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

        private void label7_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtDPNombre_TextChanged(object sender, EventArgs e)
        {
            string ComillaSimple;
            ComillaSimple = txtDPNombre.Text;

            if (ComillaSimple.Contains("'"))
            {
                MessageBox.Show("No puede ingresar comillas simples");
                txtDPNombre.Text = "";
            }
            else
            {
                try
                {
                    if (txtDPNombre.Text.Length > 0 || txtDPApellido.Text.Length > 0)
                    {
                        con.Open();
                        adpt = new SqlDataAdapter("select *from TeoCasoComent where NOMBRE like'" + txtDPNombre.Text + "%' AND DP like'" + DPprincipal + "%'", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvTeorias.DataSource = dt;
                    }

                    else if (txtDPNombre.Text.Length == 0 || txtDPApellido.Text.Length == 0)
                    {
                        displayTeorias();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void LBLREGISTRO_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtSfiscalia_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void LBLTABLA_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewIMPp_CellDoubleClick_2(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvImputado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridViewIMPp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvFunciona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFunciona_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridViewIMPp_CellDoubleClick_3(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgvFunciona.Rows.GetRowCount(DataGridViewElementStates.Selected);
            try
            {
                if (dgvFunciona.Rows.Count <= 0)
                {
                    MessageBox.Show("Seleccione un registro por favor");
                }
                else if (dgvFunciona.Rows.Count > 0)
                {
                    if (selectedRowCount <= 0)
                    {
                        MessageBox.Show("Seleccione un registro");
                    }
                    else
                    {
                        if (dgvFunciona.AreAllCellsSelected(true))
                        {
                            MessageBox.Show("All cells are selected", "Selected Cells");
                        }
                        else
                        {
                            if (dgvFunciona.Rows[e.RowIndex].IsNewRow)
                            {
                                MessageBox.Show("Ultima fila seleccionada");

                            }
                            else
                            {
                                ValidacionArriba = dgvFunciona.Rows.Count;
                                ValidacionAbajo = dgvTeorias.Rows.Count;

                                if (ValidacionArriba != ValidacionAbajo)
                                {
                                    IdDeliVictimas = Convert.ToInt32(dgvFunciona.Rows[e.RowIndex].Cells[0].Value.ToString());
                                    IdImputadosSelect = Convert.ToInt32(dgvFunciona.Rows[e.RowIndex].Cells[1].Value.ToString());
                                    DpVariable = dgvFunciona.Rows[e.RowIndex].Cells[2].Value.ToString();
                                    txtNombre.Text = dgvFunciona.Rows[e.RowIndex].Cells[3].Value.ToString();
                                    txtApellido.Text = dgvFunciona.Rows[e.RowIndex].Cells[4].Value.ToString();
                                    HechoPunible = dgvFunciona.Rows[e.RowIndex].Cells[5].Value.ToString();
                                    Vicitma = dgvFunciona.Rows[e.RowIndex].Cells[6].Value.ToString();
                                    LBLNOMBRE.Text = dgvFunciona.Rows[e.RowIndex].Cells[3].Value.ToString();
                                    LABELAPELLIDO.Text = dgvFunciona.Rows[e.RowIndex].Cells[4].Value.ToString();
                                    LBLREGISTRO.Text = dgvFunciona.Rows[e.RowIndex].Cells[1].Value.ToString();
                                    lblRegistration2.Text = dgvFunciona.Rows[e.RowIndex].Cells[1].Value.ToString();
                                    ImputadoValidado = -1;
                                    LBLTABLA.Text = "DE ARRIBA";
                                    lblTablaInterme.Text = "DE ARRIBA";
                                    txtSfiscalia.Text = "";
                                    txtSdefensor.Text = "";
                                    txtInfoExtra.Text = "";
                                    displayDataImputado();
                                }
                                else
                                {
                                    MessageBox.Show("Para cambiar de registro utilice la tabla que se encuentra abajo");
                                }

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

        private void dgvFunciona_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string ComillaSimple;
            ComillaSimple = txtLastName.Text;

            if (ComillaSimple.Contains("'"))
            {
                MessageBox.Show("No puede ingresar comillas simples");
                txtLastName.Text = "";
            }
            else
            {
                try
                {
                    if (txtName.Text.Length > 0 || txtLastName.Text.Length > 0)
                    {
                        con.Open();
                        adpt = new SqlDataAdapter("select *from DeliVictimas where NOMBRE like'" + txtName.Text + "%' AND DP like'" + DPprincipal + "%'", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvFunciona.DataSource = dt;
                    }
                    else if (txtName.Text.Length == 0 || txtLastName.Text.Length == 0)
                    {
                        displayDataImputado();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            string ComillaSimple;
            ComillaSimple = txtLastName.Text;

            if (ComillaSimple.Contains("'"))
            {
                MessageBox.Show("No puede ingresar comillas simples");
                txtLastName.Text = "";
            }
            else
            {
                try
                {
                    if (txtName.Text.Length > 0 || txtLastName.Text.Length > 0)
                    {
                        con.Open();
                        adpt = new SqlDataAdapter("select *from DeliVictimas where APELLIDO like'" + txtLastName.Text + "%' AND DP like'" + DPprincipal + "%'", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvFunciona.DataSource = dt;
                    }
                    else if (txtName.Text.Length == 0 || txtLastName.Text.Length == 0)
                    {
                        displayDataImputado();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            LimpiarPrincipio();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
