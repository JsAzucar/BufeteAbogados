using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConfIniciales
{
    public partial class HistorialImpresiones : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\INSTALADORPROCUSOYAPANGO\BASEPROCURADURIA\BASEPROCURADURIA.MDF;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds = new DataSet();
        SqlDataReader lector;

        private void displayHistorial()
        {
            try
            {
                con.Open();
                adpt = new SqlDataAdapter("select * from InfoPenalImpresiones", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dgvHistorial.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void displayBusqueda()
        {
            try
            {
                string ComillaSimple;
                ComillaSimple = txtDP.Text;

                if (ComillaSimple.Contains("'"))
                {
                    MessageBox.Show("No puede ingresar comillas simples");
                    txtDP.Text = "";
                }
                else
                {
                    if (txtDP.Text.Length > 0)
                    {

                        con.Open();
                        adpt = new SqlDataAdapter("select * from InfoPenalImpresiones where DP like '" + txtDP.Text + "%'", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        dgvHistorial.DataSource = dt;
                        con.Close();
                    }
                    else if (txtDP.Text.Length == 0)
                    {
                        displayHistorial();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public HistorialImpresiones()
        {
            InitializeComponent();
            dgvHistorial.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            displayHistorial();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.PaleVioletRed, 2);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 62, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void PanelHistorial_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            displayBusqueda();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\ProcuAbogadosrr\");
        }

        private void dgvHistorial_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DirectoryInfo DIR = new DirectoryInfo(@"C:\ProcuAbogadosPDF");

            if (DIR.Exists)
            {

                System.Diagnostics.Process.Start(@"C:\ProcuAbogadosPDF\");
            }
            else
            {
                DIR.Create();
                System.Diagnostics.Process.Start(@"C:\ProcuAbogadosPDF\");
            }

        }

        private void txtDP_TextChanged(object sender, EventArgs e)
        {
            displayBusqueda();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DirectoryInfo DIR = new DirectoryInfo(@"C:\ProcuAbogadosPDF");

            if (DIR.Exists)
            {

                System.Diagnostics.Process.Start(@"C:\ProcuAbogadosPDF\");
            }
            else
            {
                DIR.Create();
                System.Diagnostics.Process.Start(@"C:\ProcuAbogadosPDF\");
            }

        }
    }
}
