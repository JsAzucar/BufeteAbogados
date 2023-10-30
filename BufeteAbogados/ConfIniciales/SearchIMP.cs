using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace ConfIniciales
{
    public partial class SearchIMP : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\INSTALADORPROCUSOYAPANGO\BASEPROCURADURIA\BASEPROCURADURIA.MDF;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds = new DataSet();
        SqlDataReader lector;
        string DPdatagrid;
        int IdUbicacion;
        string ActivarID;
        string NombreID;
        string ApellidoID;
        string YaEstuvo;
        int nFechaF;
        int nFechaV;
        int nFechaFilas;
        string delito;
        string nodelito;

        private Form currentChilForm; //Campo para almacenar el formulario hijo actual

        public SearchIMP()
        {
            InitializeComponent();
            dgvBuscar.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12, FontStyle.Bold);
            displayData();
           
        }
        //Funciones

        private void displayData()
        {
            con.Open();
            adpt = new SqlDataAdapter("SELECT *from InfoPenal", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvBuscar.DataSource = dt;
            con.Close();

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
                PanelBuscar.Controls.Add(childForm);
                PanelBuscar.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        private void displayDataVER()
        {
            con.Open();
            adpt = new SqlDataAdapter("SELECT *from InfoPenal", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvBuscar.DataSource = dt;
            con.Close();

        }
        private void displayDataELIMINAR()
        {
            con.Open();
            adpt = new SqlDataAdapter("SELECT *from InfoPenal", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvBuscar.DataSource = dt;
            con.Close();

        }

        private void BusquedaDinamicaDP()
        {

            try
            {

                SqlDataAdapter adptUNO = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',IMP.TipoGenero 'GENERO',INFO.TRIBUNAL 'TRIBUNAL',INFO.REFERENCIA 'REFERENCIA',INFO.DefensorCaso 'Defensor Caso',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA',FA.Hora 'HORA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where INFO.DP like'" + txtDPBuscar.Text + "%'", con);
                DataSet dsUNO = new DataSet();
                adptUNO.Fill(dsUNO);
                int iUNO = dsUNO.Tables[0].Rows.Count;

                SqlDataAdapter adptDOS = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados where INFO.DP like'" + txtDPBuscar.Text + "%'", con);
                DataSet dsDOS = new DataSet();
                adptDOS.Fill(dsDOS);
                int iDOS = dsDOS.Tables[0].Rows.Count;


                SqlDataAdapter adptTRES = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP where INFO.DP like'" + txtDPBuscar.Text + "%'", con);
                DataSet dsTRES = new DataSet();
                adptTRES.Fill(dsTRES);
                int iTRES = dsTRES.Tables[0].Rows.Count;

                SqlDataAdapter adptCUATRO = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso' FROM InfoPenal INFO where INFO.DP like'" + txtDPBuscar.Text + "%'", con);
                DataSet dsCUATRO = new DataSet();
                adptCUATRO.Fill(dsCUATRO);
                int iCUATRO = dsCUATRO.Tables[0].Rows.Count;



                if (txtDPBuscar.Text.Length > 0 || txtDPNombre.Text.Length > 0 || txtDPApellido.Text.Length > 0)
                {

                    if (iUNO > 0)
                    {
                        con.Open();
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',IMP.TipoGenero 'GENERO',INFO.TRIBUNAL 'TRIBUNAL',INFO.REFERENCIA 'REFERENCIA',INFO.DefensorCaso 'Defensor Caso',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA',FA.Hora 'HORA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where INFO.DP like'" + txtDPBuscar.Text + "%' order by IMP.NOMBRE", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;


                    }


                    else if (iDOS > 0)
                    {

                        con.Open();
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados where INFO.DP like'" + txtDPBuscar.Text + "%' order by IMP.NOMBRE", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;
                    }

                    else if (iTRES > 0)
                    {

                        con.Open();
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP where INFO.DP like'" + txtDPBuscar.Text + "%' order by IMP.NOMBRE", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;

                    }
                    else if (iCUATRO > 0)
                    {
                        con.Open();
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso' FROM InfoPenal INFO where INFO.DP like'" + txtDPBuscar.Text + "%'", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;

                    }
                    else
                    {
                        displayData();
                    }
                }
                else if (txtDPBuscar.Text.Length == 0 || txtDPNombre.Text.Length == 0 || txtDPApellido.Text.Length == 0)
                {
                    displayData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void BusquedaDinamicaNOMBRE()
        {
            try
            {

                SqlDataAdapter adptUNO = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA',FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where IMP.NOMBRE like'" + txtDPNombre.Text + "%'", con);
                DataSet dsUNO = new DataSet();
                adptUNO.Fill(dsUNO);
                int iUNO = dsUNO.Tables[0].Rows.Count;

                SqlDataAdapter adptDOS = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados where IMP.NOMBRE like'" + txtDPNombre.Text + "%'", con);
                DataSet dsDOS = new DataSet();
                adptDOS.Fill(dsDOS);
                int iDOS = dsDOS.Tables[0].Rows.Count;


                SqlDataAdapter adptTRES = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP where IMP.NOMBRE like'" + txtDPNombre.Text + "%'", con);
                DataSet dsTRES = new DataSet();
                adptTRES.Fill(dsTRES);
                int iTRES = dsTRES.Tables[0].Rows.Count;


                if (txtDPBuscar.Text.Length > 0 || txtDPNombre.Text.Length > 0 || txtDPApellido.Text.Length > 0)
                {

                    if (iUNO > 0)
                    {
                        con.Open();
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where IMP.NOMBRE like'" + txtDPNombre.Text + "%'  order by IMP.NOMBRE", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;
                    }


                    else if (iDOS > 0)
                    {

                        con.Open();
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados where IMP.NOMBRE like'" + txtDPNombre.Text + "%'  order by IMP.NOMBRE", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;
                    }

                    else if (iTRES > 0)
                    {

                        con.Open();
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP where IMP.NOMBRE like'" + txtDPNombre.Text + "%'  order by IMP.NOMBRE", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;

                    }
                    else
                    {
                        displayData();
                    }
                }
                else if (txtDPBuscar.Text.Length == 0 || txtDPNombre.Text.Length == 0 || txtDPApellido.Text.Length == 0)
                {
                    displayData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void BusquedaDinamicaAPELLIDO()
        {
            try
            {

                SqlDataAdapter adptUNO = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where IMP.APELLIDO like'" + txtDPApellido.Text + "%'", con);
                DataSet dsUNO = new DataSet();
                adptUNO.Fill(dsUNO);
                int iUNO = dsUNO.Tables[0].Rows.Count;

                SqlDataAdapter adptDOS = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados where IMP.APELLIDO like'" + txtDPApellido.Text + "%'", con);
                DataSet dsDOS = new DataSet();
                adptDOS.Fill(dsDOS);
                int iDOS = dsDOS.Tables[0].Rows.Count;


                SqlDataAdapter adptTRES = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP where IMP.APELLIDO like'" + txtDPApellido.Text + "%'", con);
                DataSet dsTRES = new DataSet();
                adptTRES.Fill(dsTRES);
                int iTRES = dsTRES.Tables[0].Rows.Count;



                if (txtDPBuscar.Text.Length > 0 || txtDPNombre.Text.Length > 0 || txtDPApellido.Text.Length > 0)
                {

                    if (iUNO > 0)
                    {
                        con.Open();
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where IMP.APELLIDO like'" + txtDPApellido.Text + "%' order by IMP.NOMBRE", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;
                    }


                    else if (iDOS > 0)
                    {

                        con.Open();
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados where IMP.APELLIDO like'" + txtDPApellido.Text + "%' order by IMP.NOMBRE", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;
                    }

                    else if (iTRES > 0)
                    {

                        con.Open();
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP where IMP.APELLIDO like'" + txtDPApellido.Text + "%' order by IMP.NOMBRE", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;

                    }
                    else
                    {
                        displayData();
                    }
                }
                else if (txtDPBuscar.Text.Length == 0 || txtDPNombre.Text.Length == 0 || txtDPApellido.Text.Length == 0)
                {
                    displayData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.PaleVioletRed, 2);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 62, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.PaleVioletRed, 2);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 62, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void dgvBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Int32 selectedRowCount = dgvBuscar.Rows.GetRowCount(DataGridViewElementStates.Selected);
            try
            {
                if (dgvBuscar.Rows.Count <= 0)
                {
                    MessageBox.Show("Seleccione un registro por favor");
                }
                else if (dgvBuscar.Rows.Count > 0)
                {
                    if (selectedRowCount <= 0)
                    {
                        MessageBox.Show("Seleccione un registro");
                    }
                    else
                    {
                        if (dgvBuscar.AreAllCellsSelected(true))
                        {
                            MessageBox.Show("All cells are selected", "Selected Cells");
                        }
                        else
                        {
                            if (dgvBuscar.Rows[e.RowIndex].IsNewRow)
                            {
                                MessageBox.Show("Ultima fila seleccionada");

                            }
                            else
                            {
                                    DPdatagrid = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();
                                    txtDPEditar.Text = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();
                                    txtDPEliminar.Text = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();
                                    txtDpLlenar.Text = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();
                                    txtDPBuscar.Text = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();

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

        private void txtDPBuscar_TextChanged(object sender, EventArgs e)
        {
            string ComillaSimple;
            ComillaSimple = txtDPBuscar.Text;

            if (ComillaSimple.Contains("'"))
            {
                MessageBox.Show("No puede ingresar comillas simples");
                txtDPBuscar.Text = "";
            }
            else
            {
                BusquedaDinamicaDP();
            }

            
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
                BusquedaDinamicaNOMBRE();
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
                BusquedaDinamicaAPELLIDO();
            }
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDPEditar.Text == "")
                {
                    MessageBox.Show("Ingrese el DP");
                }
                else
                {
                    adpt = new SqlDataAdapter("select * from InfoPenal where DP like '" + txtDPEditar.Text + "'", con);
                    adpt.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    if (i > 0)
                    {

                        OpenChildForm(new ConfIniciales.IngresoImputados.ImputadosPrincipal(txtDPEditar.Text));
                    }
                    else
                    {
                        MessageBox.Show("El DP que escribio esta incorrecto o no existe");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDPEditar.Text == "")
                {
                    MessageBox.Show("Ingrese el DP");
                }
                else
                {
                    adpt = new SqlDataAdapter("select * from InfoPenal where DP like '" + txtDPEditar.Text + "'", con);
                    adpt.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    if (i > 0)
                    {

                        DialogResult mensaje = MessageBox.Show("Estas seguro que desea eliminar este expediente", "OJO", MessageBoxButtons.YesNo);
                        if (mensaje == DialogResult.Yes)
                        {
                            con.Open();
                            cmd = new SqlCommand("delete from InfoPenal where DP='" + txtDPEliminar.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("La DP se elimino correctamente");
                            con.Close();
                            txtDPEliminar.Text = "";
                            txtDPEditar.Text = "";
                            txtDpLlenar.Text = "";
                            displayData();

                        }
                        else if (mensaje == DialogResult.No)
                        {
                            //No
                        }


                    }
                    else
                    {
                        MessageBox.Show("El DP que escribio esta incorrecto o no existe");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                
                DirectoryInfo DIR = new DirectoryInfo(@"C:\ProcuAbogadosPDF");
                string Combinado = "" + txtDpLlenar.Text + " &COPIA& " + txtDPpdf.Text + "";

                if (DIR.Exists)
                {
                    //No pasa nada
                }
                else
                {
                    DIR.Create();
                }

                if (txtDpLlenar.Text == "")
                {
                    MessageBox.Show("Por favor seleccione un DP de la tabla");
                }
                else
                {
                    //txtDpLlenar.Text = dgvBuscar.CurrentRow.Cells["DP"].Value.ToString();
                    ActivarID = txtDpLlenar.Text;
                    YaEstuvo = "";

                    if (txtDPpdf.Text == "")
                    {
                        MessageBox.Show("Por favor, ingrese un nombre para el PDF!");
                    }
                    else
                    {
                        string carpeta = @"C:\ProcuAbogadosPDF";

                        string archivo = @"" + ActivarID + " &COPIA& " + txtDPpdf.Text + ".pdf";

                        if (File.Exists(Path.Combine(carpeta, archivo)))
                        {
                            MessageBox.Show("El archivo existe, por favor ingrese otro nombre para el archivo");

                        }
                        else
                        {
                            //string PDFNOMBRE = txtDPBuscar.Text = dgvBuscar.CurrentRow.Cells["DP"].Value.ToString();

                            DialogResult mensaje = MessageBox.Show("Estas seguro que deseas Imprimir el DP [" + Combinado + " en PDF ]?", "OJO", MessageBoxButtons.YesNo);
                            if (mensaje == DialogResult.Yes)
                            {
                                for (int n = 0; n < 2150; n++)
                                {

                                    pbTiempo.PerformStep();

                                }

                                nodelito = "";
                                ImprimirDefinitivo();

                                SaveFileDialog guardar = new SaveFileDialog();
                                guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
                                string paginahtml_texto = Properties.Resources.plantilla.ToString();

                                if (dgvBuscar.Columns.Contains("DP"))
                                {
                                  string NombreDP;

                                    con.Open();
                                    cmd = new SqlCommand("select DP from InfoPenal where DP like '" + ActivarID + "'", con);
                                    cmd.ExecuteNonQuery();
                                    if (cmd.ExecuteScalar() == null)
                                    {
                                        NombreDP = "-";
                                    }
                                    else
                                    {
                                        NombreDP = cmd.ExecuteScalar().ToString();
                                    }
                                    con.Close();
                                    paginahtml_texto = paginahtml_texto.Replace("@DP",NombreDP); 
                                }
                                else
                                {
                                    paginahtml_texto = paginahtml_texto.Replace("@DP", "-");
                                }


                                if (dgvBuscar.Columns.Contains("AÑO"))
                                {
                                    string anual;

                                    con.Open();
                                    cmd = new SqlCommand("select AÑO from InfoPenal where DP like '" + ActivarID + "'", con);
                                    cmd.ExecuteNonQuery();
                                    if (cmd.ExecuteScalar() == null)
                                    {
                                        anual = "-";
                                    }
                                    else
                                    {
                                        anual = cmd.ExecuteScalar().ToString();
                                    }
                                    con.Close();

                                    paginahtml_texto = paginahtml_texto.Replace("@AÑO", anual);
                                }
                                else
                                {
                                    paginahtml_texto = paginahtml_texto.Replace("@AÑO", "-");
                                }
                                if (dgvBuscar.Columns.Contains("Defensor Proceso"))
                                {
                                    string DefP;

                                    con.Open();
                                    cmd = new SqlCommand("select DefensorProceso from InfoPenal where DP like '" + ActivarID + "'", con);
                                    cmd.ExecuteNonQuery();
                                    if (cmd.ExecuteScalar() == null)
                                    {
                                        DefP = "-";
                                    }
                                    else
                                    {
                                        DefP = cmd.ExecuteScalar().ToString();
                                    }
                                    con.Close();

                                    paginahtml_texto = paginahtml_texto.Replace("@DEFENSORP", DefP);
                                }
                                else
                                {
                                    paginahtml_texto = paginahtml_texto.Replace("@DEFENSORP", "-");
                                }
                                if (dgvBuscar.Columns.Contains("Defensor Caso"))
                                {
                                    string DefC;

                                    con.Open();
                                    cmd = new SqlCommand("select DefensorCaso from InfoPenal where DP like '" + ActivarID + "'", con);
                                    cmd.ExecuteNonQuery();
                                    if (cmd.ExecuteScalar() == null)
                                    {
                                        DefC = "-";
                                    }
                                    else
                                    {
                                        DefC = cmd.ExecuteScalar().ToString();
                                    }
                                    con.Close();

                                    paginahtml_texto = paginahtml_texto.Replace("@DEFENSORC", DefC);
                                }
                                else
                                {
                                    paginahtml_texto = paginahtml_texto.Replace("@DEFENSORC", "-");
                                }
                                if (dgvBuscar.Columns.Contains("TRIBUNAL"))
                                {
                                    string TriD;
                                    con.Open();
                                    cmd = new SqlCommand("select TRIBUNAL from InfoPenal where DP like '" + ActivarID + "'", con);
                                    cmd.ExecuteNonQuery();
                                    if (cmd.ExecuteScalar() == null)
                                    {
                                        TriD = "-";
                                    }
                                    else
                                    {
                                        TriD = cmd.ExecuteScalar().ToString();
                                    }
                                    con.Close();
                                    paginahtml_texto = paginahtml_texto.Replace("@TRIBUNAL", TriD);
                                }
                                else
                                {
                                    paginahtml_texto = paginahtml_texto.Replace("@TRIBUNAL", "-");
                                }
                                if (dgvBuscar.Columns.Contains("REFERENCIA"))
                                {
                                    string Ref;
                                    con.Open();
                                    cmd = new SqlCommand("select REFERENCIA from InfoPenal where DP like '" + ActivarID + "'", con);
                                    cmd.ExecuteNonQuery();
                                    if (cmd.ExecuteScalar() == null)
                                    {
                                        Ref = "-";
                                    }
                                    else
                                    {
                                        Ref = cmd.ExecuteScalar().ToString();
                                    }
                                    con.Close();

                                    paginahtml_texto = paginahtml_texto.Replace("@REFERENCIA", Ref);
                                }
                                else
                                {
                                    paginahtml_texto = paginahtml_texto.Replace("@REFERENCIA", "-");
                                }

                               
                                
                                 
                                
                               


                                paginahtml_texto = paginahtml_texto.Replace("@NODELITO", nodelito);




                                delito = string.Empty;
                                
                                delito += "<table>";
                                delito += "<tr><td colspan=\"3\" height=\"20\"></td></tr>";
                                delito += "<tr><td colspan=\"3\" height=\"20\" style=\"border-bottom: 1px solid black\" class=\"emphasized\" class=\"bolded\">LISTADO DE IMPUTADOS ASIGNADOS CON DELITOS Y/O FECHAS</td></tr>";
                                delito += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                delito += "</table>";




                                string completo = string.Empty;
                                string auxiliar = string.Empty;
                                //Cuenta el numero de imputados en el DP
                                int nimp = 0;
                                int rimp = 0;
                               
                                if (dgvBuscar.Columns.Contains("NOMBRE")==true && dgvBuscar.Columns.Contains("APELLIDO") == true)
                                {
                                  
                                
                                    for (int i = 0; i < dgvBuscar.RowCount - 1; i++)
                                    {

                                        //Numero de imputados en el DP
                                        //MessageBox.Show(dgvBuscar.Rows[i].Cells["Hecho Punible"].Value.ToString());
                                        completo = dgvBuscar.Rows[i].Cells["NOMBRE"].Value.ToString() + dgvBuscar.Rows[i].Cells["APELLIDO"].Value.ToString();
                                        if (completo != auxiliar)
                                        {
                                            nimp++;
                                            auxiliar = completo;
                                        }
                                    }

                                    //MessageBox.Show(nimp.ToString());
                                    completo = string.Empty;
                                    auxiliar = string.Empty;
                                    NombreID = string.Empty;
                                    ApellidoID = string.Empty;
                                    int numeral = 0;
                                    int cont = 0;

                                  
                                    for (int j = 0; j < dgvBuscar.RowCount-1; j++)
                                    {
                                      
                                            completo = dgvBuscar.Rows[j].Cells["NOMBRE"].Value.ToString() + dgvBuscar.Rows[j].Cells["APELLIDO"].Value.ToString();
                                        

          
                                        numeral = j + 1;
                                        if (completo != auxiliar)
                                        {
                                            NombreID = dgvBuscar.Rows[j].Cells["NOMBRE"].Value.ToString();
                                            ApellidoID = dgvBuscar.Rows[j].Cells["APELLIDO"].Value.ToString();
                                            numeral = numeral - cont;
                                            delito += "<table>";
                                            delito += "<tr><td colspan=\"3\" height=\"20\"></td></tr>";
                                            delito += "<tr><td colspan=\"3\" height=\"20\" style=\"border-bottom: 1px solid black\" class=\"bolded\">Información del imputado #" + numeral + "</td></tr>";
                                            delito += " <tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                            delito += "</table>";
                                            delito += "<table>";
                                            delito += "<tr>";
                                            delito += "<td colspan=\"1\" style=\"width:13%\">NOMBRE: </td>";
                                            delito += "<td colspan=\"1\" style=\"width:37%; border-bottom: 1px solid black\">" + dgvBuscar.Rows[j].Cells["NOMBRE"].Value.ToString() + "</td>";
                                            delito += "<td colspan=\"1\" style=\"width:14%\">APELLIDO:</td>";
                                            delito += "<td colspan=\"1\" style=\"width:36%; border-bottom: 1px solid black\">" + dgvBuscar.Rows[j].Cells["APELLIDO"].Value.ToString() + "</td>";
                                            delito += "</tr>";
                                            delito += "<tr><td colspan=\"3\" height=\"15\"></td></tr>";
                                            delito += "<tr>";
                                            delito += "<td colspan=\"1\" style=\"width:10%\">GENERO:</td>";
                                            delito += "<td colspan=\"1\" style=\"width:40%; border-bottom: 1px solid black\">" + dgvBuscar.Rows[j].Cells["GENERO"].Value.ToString() + "</td>";
                                            delito += " </tr>";
                                            delito += " <tr><td colspan=\"3\" height=\"15\"></td></tr>";
                                            delito += "</table>";
                                            delito += "<table class=\"border\" width=\"100%\">";
                                            delito += "<tr>";
                                            delito += "<td align=\"center\" width=\"39.5%\" class=\"bolded\">Delitos y victimas</td>";
                                            delito += "<td align=\"center\" width=\"60%\" class=\"bolded\">Fechas y audiencias</td>";
                                            delito += "</tr>";
                                            delito += "</table>";
                                            delito += "<table class=\"border\" width=\"100%\">";
                                            delito += "<tr>";
                                            delito += "<td align=\"center\" width=\"20.5%\" class=\"bolded\">Hecho punible</td>";
                                            delito += "<td align=\"center\" width=\"20.5%\" class=\"bolded\">Información de la victima</td>";
                                            delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">Tipo de audiencia</td>";
                                            delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">Fecha</td>";
                                            delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">Hora</td>";
                                            delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">Información de la audiencia</td>";
                                            delito += "</tr>";
                                            delito += "</table>";
                                            delito += "";
                                            delito += "<table class=\"border\" width=\"100%\">";
                                            delito += "<tr>";
                                            if (dgvBuscar.Columns.Contains("Hecho Punible"))
                                            {


                                                if (dgvBuscar.Rows[j].Cells["Hecho Punible"].Value == null)
                                                {
                                                    delito += "<td align=\"center\" width=\"20.5%\">" + "-" + "</td>";
                                                }
                                                else
                                                {
                                                    delito += "<td align=\"center\" width=\"20.5%\">" + dgvBuscar.Rows[j].Cells["Hecho Punible"].Value.ToString() + "</td>";
                                                }
                                                con.Close();


                                            }
                                            else
                                            {
                                                string HayAlgoF;
                                                //string HayAlgoD;
                                                con.Open();
                                                cmd = new SqlCommand("select Fecha from FechasAud where Nombre like '" + NombreID + "' and Apellido like '" + ApellidoID + "' order by Nombre", con);
                                                cmd.ExecuteNonQuery();
                                                if (cmd.ExecuteScalar() == null)
                                                {
                                                    HayAlgoF = "Es nulo";
                                                   
                                                }
                                                else
                                                {
                                                    HayAlgoF = "No es nulo";
                                                   
                                                }
                                                cmd = new SqlCommand("select HechoPunible from DeliVictimas where Nombre like '" + NombreID + "' and Apellido like '" + ApellidoID + "' order by Nombre", con);
                                                using (SqlDataReader reader = cmd.ExecuteReader())
                                                {

                                                    if (reader.Read() == false)
                                                    {
                                                        reader.Close();
                                                        if (HayAlgoF == "No es nulo")
                                                        {
                                                            cmd = new SqlCommand("select Fecha, Hora, TipoAudiencia,InfoAuEspecial from FechasAud where Nombre like '" + NombreID + "' and Apellido like '" + ApellidoID + "' order by Nombre", con);
                                                            using (SqlDataReader reader2 = cmd.ExecuteReader())
                                                            {
                                                                delito += "</tr>";
                                                                while (reader2.Read())
                                                                {
                                                                    //MessageBox.Show(reader2[3].ToString());
                                                                    YaEstuvo = "YA";
                                                                    delito += "<tr>";
                                                                    delito += "<td align=\"center\" width=\"20.5%\" class=\"bolded\">" + "-" + "</td>";
                                                                    delito += "<td align=\"center\" width=\"20.5%\" class=\"bolded\">" + "-" + "</td>";
                                                                    delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">" + reader2[2].ToString() + "</td>";
                                                                    delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">" + reader2[0].ToString().Substring(0, 10) + "</td>";
                                                                    delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">" + reader2[1].ToString() + "</td>";
                                                                    delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">" + reader2[3].ToString() + "</td>";
                                                                    delito += "</tr>";
                                                                    
                                                                }
                                                                delito += "<tr>";
                                                            }
                                                        }
                                                        else
                                                        {
                                                            delito += "<td align=\"center\" width=\"20.5%\">" + "-" + "</td>";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        
                                                        while (reader.Read())
                                                        {
                                                            MessageBox.Show(reader[0].ToString());
                                                        }
                                                    }
                                                }

                                                con.Close();
                                                
                                            }


                                            if (dgvBuscar.Columns.Contains("Victima"))
                                            {
                                                if (dgvBuscar.Rows[j].Cells["Victima"].Value == null)
                                                {
                                                    delito += "<td align=\"center\" width=\"20.5%\">" + "-" + "</td>";
                                                }
                                                else
                                                {
                                                    delito += "<td align=\"center\" width=\"20.5%\">" + dgvBuscar.Rows[j].Cells["Victima"].Value.ToString() + "</td>";
                                                }
                                                con.Close();


                                            }
                                            else
                                            {    //aqui2
                                                //Caso donde la columana Hecho punible no exista
                                                if (YaEstuvo != "YA")
                                                {
                                                    delito += "<td align=\"center\" width=\"20.5%\">" + "-" + "</td>";
                                                }
                                            }

                                            if (dgvBuscar.Columns.Contains("TIPO AUDIENCIA"))
                                            {
                                                if (dgvBuscar.Rows[j].Cells["TIPO AUDIENCIA"].Value == null)
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                                }
                                                else
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + dgvBuscar.Rows[j].Cells["TIPO AUDIENCIA"].Value.ToString() + "</td>";
                                                }
                                                con.Close();


                                            }
                                            else
                                            {
                                                //aqui3
                                                if(YaEstuvo != "YA")
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                                }
                                                
                                            }

                                            if (dgvBuscar.Columns.Contains("FECHA AUDIENCIA"))
                                            {
                                                if (dgvBuscar.Rows[j].Cells["FECHA AUDIENCIA"].Value == null)
                                                {
                                                    //MessageBox.Show("Si existe la columna pero envia null");
                                                    delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                                }
                                                else
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + dgvBuscar.Rows[j].Cells["FECHA AUDIENCIA"].Value.ToString().Substring(0,10) + "</td>";
                                                }
                                                con.Close();


                                            }
                                            else
                                            {
                                                if (YaEstuvo != "YA")
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                                }
                                                //Caso en donde la columna fecha no exista pero haya datos en su tabla pero la informacion ya se lleno arriba
                                            }

                                            if (dgvBuscar.Columns.Contains("HORA"))
                                            {
                                                if (dgvBuscar.Rows[j].Cells["HORA"].Value == null)
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                                }
                                                else
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + dgvBuscar.Rows[j].Cells["HORA"].Value.ToString() + "</td>";
                                                }
                                                con.Close();


                                            }
                                            else
                                            {
                                                //aqui5
                                                if (YaEstuvo!="YA")
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                                }
                                                
                                            }
                                            if (dgvBuscar.Columns.Contains("Informacion Audiencia"))
                                            {
                                                if (dgvBuscar.Rows[j].Cells["Informacion Audiencia"].Value == null)
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                                }
                                                else
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + dgvBuscar.Rows[j].Cells["Informacion Audiencia"].Value.ToString() + "</td>";
                                                }
                                                con.Close();


                                            }
                                            else
                                            {
                                                //aqui5
                                                if (YaEstuvo != "YA")
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                                }
                                            }
                                            delito += "</tr>";
                                            delito += "</table>";
                                            auxiliar = completo;

                                        }
                                        else
                                        {
                                            cont++;
                                            delito += "<table class=\"border\" width=\"100%\">";
                                            delito += "<tr>";

                                            if (dgvBuscar.Columns.Contains("Hecho Punible"))
                                            {


                                                if (dgvBuscar.Rows[j].Cells["Hecho Punible"].Value == null)
                                                {
                                                    delito += "<td align=\"center\" width=\"20.5%\">" + "-" + "</td>";
                                                }
                                                else
                                                {
                                                    delito += "<td align=\"center\" width=\"20.5%\">" + dgvBuscar.Rows[j].Cells["Hecho Punible"].Value.ToString() + "</td>";
                                                }
                                                con.Close();


                                            }
                                            else
                                            {
                                                delito += "<td align=\"center\" width=\"20.5%\">" + "-" + "</td>";
                                            }


                                            if (dgvBuscar.Columns.Contains("Victima"))
                                            {
                                                if (dgvBuscar.Rows[j].Cells["Victima"].Value == null)
                                                {
                                                    delito += "<td align=\"center\" width=\"20.5%\">" + "-" + "</td>";
                                                }
                                                else
                                                {
                                                    delito += "<td align=\"center\" width=\"20.5%\">" + dgvBuscar.Rows[j].Cells["Victima"].Value.ToString() + "</td>";
                                                }
                                                con.Close();


                                            }
                                            else
                                            {
                                                delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                            }

                                            if (dgvBuscar.Columns.Contains("TIPO AUDIENCIA"))
                                            {
                                                if (dgvBuscar.Rows[j].Cells["TIPO AUDIENCIA"].Value == null)
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                                }
                                                else
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + dgvBuscar.Rows[j].Cells["TIPO AUDIENCIA"].Value.ToString() + "</td>";
                                                }
                                                con.Close();


                                            }
                                            else
                                            {
                                                delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                            }

                                            if (dgvBuscar.Columns.Contains("FECHA AUDIENCIA"))
                                            {
                                                if (dgvBuscar.Rows[j].Cells["FECHA AUDIENCIA"].Value == null)
                                                {
                                                  
                                                    delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                                }
                                                else
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + dgvBuscar.Rows[j].Cells["FECHA AUDIENCIA"].Value.ToString().Substring(0,10) + "</td>";
                                                }
                                                con.Close();


                                            }
                                            else
                                            {
                                                delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                            }

                                            if (dgvBuscar.Columns.Contains("HORA"))
                                            {
                                                if (dgvBuscar.Rows[j].Cells["HORA"].Value == null)
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                                }
                                                else
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + dgvBuscar.Rows[j].Cells["HORA"].Value.ToString() + "</td>";
                                                }
                                                con.Close();


                                            }
                                            else
                                            {
                                                delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                            }

                                            if (dgvBuscar.Columns.Contains("Informacion Audiencia"))
                                            {
                                                if (dgvBuscar.Rows[j].Cells["Informacion Audiencia"].Value == null)
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                                }
                                                else
                                                {
                                                    delito += "<td align=\"center\" width=\"15%\">" + dgvBuscar.Rows[j].Cells["Informacion Audiencia"].Value.ToString() + "</td>";
                                                }
                                                con.Close();


                                            }
                                            else
                                            {
                                                delito += "<td align=\"center\" width=\"15%\">" + "-" + "</td>";
                                            }

                                            delito += "</tr>";
                                            delito += "</table>";
                                        }

                                         
                                    }

                                    if (nimp == 0)
                                    {
                                        delito = "";

                                    }
                                    if (delito == "")
                                    {
                                        delito += "<table>";
                                        delito += "<tr><td colspan=\"3\" height=\"20\"></td></tr>";
                                        delito += "<tr><td colspan=\"3\" height=\"20\" style=\"border-bottom: 1px solid black\" class=\"emphasized\" class=\"bolded\">LISTADO DE IMPUTADOS SIN ASIGNAR CON DELITOS Y/O FECHAS</td></tr>";
                                        delito += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                        delito += "</table>";
                                        delito += "<table>";
                                        delito += "<tr><td colspan=\"3\" height=\"20\"></td></tr>";
                                        delito += "<tr><td colspan=\"3\" height=\"20\" style=\"border-bottom: 1px solid black\" class=\"bolded\">Información del imputado #" + "-" + "</td></tr>";
                                        delito += " <tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                        delito += "</table>";
                                        delito += "<table>";
                                        delito += "<tr>";
                                        delito += "<td colspan=\"1\" style=\"width:13%\">NOMBRE: </td>";
                                        delito += "<td colspan=\"1\" style=\"width:37%; border-bottom: 1px solid black\">" + "-" + "</td>";
                                        delito += "<td colspan=\"1\" style=\"width:14%\">APELLIDO:</td>";
                                        delito += "<td colspan=\"1\" style=\"width:36%; border-bottom: 1px solid black\">" + "-" + "</td>";
                                        delito += "</tr>";
                                        delito += "<tr><td colspan=\"3\" height=\"15\"></td></tr>";
                                        delito += "<tr>";
                                        delito += "<td colspan=\"1\" style=\"width:10%\">GENERO:</td>";
                                        delito += "<td colspan=\"1\" style=\"width:40%; border-bottom: 1px solid black\">" + "-" + "</td>";
                                        delito += " </tr>";
                                        delito += " <tr><td colspan=\"3\" height=\"15\"></td></tr>";
                                        delito += "</table>";
                                        delito += "<table class=\"border\" width=\"100%\">";
                                        delito += "<tr>";
                                        delito += "<td align=\"center\" width=\"39.5%\" class=\"bolded\">Delitos y victimas</td>";
                                        delito += "<td align=\"center\" width=\"60%\" class=\"bolded\">Fechas y audiencias</td>";
                                        delito += "</tr>";
                                        delito += "</table>";
                                        delito += "<table class=\"border\" width=\"100%\">";
                                        delito += "<tr>";
                                        delito += "<td align=\"center\" width=\"20.5%\" class=\"bolded\">Hecho punible</td>";
                                        delito += "<td align=\"center\" width=\"20.5%\" class=\"bolded\">Información de la victima</td>";
                                        delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">Tipo de audiencia</td>";
                                        delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">Fecha</td>";
                                        delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">Hora</td>";
                                        delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">Información Audiencia</td>";
                                        delito += "</tr>";
                                        delito += "</table>";
                                        delito += "<table class=\"border\" width=\"100%\">";
                                        delito += "<tr>";
                                        delito += "<td align=\"center\" width=\"20.5%\" class=\"bolded\">-</td>";
                                        delito += "<td align=\"center\" width=\"20.5%\" class=\"bolded\">-</td>";
                                        delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">-</td>";
                                        delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">-</td>";
                                        delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">-</td>";
                                        delito += "<td align=\"center\" width=\"15%\" class=\"bolded\">-</td>";
                                        delito += "</tr>";
                                        delito += "</table>";

                                        paginahtml_texto = paginahtml_texto.Replace("@DELITO", delito);

                                    }
                                    else
                                    {
                                        paginahtml_texto = paginahtml_texto.Replace("@DELITO", delito);
                                    }
                                }



                                //string TeoFi = string.Empty;
                                //string TeoDe = string.Empty;
                                //string InfoEx = string.Empty;
                                //string TeoriaFiscalia = string.Empty;
                                //string TeoriaDefensa = string.Empty;
                                //string Cometario = string.Empty;

                                


                                //con.Open();
                                //cmd = new SqlCommand("select TeoFiscalia from TeoCasoComent where DP like '" + txtDpLlenar.Text + "'", con);
                                //cmd.ExecuteNonQuery();
                                //if (cmd.ExecuteScalar() == null)
                                //{
                                //    TeoriaFiscalia += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //}
                                //else
                                //{
                                //    TeoFi = cmd.ExecuteScalar().ToString();
                                //}

                                //cmd = new SqlCommand("select TeoDefensor from TeoCasoComent where DP like '" + txtDpLlenar.Text + "'", con);
                                //cmd.ExecuteNonQuery();
                                //if (cmd.ExecuteScalar() == null)
                                //{
                                //    TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //}
                                //else
                                //{
                                //    TeoDe = cmd.ExecuteScalar().ToString();
                                //}

                                //cmd = new SqlCommand("select InfoExtra from TeoCasoComent where DP like '" + txtDpLlenar.Text + "'", con);
                                //cmd.ExecuteNonQuery();
                                //if (cmd.ExecuteScalar() == null)
                                //{
                                //    Cometario += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //}
                                //else
                                //{
                                //    InfoEx = cmd.ExecuteScalar().ToString();
                                //}

                                //con.Close();

                              
                                //int partida = -1;
                                //int terminal = 0;
                                //int longitudLinea = 0;
                                //string Cadena = string.Empty;
                                //string ULinea = string.Empty;
                                //string SCadena = string.Empty;
                                //int contE = 0;
                                //TeoriaFiscalia += " ";

                                //for (int t = 0; t < TeoFi.Length; t++)
                                //{
                                //    if(TeoFi[t] == 10)
                                //    {
                                //        contE++;
                                //    }

                                //}
                             
                                //if (contE > 0)
                                //{
                                    
                                //    for (int m = 0; m < TeoFi.Length; m++)
                                //    {

                                //        if (TeoFi[m] == 10)
                                //        {

                                //            partida = partida + 1;
                                //            terminal = m - 1;
                                //            longitudLinea = terminal - partida;

                                //            if (partida >= 0)
                                //            {
                                //                Cadena = TeoFi.Substring(partida, longitudLinea);
                                //                if (Cadena == "")
                                //                {
                                //                    TeoriaFiscalia += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //                    TeoriaFiscalia += "</table>";
                                //                    TeoriaFiscalia += "<div id=\"general3\"></div>";
                                //                    TeoriaFiscalia += "<table>";
                                //                    TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                }
                                //                else
                                //                {
                                //                    // MessageBox.Show(Cadena.Length.ToString());
                                //                    if (Cadena.Length > 114)
                                //                    {
                                //                        TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                        TeoriaFiscalia += "</table>";
                                //                        TeoriaFiscalia += "<div id=\"general3\">" + Cadena + " </div>";
                                //                        TeoriaFiscalia += "<table>";
                                //                        TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                    }
                                //                    else
                                //                    {
                                //                        TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                        TeoriaFiscalia += "</table>";
                                //                        TeoriaFiscalia += "<div id=\"general2\">" + Cadena + " </div>";
                                //                        TeoriaFiscalia += "<table>";
                                //                        TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                    }
                                //                }
                                //            }
                                //            partida = m;
                                //        }
                                //        //else
                                //        //{
                                //        //    TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //        //}
                                //        if (m == TeoFi.Length - 1)
                                //        {
                                //            if (partida >= 0)
                                //            {
                                //                ULinea = TeoFi.Substring(partida, TeoFi.Length - partida);
                                //                if (ULinea.Length > 114)
                                //                {
                                //                    TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                    TeoriaFiscalia += "</table>";
                                //                    TeoriaFiscalia += "<div id=\"general3\">" + ULinea + " </div>";
                                //                    TeoriaFiscalia += "<table>";
                                //                    TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                }
                                //                else
                                //                {
                                //                    TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                    TeoriaFiscalia += "</table>";
                                //                    TeoriaFiscalia += "<div id=\"general3\">" + ULinea + " </div>";
                                //                    TeoriaFiscalia += "<table>";
                                //                    TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                }
                                //            }
                                //        }
                                //    }
                                //}
                                //else
                                //{
                                //    if (TeoFi.Length > 0)
                                //    {
                                //        TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //        TeoriaFiscalia += "</table>";
                                //        TeoriaFiscalia += "<div id=\"general1\">" + TeoFi + " </div>";
                                //        TeoriaFiscalia += "<table>";
                                //        TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //    }
                                //    else
                                //    {
                                //        TeoriaFiscalia += "<tr><td aling =\"left\" ></td></tr>";
                                //    }
                                  
                                //}


                                //partida = -1;
                                //terminal = 0;
                                //longitudLinea = 0;
                                //Cadena = " ";
                                //ULinea = " ";
                                //SCadena = " ";
                                //contE = 0;
                                //TeoriaDefensa += " ";

                                //for (int t = 0; t < TeoDe.Length; t++)
                                //{
                                //    if (TeoDe[t] == 10)
                                //    {
                                //        contE++;
                                //    }

                                //}

                                //if (contE > 0)
                                //{

                                //    for (int m = 0; m < TeoDe.Length; m++)
                                //    {

                                //        if (TeoDe[m] == 10)
                                //        {

                                //            partida = partida + 1;
                                //            terminal = m - 1;
                                //            longitudLinea = terminal - partida;

                                //            if (partida >= 0)
                                //            {
                                //                Cadena = TeoDe.Substring(partida, longitudLinea);
                                //                if (Cadena == "")
                                //                {
                                //                    TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //                    TeoriaDefensa += "</table>";
                                //                    TeoriaDefensa += "<div id=\"general3\"></div>";
                                //                    TeoriaDefensa += "<table>";
                                //                    TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //                }
                                //                else
                                //                {
                                //                    // MessageBox.Show(Cadena.Length.ToString());
                                //                    if (Cadena.Length > 114)
                                //                    {
                                //                        TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //                        TeoriaDefensa += "</table>";
                                //                        TeoriaDefensa += "<div id=\"general3\">" + Cadena + " </div>";
                                //                        TeoriaDefensa += "<table>";
                                //                        TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //                    }
                                //                    else
                                //                    {
                                //                        TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //                        TeoriaDefensa += "</table>";
                                //                        TeoriaDefensa += "<div id=\"general2\">" + Cadena + " </div>";
                                //                        TeoriaDefensa += "<table>";
                                //                        TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //                    }
                                //                }
                                //            }
                                //            partida = m;
                                //        }
                                //        //else
                                //        //{
                                //        //    TeoriaDefensa += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //        //}
                                //        if (m == TeoDe.Length - 1)
                                //        {
                                //            if (partida >= 0)
                                //            {
                                //                ULinea = TeoDe.Substring(partida, TeoDe.Length - partida);
                                //                if (ULinea.Length > 114)
                                //                {
                                //                    TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //                    TeoriaDefensa += "</table>";
                                //                    TeoriaDefensa += "<div id=\"general3\">" + ULinea + " </div>";
                                //                    TeoriaDefensa += "<table>";
                                //                    TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //                }
                                //                else
                                //                {
                                //                    TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //                    TeoriaDefensa += "</table>";
                                //                    TeoriaDefensa += "<div id=\"general3\">" + ULinea + " </div>";
                                //                    TeoriaDefensa += "<table>";
                                //                    TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //                }
                                //            }
                                //        }
                                //    }
                                //}
                                //else
                                //{
                                //    if (TeoDe.Length > 0)
                                //    {
                                       
                                //        TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //        TeoriaDefensa += "</table>";
                                //        TeoriaDefensa += "<div id=\"general1\">" + TeoDe + " </div>";
                                //        TeoriaDefensa += "<table>";
                                //        TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //    }
                                //    else
                                //    {
                                //        TeoriaFiscalia += "<tr><td aling =\"left\" ></td></tr>";
                                //    }
                                //}


                                //Cometario += " ";
                                //partida = -1;
                                //terminal = 0;
                                //longitudLinea = 0;
                                //Cadena = " ";
                                //ULinea = " ";
                                //SCadena = " ";
                                //contE = 0;

                                //for (int t = 0; t < InfoEx.Length; t++)
                                //{
                                //    if (InfoEx[t] == 10)
                                //    {
                                //        contE++;
                                //    }

                                //}

                                //if (contE > 0)
                                //{

                                //    for (int m = 0; m < InfoEx.Length; m++)
                                //    {

                                //        if (InfoEx[m] == 10)
                                //        {

                                //            partida = partida + 1;
                                //            terminal = m - 1;
                                //            longitudLinea = terminal - partida;

                                //            if (partida >= 0)
                                //            {
                                //                Cadena = InfoEx.Substring(partida, longitudLinea);
                                //                if (Cadena == "")
                                //                {
                                //                    Cometario += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                //                    Cometario += "</table>";
                                //                    Cometario += "<div id=\"general3\"></div>";
                                //                    Cometario += "<table>";
                                //                    Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                }
                                //                else
                                //                {
                                //                    // MessageBox.Show(Cadena.Length.ToString());
                                //                    if (Cadena.Length > 114)
                                //                    {
                                //                        Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                        Cometario += "</table>";
                                //                        Cometario += "<div id=\"general3\">" + Cadena + " </div>";
                                //                        Cometario += "<table>";
                                //                        Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                    }
                                //                    else
                                //                    {
                                //                        Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                        Cometario += "</table>";
                                //                        Cometario += "<div id=\"general2\">" + Cadena + " </div>";
                                //                        Cometario += "<table>";
                                //                        Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                    }
                                //                }
                                //            }
                                //            partida = m;
                                //        }
                                //        //else
                                //        //{
                                //        //    Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //        //}
                                //        if (m == InfoEx.Length - 1)
                                //        {
                                //            if (partida >= 0)
                                //            {
                                //                ULinea = InfoEx.Substring(partida, InfoEx.Length - partida);
                                //                if (ULinea.Length > 114)
                                //                {
                                //                    Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                    Cometario += "</table>";
                                //                    Cometario += "<div id=\"general3\">" + ULinea + " </div>";
                                //                    Cometario += "<table>";
                                //                    Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                }
                                //                else
                                //                {
                                //                    Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                    Cometario += "</table>";
                                //                    Cometario += "<div id=\"general3\">" + ULinea + " </div>";
                                //                    Cometario += "<table>";
                                //                    Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //                }
                                //            }
                                //        }
                                //    }
                                //}
                                //else
                                //{
                                //    if (InfoEx.Length > 0)
                                //    {
                                //        Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //        Cometario += "</table>";
                                //        Cometario += "<div id=\"general1\">" + InfoEx + " </div>";
                                //        Cometario += "<table>";
                                //        Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                //    }
                                //    else
                                //    {
                                //        Cometario += "<tr><td aling =\"left\" >-</td></tr>";
                                //    }
                                //}




                                //paginahtml_texto = paginahtml_texto.Replace("@TEORIAF",  TeoriaFiscalia);
                                //paginahtml_texto = paginahtml_texto.Replace("@TEORIAD", TeoriaDefensa);
                                //paginahtml_texto = paginahtml_texto.Replace("@COMENTARIO", Cometario);


                                using (FileStream stream = new FileStream(@"C:\ProcuAbogadosPDF\" + Combinado + ".pdf", FileMode.Create))
                                {
                                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();
                                    pdfDoc.Add(new Phrase(""));

                                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo_pgr, System.Drawing.Imaging.ImageFormat.Png);
                                    img.ScaleToFit(80, 60);
                                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                                    pdfDoc.Add(img);

                                    using (StringReader sr = new StringReader(paginahtml_texto))
                                    {

                                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);


                                    }


                                    pdfDoc.Close();
                                    stream.Close();
                                    MessageBox.Show("Se guardo correctamente!!");
                                    pbTiempo.Value = 0;
                                    txtDPpdf.Text = "";
                                    txtDpLlenar.Text = "";
                                    if(dgvBuscar.Rows.Count==1)
                                    {
                                        displayData();
                                    }



                                    con.Open();
                                    cmd = new SqlCommand("insert into InfoPenalImpresiones values(@DP)", con);
                                    //cmd.Parameters.AddWithValue("@IdImputados", IdUbicacion);
                                    cmd.Parameters.AddWithValue("@DP", Combinado);
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                }


                            }
                            else if (mensaje == DialogResult.No)
                            {
                                //No
                            }

                        }
                    }
                }
        }
            catch (Exception Ex)
            {
               
                MessageBox.Show(Ex.Message);
            }


}
        private void ImprimirDefinitivo()
        {

            try
            {

                




                SqlDataAdapter adptUNO = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',IMP.TipoGenero 'GENERO',INFO.TRIBUNAL 'TRIBUNAL',INFO.REFERENCIA 'REFERENCIA',INFO.DefensorCaso 'Defensor Caso',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA',FA.Hora 'HORA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where INFO.DP like'" + ActivarID + "%'", con);
                DataSet dsUNO = new DataSet();
                adptUNO.Fill(dsUNO);
                int iUNO = dsUNO.Tables[0].Rows.Count;


             
                if(dgvBuscar.Columns.Contains("NOMBRE")&& dgvBuscar.Columns.Contains("APELLIDO") && dgvBuscar.Columns.Contains("Hecho Punible") ==false && dgvBuscar.Columns.Contains("Victima") == false)
                {
                 
                  
                 
                    txtDPNombre.Text = "";
                    txtDPApellido.Text = "";
                    con.Open();
                    adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',IMP.TipoGenero 'GENERO',INFO.TRIBUNAL 'TRIBUNAL',INFO.REFERENCIA 'REFERENCIA',INFO.DefensorCaso 'Defensor Caso' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP where INFO.DP like'" + ActivarID + "%' order by IMP.NOMBRE", con);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = "DP='" + ActivarID + "'";
                    con.Close();
                    dgvBuscar.DataSource = dv;
                }
                else if (dgvBuscar.Columns.Contains("NOMBRE") && dgvBuscar.Columns.Contains("APELLIDO") && dgvBuscar.Columns.Contains("Hecho Punible") == true && dgvBuscar.Columns.Contains("Victima") ==true && dgvBuscar.Columns.Contains("FECHA AUDIENCIA")==false)
                {
                   
                    string NombreCompletoDeli = string.Empty;
                    int nimpIMP=0;
                    int nimpDeli=0;
                    int nimpFech=0;

                    con.Open();
                    cmd = new SqlCommand("SELECT DISTINCT Nombre FROM FechasAud where DP like'" + ActivarID + "%' order by Nombre", con);
                    using (SqlDataReader reader2 = cmd.ExecuteReader())
                    {


                        while (reader2.Read())
                        {
                            nimpFech++;

                        }
                    }
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("SELECT DISTINCT NOMBRE FROM IngresaIMP where DP like'" + ActivarID + "%' order by NOMBRE", con);
                    using (SqlDataReader reader2 = cmd.ExecuteReader())
                    {


                        while (reader2.Read())
                        {
                            nimpIMP++;  

                        }
                    }
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("SELECT DISTINCT NOMBRE FROM DeliVictimas where DP like'" + ActivarID + "%' order by NOMBRE", con);
                    using (SqlDataReader reader2 = cmd.ExecuteReader())
                    {


                        while (reader2.Read())
                        {

                            nimpDeli++;
                        }
                    }
                    con.Close();

                    //MessageBox.Show(nimpIMP.ToString());
                    //MessageBox.Show(nimpDeli.ToString());
                    //MessageBox.Show(nimpFech.ToString());



                    if (nimpIMP > nimpDeli)
                    {
                        con.Open();
                        cmd = new SqlCommand("SELECT IMP.DP, IMP.NOMBRE, IMP.APELLIDO from IngresaIMP IMP LEFT OUTER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados where DV.IdImputados is NULL and IMP.DP like '" + ActivarID + "' order by IMP.NOMBRE", con);
                        using (SqlDataReader reader2 = cmd.ExecuteReader())
                        {
                            nodelito += "<table>";
                            nodelito += "<tr><td colspan=\"3\" height=\"20\"></td></tr>";
                            nodelito += "<tr><td colspan=\"3\" height=\"20\" style=\"border-bottom: 1px solid black\" class=\"emphasized\" class=\"bolded\">LISTADO DE IMPUTADOS SIN ASIGNAR DELITOS Y/O FECHAS</td></tr>";
                            nodelito += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                            while (reader2.Read())
                            {

                                NombreCompletoDeli = reader2[1].ToString() +" "+ reader2[2].ToString();
                                nodelito += "<tr><td colspan=\"3\" height=\"9\">- " + NombreCompletoDeli + "</td></tr>";
                            }
                            nodelito += " </table>";
                        }
                        con.Close();
                    }

                    
                
                    txtDPNombre.Text = "";
                    txtDPApellido.Text = "";
                    con.Open();
                    adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',IMP.TipoGenero 'GENERO',INFO.TRIBUNAL 'TRIBUNAL',INFO.REFERENCIA 'REFERENCIA',INFO.DefensorCaso 'Defensor Caso', DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados  where INFO.DP like'" + ActivarID + "%' order by IMP.NOMBRE", con);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = "DP='" + ActivarID + "'";
                    con.Close();
                    dgvBuscar.DataSource = dv;
                }

                else 
                {
                   
                   
                    txtDPNombre.Text = "";
                    txtDPApellido.Text = "";
                    
                    nFechaF = 0;
                    nFechaV = 0;
                    nFechaFilas=0;

                    con.Open();
                    cmd = new SqlCommand("SELECT DP,Fecha,Nombre FROM FechasAud where DP like'" + ActivarID + "%' order by Nombre", con);
                    using (SqlDataReader reader2 = cmd.ExecuteReader())
                    {


                        while (reader2.Read())
                        {
                            nFechaFilas++; 

                        }
                    }
                    con.Close();




                    con.Open();
                    cmd = new SqlCommand("SELECT DISTINCT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',IMP.TipoGenero 'GENERO',INFO.TRIBUNAL 'TRIBUNAL',INFO.REFERENCIA 'REFERENCIA',INFO.DefensorCaso 'Defensor Caso', DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA',FA.Hora 'HORA', FA.TipoAudiencia 'TIPO AUDIENCIA', FA.InfoAuEspecial 'Informacion audiencia' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where INFO.DP like'" + ActivarID + "%' order by IMP.NOMBRE", con);

                    using (SqlDataReader reader2 = cmd.ExecuteReader())
                    {


                        while (reader2.Read())
                        {

                            nFechaV++;
                        }
                    }
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("SELECT  INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',IMP.TipoGenero 'GENERO',INFO.TRIBUNAL 'TRIBUNAL',INFO.REFERENCIA 'REFERENCIA',INFO.DefensorCaso 'Defensor Caso', DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA',FA.Hora 'HORA', FA.TipoAudiencia 'TIPO AUDIENCIA', FA.InfoAuEspecial 'Informacion audiencia' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON DV.DP = FA.DP where INFO.DP like'" + ActivarID + "%' order by IMP.NOMBRE", con);

                    using (SqlDataReader reader2 = cmd.ExecuteReader())
                    {


                        while (reader2.Read())
                        {

                            nFechaF++;
                        }
                    }
                    con.Close();

                

                    con.Open();
                    if(nFechaV>=nFechaFilas)
                    {
                        adpt = new SqlDataAdapter("SELECT DISTINCT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',IMP.TipoGenero 'GENERO',INFO.TRIBUNAL 'TRIBUNAL',INFO.REFERENCIA 'REFERENCIA',INFO.DefensorCaso 'Defensor Caso', DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA',FA.Hora 'HORA', FA.TipoAudiencia 'TIPO AUDIENCIA', FA.InfoAuEspecial 'Informacion audiencia' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where INFO.DP like'" + ActivarID + "%' order by IMP.NOMBRE", con);

                    }
                    else
                    {
                        adpt = new SqlDataAdapter("SELECT DISTINCT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',IMP.TipoGenero 'GENERO',INFO.TRIBUNAL 'TRIBUNAL',INFO.REFERENCIA 'REFERENCIA',INFO.DefensorCaso 'Defensor Caso', DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA',FA.Hora 'HORA', FA.TipoAudiencia 'TIPO AUDIENCIA', FA.InfoAuEspecial 'Informacion audiencia' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON DV.DP = FA.DP where INFO.DP like'" + ActivarID + "%' order by IMP.NOMBRE", con);
                    }

                    dt = new DataTable();
                    adpt.Fill(dt);
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = "DP='" + ActivarID + "'";
                    con.Close();
                    dgvBuscar.DataSource = dv;
                   
                }

                
  
                
               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void PanelBuscar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtDPNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtDPBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtDPApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.PaleVioletRed, 2);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 62, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }
    }
}
