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
    public partial class DelitosVictimas : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\INSTALADORPROCUSOYAPANGO\BASEPROCURADURIA\BASEPROCURADURIA.MDF;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds = new DataSet();
        SqlDataReader lector;


        private Form currentChilForm; //Campo para almacenar el formulario hijo actual
        int IdImputadosHechos;
        int IdDeliVictimas;
        string GeneroSelect;
        string DPimp;
        string DpHechoPunible;
       

        public DelitosVictimas()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            BtnSiguiente.Visible = false;
            BtnSiguiente.Visible = true;
            dgvDeliVicti.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            dgvHechos.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);


        }


    

        public DelitosVictimas(string DPprincipalDelitosUnicos1)
        {
            InitializeComponent();
            DPimp =DPprincipalDelitosUnicos1;
            DpHechoPunible =DPprincipalDelitosUnicos1;
            LabelInformacion.Text =DPprincipalDelitosUnicos1;
            dgvDeliVicti.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            dgvHechos.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            try
            {

                displayData();
                displayHechoVictima();

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
            adpt = new SqlDataAdapter("select * from IngresaIMP where DP like '"+DPimp+"'", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvDeliVicti.DataSource = dt;
            con.Close();
        }
        private void displayHechoVictima()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from DeliVictimas where DP like '"+DPimp+"'", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvHechos.DataSource = dt;
            con.Close();

        }
        private void Limpiar()
        {
            txtNombreDelito.Text = "";
            txtApellidoDelito.Text = "";
            txtHechoPunible.Text = "";
            txtInfoVictima.Text = "";
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
                PanelDelitosVictima.Controls.Add(childForm);
                PanelDelitosVictima.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //********************************************************************

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConfIniciales.IngresoImputados.FechasAudiencias(DPimp));

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConfIniciales.IngresoImputados.ImputadosPrincipal(DPimp));
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void PanelDelitosVictima_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DelitosVictimas_Load(object sender, EventArgs e)
        {
           
        }

        private void dgvDeliVicti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgvDeliVicti.Rows.GetRowCount(DataGridViewElementStates.Selected);
            try
            {
                if (dgvDeliVicti.Rows.Count <= 0)
                {
                    MessageBox.Show("Seleccione un registro por favor");
                }
                else if (dgvDeliVicti.Rows.Count > 0)
                {
                    if (selectedRowCount <= 0)
                    {
                        MessageBox.Show("Seleccione un registro");
                    }
                    else
                    {
                        if (dgvDeliVicti.AreAllCellsSelected(true))
                        {
                            MessageBox.Show("All cells are selected", "Selected Cells");
                        }
                        else
                        {
                            if (dgvDeliVicti.Rows[e.RowIndex].IsNewRow)
                            {
                                MessageBox.Show("Ultima fila seleccionada");

                            }
                            else
                            {

                                IdImputadosHechos = Convert.ToInt32(dgvDeliVicti.Rows[e.RowIndex].Cells[0].Value.ToString());
                                DpHechoPunible = dgvDeliVicti.Rows[e.RowIndex].Cells[1].Value.ToString();
                                txtNombreDelito.Text = dgvDeliVicti.Rows[e.RowIndex].Cells[2].Value.ToString();
                                txtApellidoDelito.Text = dgvDeliVicti.Rows[e.RowIndex].Cells[3].Value.ToString();
                                GeneroSelect = dgvDeliVicti.Rows[e.RowIndex].Cells[4].Value.ToString();

                                txtHechoPunible.Text = "";
                                txtInfoVictima.Text = "";

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

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombreDelito.Text == "" || txtApellidoDelito.Text == "")
                {
                    MessageBox.Show("Primero seleccione un registro de la tabla");
                }
                else
                {
                        con.Open();
                        cmd = new SqlCommand("insert into DeliVictimas values(@IdImputados,@DP,@NOMBRE,@APELLIDO,@HechoPunible,@InfoVictima)", con);
                        cmd.Parameters.AddWithValue("@IdImputados", IdImputadosHechos);
                        cmd.Parameters.AddWithValue("@DP", DPimp);
                        cmd.Parameters.AddWithValue("@NOMBRE", txtNombreDelito.Text);
                        cmd.Parameters.AddWithValue("@APELLIDO", txtApellidoDelito.Text);
                        cmd.Parameters.AddWithValue("@HechoPunible", txtHechoPunible.Text);
                        cmd.Parameters.AddWithValue("@InfoVictima", txtInfoVictima.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Su informacion se ha guardado correctamente");
                        con.Close();
                        Limpiar();
                        displayHechoVictima();
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEditarHecho_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombreDelito.Text == "" || txtApellidoDelito.Text == "")
                {
                    MessageBox.Show("Primero seleccione un registro de la tabla de la derecha");
                }
                else
                {
                        con.Open();
                        cmd = new SqlCommand("update DeliVictimas set HechoPunible=@HechoPunible,InfoVictima=@InfoVictima where IdDeliVictimas=@IdDeliVictimas", con);
                        cmd.Parameters.AddWithValue("@IdDeliVictimas", IdDeliVictimas);
                        cmd.Parameters.AddWithValue("@HechoPunible", txtHechoPunible.Text);
                        cmd.Parameters.AddWithValue("@InfoVictima", txtInfoVictima.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("El registro se ha actualizado correctamente");
                        con.Close();
                        Limpiar();
                        displayHechoVictima();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHechos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dgvHechos.Rows.GetRowCount(DataGridViewElementStates.Selected);
            try
            {
                if (dgvHechos.Rows.Count <= 0)
                {
                    MessageBox.Show("Seleccione un registro por favor");
                }
                else if (dgvHechos.Rows.Count > 0)
                {
                    if (selectedRowCount <= 0)
                    {
                        MessageBox.Show("Seleccione un registro");
                    }
                    else
                    {
                        if (dgvHechos.AreAllCellsSelected(true))
                        {
                            MessageBox.Show("All cells are selected", "Selected Cells");
                        }
                        else
                        {
                            if (dgvHechos.Rows[e.RowIndex].IsNewRow)
                            {
                                MessageBox.Show("Ultima fila seleccionada");

                            }
                            else
                            {
                                IdDeliVictimas = Convert.ToInt32(dgvHechos.Rows[e.RowIndex].Cells[0].Value.ToString());
                                IdImputadosHechos = Convert.ToInt32(dgvHechos.Rows[e.RowIndex].Cells[1].Value.ToString());
                                DpHechoPunible = dgvHechos.Rows[e.RowIndex].Cells[2].Value.ToString();
                                txtNombreDelito.Text = dgvHechos.Rows[e.RowIndex].Cells[3].Value.ToString();
                                txtApellidoDelito.Text = dgvHechos.Rows[e.RowIndex].Cells[4].Value.ToString();
                                txtHechoPunible.Text = dgvHechos.Rows[e.RowIndex].Cells[5].Value.ToString();
                                txtInfoVictima.Text = dgvHechos.Rows[e.RowIndex].Cells[6].Value.ToString();
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

        private void btnEliminarHecho_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreDelito.Text == "" && txtApellidoDelito.Text == "")
                {
                    MessageBox.Show("Primero seleccione un registro de la tabla de la derecha");
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("delete from DeliVictimas where IdDeliVictimas='"+IdDeliVictimas+"'",con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La informació se ha eliminado correctamente");
                    con.Close();
                    Limpiar();
                    displayHechoVictima();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, consulte al administrador del programa");

            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dgvHechos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDeliVicti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PanelDelitosVictima_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtNombreDelito_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtApellidoDelito_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtNombreDelito_TextChanged(object sender, EventArgs e)
        {
            int lonNombre = txtNombreDelito.Text.Length;
            if (lonNombre >= 99)
            {
                MessageBox.Show("Ha escrito demasiado texto, Disminuya el texto");

            }
        }

        private void txtApellidoDelito_TextChanged(object sender, EventArgs e)
        {
            int lonApellido = txtApellidoDelito.Text.Length;
            if (lonApellido >= 99)
            {
                MessageBox.Show("Ha escrito demasiado texto, Disminuya el texto");

            }
        }

        private void txtHechoPunible_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
