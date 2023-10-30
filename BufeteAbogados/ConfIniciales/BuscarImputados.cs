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

<<<<<<< HEAD
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Security.Cryptography;

=======
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
namespace ConfIniciales
{
    public partial class BuscarImputados : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\BaseProcuraduria\BaseProcuraduria.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds = new DataSet();
        SqlDataReader lector;
        string DPdatagrid;
<<<<<<< HEAD
        int IdUbicacion;
=======

>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994

        private Form currentChilForm; //Campo para almacenar el formulario hijo actual

        public BuscarImputados()
        {
            InitializeComponent();
<<<<<<< HEAD
            dgvBuscar.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12, FontStyle.Bold);
=======
            dgvBuscar.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
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
            adpt = new SqlDataAdapter("select *from InfoPenal", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvBuscar.DataSource = dt;
            con.Close();

        }
        private void displayDataELIMINAR()
        {
            con.Open();
            adpt = new SqlDataAdapter("select *from InfoPenal", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvBuscar.DataSource = dt;
            con.Close();

        }

        private void BusquedaDinamicaDP()
        {

            try
            {

<<<<<<< HEAD
                SqlDataAdapter adptUNO = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',IMP.TipoGenero 'GENERO',INFO.TRIBUNAL 'TRIBUNAL',INFO.REFERENCIA 'REFERENCIA',INFO.DefensorCaso 'Defensor Caso',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA',FA.Hora 'HORA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where INFO.DP like'" + txtDPBuscar.Text + "%'", con);
=======
                SqlDataAdapter adptUNO = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where INFO.DP like'" + txtDPBuscar.Text + "%'", con);
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
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
<<<<<<< HEAD
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',IMP.TipoGenero 'GENERO',INFO.TRIBUNAL 'TRIBUNAL',INFO.REFERENCIA 'REFERENCIA',INFO.DefensorCaso 'Defensor Caso', DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA',FA.Hora 'HORA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where INFO.DP like'" + txtDPBuscar.Text + "%' order by IMP.NOMBRE", con);
=======
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where INFO.DP like'" + txtDPBuscar.Text + "%'", con);
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;
<<<<<<< HEAD
                        

=======
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
                    }


                    else if (iDOS > 0)
                    {

                        con.Open();
<<<<<<< HEAD
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados where INFO.DP like'" + txtDPBuscar.Text + "%' order by IMP.NOMBRE", con);
=======
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados where INFO.DP like'" + txtDPBuscar.Text + "%'", con);
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;
                    }

                    else if (iTRES > 0)
                    {

                        con.Open();
<<<<<<< HEAD
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP where INFO.DP like'" + txtDPBuscar.Text + "%' order by IMP.NOMBRE", con);
=======
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP where INFO.DP like'" + txtDPBuscar.Text + "%'", con);
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void BusquedaDinamicaNOMBRE()
        {
            try
            {

<<<<<<< HEAD
                SqlDataAdapter adptUNO = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA',FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where IMP.NOMBRE like'" + txtDPNombre.Text + "%'", con);
=======
                SqlDataAdapter adptUNO = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where IMP.NOMBRE like'" + txtDPNombre.Text + "%'", con);
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
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
<<<<<<< HEAD
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where IMP.NOMBRE like'" + txtDPNombre.Text + "%'  order by IMP.NOMBRE", con);
=======
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where IMP.NOMBRE like'" + txtDPNombre.Text + "%'", con);
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;
                    }


                    else if (iDOS > 0)
                    {

                        con.Open();
<<<<<<< HEAD
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados where IMP.NOMBRE like'" + txtDPNombre.Text + "%'  order by IMP.NOMBRE", con);
=======
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados where IMP.NOMBRE like'" + txtDPNombre.Text + "%'", con);
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;
                    }

                    else if (iTRES > 0)
                    {

                        con.Open();
<<<<<<< HEAD
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP where IMP.NOMBRE like'" + txtDPNombre.Text + "%'  order by IMP.NOMBRE", con);
=======
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP where IMP.NOMBRE like'" + txtDPNombre.Text + "%'", con);
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
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
            catch(Exception ex)
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
<<<<<<< HEAD
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where IMP.APELLIDO like'" + txtDPApellido.Text + "%' order by IMP.NOMBRE", con);
=======
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where IMP.APELLIDO like'" + txtDPApellido.Text + "%'", con);
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;
                    }


                    else if (iDOS > 0)
                    {

                        con.Open();
<<<<<<< HEAD
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados where IMP.APELLIDO like'" + txtDPApellido.Text + "%' order by IMP.NOMBRE", con);
=======
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados where IMP.APELLIDO like'" + txtDPApellido.Text + "%'", con);
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvBuscar.DataSource = dt;
                    }

                    else if (iTRES > 0)
                    {

                        con.Open();
<<<<<<< HEAD
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP where IMP.APELLIDO like'" + txtDPApellido.Text + "%' order by IMP.NOMBRE", con);
=======
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP where IMP.APELLIDO like'" + txtDPApellido.Text + "%'", con);
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void BuscarImputados_Load(object sender, EventArgs e)
        {

        }

        private void PanelBuscar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {

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

<<<<<<< HEAD
                              
                                DPdatagrid = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();
                             
                                txtDPEditar.Text = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();
                                txtDPEliminar.Text = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();
                                txtDPpdf.Text = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();

                                txtDPBuscar.Text = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();
                            
                                

=======
                                DPdatagrid = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();
                                txtDPEditar.Text = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();
                                txtDPEliminar.Text = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();
                                txtDPpdf.Text = dgvBuscar.Rows[e.RowIndex].Cells[0].Value.ToString();
                               
>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994


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

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarr_Click(object sender, EventArgs e)
        {

        }

        private void txtDPBuscar_TextChanged(object sender, EventArgs e)
        {
            txtDPNombre.Text = "";
            txtDPApellido.Text = "";
            BusquedaDinamicaDP();
        }

        private void txtDPNombre_TextChanged(object sender, EventArgs e)
        {
            txtDPBuscar.Text = "";
            txtDPApellido.Text = "";
            BusquedaDinamicaNOMBRE();
        }

        private void txtDPApellido_TextChanged(object sender, EventArgs e)
        {
            txtDPBuscar.Text = "";
            txtDPNombre.Text = "";
            BusquedaDinamicaAPELLIDO();
        }

        private void btnEditar_Click(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
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
                    if(mensaje == DialogResult.Yes)
                    {
                        con.Open();
                        cmd = new SqlCommand("delete from InfoPenal where DP='" + txtDPEliminar.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("La DP se elimino correctamente");
                        con.Close();
                        displayData();

                    }
                    else if(mensaje == DialogResult.No)
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {
                DirectoryInfo DIR = new DirectoryInfo(@"C:\ProcuAbogadosrr");

                if (DIR.Exists)
                {
                    //No pasa nada
                }
                else
                {
                    DIR.Create();
                }

                string carpeta = @"C:\ProcuAbogadosrr";

                string archivo = @"" + txtDPpdf.Text + ".pdf";

                if (File.Exists(Path.Combine(carpeta, archivo)))
                {
                    MessageBox.Show("El archivo existe, por favor ingresse otro nombre para el archivo");

                }
                else
                {

                    
                    DialogResult mensaje = MessageBox.Show("Estas seguro que deseas guardar el pdf?", "OJO", MessageBoxButtons.YesNo);
                    if (mensaje == DialogResult.Yes)
                    {
                       

                        pbTiempo.Visible = true;
                        for (int n = 0; n < 2150; n++)
                        {
                            
                                pbTiempo.PerformStep();
                            
                        }

                        
                        
                        ImprimirDefinitivo();

                        SaveFileDialog guardar = new SaveFileDialog();
                        guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

                        string paginahtml_texto = Properties.Resources.plantilla.ToString();
                        paginahtml_texto = paginahtml_texto.Replace("@DP", dgvBuscar.CurrentRow.Cells["DP"].Value.ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@AÑO", dgvBuscar.CurrentRow.Cells["AÑO"].Value.ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@DEFENSORP", dgvBuscar.CurrentRow.Cells["Defensor Proceso"].Value.ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@DEFENSORC", dgvBuscar.CurrentRow.Cells["Defensor Caso"].Value.ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@TRIBUNAL", dgvBuscar.CurrentRow.Cells["TRIBUNAL"].Value.ToString());
                        paginahtml_texto = paginahtml_texto.Replace("@REFERENCIA", dgvBuscar.CurrentRow.Cells["REFERENCIA"].Value.ToString());

                        string delito = string.Empty;




                        string completo = string.Empty;
                        string auxiliar = string.Empty;
                        //Cuenta el numero de imputados en el DP
                        int nimp = 0;


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

                        completo = string.Empty;
                        auxiliar = string.Empty;
                        string TeoFi = string.Empty;
                        string TeoDe = string.Empty;
                        string InfoEx = string.Empty;
                        int numeral = 0;
                        int cont = 0;

                        string dateTime;

                        for (int j = 0; j < dgvBuscar.RowCount - 1; j++)
                        {
                            completo = dgvBuscar.Rows[j].Cells["NOMBRE"].Value.ToString() + dgvBuscar.Rows[j].Cells["APELLIDO"].Value.ToString();
                            numeral = j + 1;
                            if (completo != auxiliar)
                            {
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
                                delito += "<td align=\"center\" width=\"20%\" class=\"bolded\">Hecho punible</td>";
                                delito += "<td align=\"center\" width=\"20%\" class=\"bolded\">Informacion de la victima</td>";
                                delito += "<td align=\"center\" width=\"20%\" class=\"bolded\">Tipo de audiencia</td>";
                                delito += "<td align=\"center\" width=\"20%\" class=\"bolded\">Fecha</td>";
                                delito += "<td align=\"center\" width=\"20%\" class=\"bolded\">Hora</td>";
                                delito += "</tr>";
                                delito += "</table>";
                                delito += "";
                                delito += "<table class=\"border\" width=\"100%\">";
                                delito += "<tr>";
                                delito += "<td align=\"center\" width=\"20%\">" + dgvBuscar.Rows[j].Cells["Hecho Punible"].Value.ToString() + "</td>";
                                delito += "<td align=\"center\" width=\"20%\">" + dgvBuscar.Rows[j].Cells["Victima"].Value.ToString() + "</td>";
                                delito += "<td align=\"center\" width=\"20%\">" + dgvBuscar.Rows[j].Cells["TIPO AUDIENCIA"].Value.ToString() + "</td>";
                                delito += "<td align=\"center\" width=\"20%\">" + dgvBuscar.Rows[j].Cells["FECHA AUDIENCIA"].Value.ToString().Substring(0, 9) + "</td>";
                                delito += "<td align=\"center\" width=\"20%\">" + dgvBuscar.Rows[j].Cells["HORA"].Value.ToString() + "</td>";
                                delito += "</tr>";
                                delito += "</table>";
                                auxiliar = completo;

                            }
                            else
                            {
                                cont++;
                                delito += "<table class=\"border\" width=\"100%\">";
                                delito += "<tr>";
                                delito += "<td align=\"center\" width=\"20%\">" + dgvBuscar.Rows[j].Cells["Hecho Punible"].Value.ToString() + "</td>";
                                delito += "<td align=\"center\" width=\"20%\">" + dgvBuscar.Rows[j].Cells["Victima"].Value.ToString() + "</td>";
                                delito += "<td align=\"center\" width=\"20%\">" + dgvBuscar.Rows[j].Cells["TIPO AUDIENCIA"].Value.ToString() + "</td>";
                                delito += "<td align=\"center\" width=\"20%\">" + dgvBuscar.Rows[j].Cells["FECHA AUDIENCIA"].Value.ToString().Substring(0, 9) + "</td>";
                                delito += "<td align=\"center\" width=\"20%\">" + dgvBuscar.Rows[j].Cells["HORA"].Value.ToString() + "</td>";
                                delito += "</tr>";
                                delito += "</table>";
                            }

                        }

                        paginahtml_texto = paginahtml_texto.Replace("@DELITO", delito);


                        con.Open();
                        cmd = new SqlCommand("select TeoFiscalia from TeoCasoComent where DP like '" + txtDPBuscar.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        TeoFi = cmd.ExecuteScalar().ToString();
                        cmd = new SqlCommand("select TeoDefensor from TeoCasoComent where DP like '" + txtDPBuscar.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        TeoDe = cmd.ExecuteScalar().ToString();
                        cmd = new SqlCommand("select InfoExtra from TeoCasoComent where DP like '" + txtDPBuscar.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        InfoEx = cmd.ExecuteScalar().ToString();
                        con.Close();

                        paginahtml_texto = paginahtml_texto.Replace("@TEORIAF", TeoFi);
                        paginahtml_texto = paginahtml_texto.Replace("@TEORIAD", TeoDe);
                        paginahtml_texto = paginahtml_texto.Replace("@COMENTARIO", InfoEx);


                        using (FileStream stream = new FileStream(@"C:\ProcuAbogadosrr\" + txtDPpdf.Text + ".pdf", FileMode.Create))
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
                            pbTiempo.Visible = false;
                            MessageBox.Show("Se guardo correctamente!!");

                            con.Open();
                            cmd = new SqlCommand("insert into InfoPenalImpresiones values(@DP)",con);
                            //cmd.Parameters.AddWithValue("@IdImputados", IdUbicacion);
                            cmd.Parameters.AddWithValue("@DP", txtDPpdf.Text);
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
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            
            
        }

        private void dgvBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            

            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }




            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }



        }

        private void txtDPNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ImprimirDefinitivo()
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
                        txtDPNombre.Text = "";
                        txtDPApellido.Text = "";
                        con.Open();
                        adpt = new SqlDataAdapter("SELECT INFO.DP 'DP',INFO.AÑO 'AÑO', INFO.DefensorProceso 'Defensor Proceso',IMP.NOMBRE 'NOMBRE',IMP.APELLIDO 'APELLIDO',IMP.TipoGenero 'GENERO',INFO.TRIBUNAL 'TRIBUNAL',INFO.REFERENCIA 'REFERENCIA',INFO.DefensorCaso 'Defensor Caso', DV.HechoPunible 'Hecho Punible',DV.InfoVictima 'Victima',FA.Fecha 'FECHA AUDIENCIA',FA.Hora 'HORA', FA.TipoAudiencia 'TIPO AUDIENCIA' FROM InfoPenal INFO INNER JOIN IngresaIMP IMP ON INFO.DP = IMP.DP INNER JOIN DeliVictimas DV ON IMP.IdImputados = DV.IdImputados INNER JOIN FechasAud FA ON IMP.IdImputados = FA.IdImputados where INFO.DP like'" + txtDPBuscar.Text + "%' order by IMP.NOMBRE", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        DataView dv = dt.DefaultView;
                        dv.RowFilter = "DP='" + txtDPBuscar.Text + "'";
                        con.Close();

                        dgvBuscar.DataSource = dv;


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




        private void txtDPApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
=======

>>>>>>> 58c2ce872f08ee919f03197c3c795cd8abca6994
        }
    }
}
