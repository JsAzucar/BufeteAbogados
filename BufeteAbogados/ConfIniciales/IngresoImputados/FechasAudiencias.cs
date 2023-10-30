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
    public partial class FechasAudiencias : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\INSTALADORPROCUSOYAPANGO\BASEPROCURADURIA\BASEPROCURADURIA.MDF;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds = new DataSet();
        SqlDataReader lector;



        private Form currentChilForm; //Campo para almacenar el formulario hijo actual
        string DPprincipal;
        string DPseleccinar;
        int IdFechas;
        int IDimputados;
        string AudienciaIMP;
        string AudienciasDataGrid;
        string generoIMP;

        public FechasAudiencias()
        {
            InitializeComponent();
            rdbINICIAL.Checked = true;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEspecial.Enabled = false;
            dgvImputado.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            dgvFechas.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);

        }
        //Constructores
        public FechasAudiencias(string DPdelitosVictimas)
        {
            InitializeComponent();
            DPprincipal =DPdelitosVictimas;
            LabelInformacion.Text=DPdelitosVictimas;
            DPseleccinar=DPdelitosVictimas;
            rdbINICIAL.Checked = true;
            txtNombre.Enabled = false;
            txtEspecial.Enabled = false;
            txtApellido.Enabled = false;
            dgvImputado.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            dgvFechas.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);


            try
            { 
               displayData();
                displayFecha();

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
            dt = new DataTable();
            adpt.Fill(dt);
            dgvImputado.DataSource = dt;
            con.Close();
        }
        private void displayFecha()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from FechasAud where DP like '" + DPprincipal + "'", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvFechas.DataSource = dt;
            con.Close();
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            rdbINICIAL.Checked = true;
            txtEspecial.Text = "";
        }
        //RadioButton
        private void Audiencia()
        {
            if (rdbINICIAL.Checked)
            {
                AudienciaIMP = "Inicial";

            }
            else if (rbdPRELIMINAR.Checked)
            {
                AudienciaIMP = "Preliminar";
            }
            else if(rbdSentencia.Checked)
            {
                AudienciaIMP = "Sentencia";

            }
            else if (rbdESPECIAL.Checked)
            {
                AudienciaIMP = "Especial";
                
            }
            else
            {
                AudienciaIMP = "";
            }
        }
        private void AudienciasSeleccionado()
        {
            if (AudienciasDataGrid == "Inicial")
            {
                rdbINICIAL.Checked = true;

            }
            else  if(AudienciasDataGrid == "Preliminar")
            {
                rbdPRELIMINAR.Checked = true;
            }
            else if (AudienciasDataGrid == "Sentencia")
            {
                rbdSentencia.Checked = true;
            }
            else if (AudienciasDataGrid == "Especial")
            {
                rbdESPECIAL.Checked = true;
            }
        }


        //*****************************************************************************************************

        private void FechasAudiencias_Load(object sender, EventArgs e)
        {
       
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
                PanelFechasAudiencias.Controls.Add(childForm);
                PanelFechasAudiencias.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConfIniciales.IngresoImputados.ImputadosExtra(DPprincipal));
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConfIniciales.IngresoImputados.DelitosVictimas(DPprincipal));
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void PanelFechasAudiencias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvImputado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgvImputado.Rows.GetRowCount(DataGridViewElementStates.Selected);
            try
            {
                if (dgvImputado.Rows.Count <= 0)
                {
                    MessageBox.Show("Seleccione un registro por favor");
                }
                else if (dgvImputado.Rows.Count > 0)
                {
                    if (selectedRowCount <= 0)
                    {
                        MessageBox.Show("Seleccione un registro");
                    }
                    else
                    {
                        if (dgvImputado.AreAllCellsSelected(true))
                        {
                            MessageBox.Show("All cells are selected", "Selected Cells");
                        }
                        else
                        {
                            if (dgvImputado.Rows[e.RowIndex].IsNewRow)
                            {
                                MessageBox.Show("Ultima fila seleccionada");

                            }
                            else
                            {
                                IDimputados = Convert.ToInt32(dgvImputado.Rows[e.RowIndex].Cells[0].Value.ToString());
                                DPseleccinar = dgvImputado.Rows[e.RowIndex].Cells[1].Value.ToString();
                                txtNombre.Text = dgvImputado.Rows[e.RowIndex].Cells[2].Value.ToString();
                                txtApellido.Text = dgvImputado.Rows[e.RowIndex].Cells[3].Value.ToString();
                                generoIMP = dgvImputado.Rows[e.RowIndex].Cells[4].Value.ToString();


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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombre.Text == "" || txtApellido.Text == "")
                {
                    MessageBox.Show("Escriba su nombre y su apellido");
                }
                else
                {
                   if(txtEspecial.Enabled==true && txtEspecial.Text=="")
                    {
                        MessageBox.Show("Complete la información del campo tipo de audiencia");
                    }
                    else
                    {
                        Audiencia();
                        con.Open();
                        cmd = new SqlCommand("insert into FechasAud values(@IdImputados,@DP,@Nombre,@Apellido,@Fecha,@Hora,@TipoAudiencia,@InfoAuEspecial)", con);
                        cmd.Parameters.AddWithValue("@IdImputados", IDimputados);
                        cmd.Parameters.AddWithValue("@DP", DPprincipal);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                        cmd.Parameters.AddWithValue("@Fecha", dateTimeFecha.Text);
                        cmd.Parameters.AddWithValue("@Hora", dateTimeHora.Text);
                        cmd.Parameters.AddWithValue("@TipoAudiencia", AudienciaIMP);
                        cmd.Parameters.AddWithValue("@InfoAuEspecial", txtEspecial.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Su informacion se ha guardado correctamente");
                        con.Close();
                        Limpiar();
                        displayFecha();
                    }
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                    if (txtEspecial.Enabled == true && txtEspecial.Text == "")
                    {
                        MessageBox.Show("Complete la información del campo tipo de audiencia");
                    }
                    else
                    {
                        Audiencia();
                        con.Open();
                        cmd = new SqlCommand("update FechasAud set Fecha=@Fecha,Hora=@Hora,TipoAudiencia=@TipoAudiencia,InfoAuEspecial=@InfoAuEspecial where IdFechasAud=@IdFechasAud", con);
                        cmd.Parameters.AddWithValue("@IdFechasAud", IdFechas);
                        cmd.Parameters.AddWithValue("@Fecha", dateTimeFecha.Text);
                        cmd.Parameters.AddWithValue("@Hora", dateTimeHora.Text);
                        cmd.Parameters.AddWithValue("@TipoAudiencia", AudienciaIMP);
                        cmd.Parameters.AddWithValue("@InfoAuEspecial", txtEspecial.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("El registro se ha actualizado correctamente");
                        con.Close();
                        Limpiar();
                        displayFecha();
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
                    con.Open();
                    cmd = new SqlCommand("delete from FechasAud where  IdFechasAud='" +IdFechas+ "'",con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El registro se ha eliminado correctamente");
                    con.Close();
                    Limpiar();
                    displayFecha();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgvFechas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgvFechas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            try
            {
                if (dgvFechas.Rows.Count <= 0)
                {
                    MessageBox.Show("Seleccione un registro por favor");
                }
                else if (dgvFechas.Rows.Count > 0)
                {
                    if (selectedRowCount <= 0)
                    {
                        MessageBox.Show("Seleccione un registro");
                    }
                    else
                    {
                        if (dgvFechas.AreAllCellsSelected(true))
                        {
                            MessageBox.Show("All cells are selected", "Selected Cells");
                        }
                        else
                        {
                            if (dgvFechas.Rows[e.RowIndex].IsNewRow)
                            {
                                MessageBox.Show("Ultima fila seleccionada");

                            }
                            else
                            {
                                
                                IdFechas =Convert.ToInt32(dgvFechas.Rows[e.RowIndex].Cells[0].Value.ToString());
                                IDimputados = Convert.ToInt32(dgvFechas.Rows[e.RowIndex].Cells[1].Value.ToString());
                                DPseleccinar = dgvFechas.Rows[e.RowIndex].Cells[2].Value.ToString();
                                txtNombre.Text = dgvFechas.Rows[e.RowIndex].Cells[3].Value.ToString();
                                txtApellido.Text = dgvFechas.Rows[e.RowIndex].Cells[4].Value.ToString();
                                dateTimeFecha.Text= dgvFechas.Rows[e.RowIndex].Cells[5].Value.ToString();
                                dateTimeHora.Text = dgvFechas.Rows[e.RowIndex].Cells[6].Value.ToString();
                                AudienciasDataGrid= dgvFechas.Rows[e.RowIndex].Cells[7].Value.ToString();
                                txtEspecial.Text = dgvFechas.Rows[e.RowIndex].Cells[8].Value.ToString();
                                AudienciasSeleccionado();


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

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void rbdESPECIAL_CheckedChanged(object sender, EventArgs e)
        {
            if(rbdESPECIAL.Checked)
            {
                txtEspecial.Enabled = true;
            }
            else
            {
                txtEspecial.Enabled = false;
                txtEspecial.Text = "";
                
            }
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void PanelFechasAudiencias_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
 
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            int lonNombre = txtNombre.Text.Length;
            if (lonNombre >= 99)
            {
                MessageBox.Show("Ha escrito demasiado texto, Disminuya el texto");

            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            int lonApellido = txtApellido.Text.Length;
            if (lonApellido >= 99)
            {
                MessageBox.Show("Ha escrito demasiado texto, Disminuya el texto");

            }
        }
    }
}
