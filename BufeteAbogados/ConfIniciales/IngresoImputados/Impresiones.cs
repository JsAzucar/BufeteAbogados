using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;

namespace ConfIniciales.IngresoImputados
{
    public partial class Impresiones : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\INSTALADORPROCUSOYAPANGO\BASEPROCURADURIA\BASEPROCURADURIA.MDF;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds = new DataSet();
        SqlDataReader lector;

        int IdTeoriasCaso;
        string DpVariable;
        string ActivarIDT;

        public Impresiones()
        {
            InitializeComponent();
            dgvImpresiones.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12, FontStyle.Bold);
            displayTeorias();
        }
        private void displayTeorias()
        {
            try
            {
                con.Open();
                adpt = new SqlDataAdapter("select *from IngresaIMP", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dgvImpresiones.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImprimir_Click(object sender, System.EventArgs e)
        {

        }

        private void btnImprimir_Click_1(object sender, System.EventArgs e)
        {

        }

        private void dgvImpresiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Int32 selectedRowCount = dgvImpresiones.Rows.GetRowCount(DataGridViewElementStates.Selected);
            try
            {
                if (dgvImpresiones.Rows.Count <= 0)
                {
                    MessageBox.Show("Seleccione un registro por favor");
                }
                else if (dgvImpresiones.Rows.Count > 0)
                {
                    if (selectedRowCount <= 0)
                    {
                        MessageBox.Show("Seleccione un registro");
                    }
                    else
                    {
                        if (dgvImpresiones.AreAllCellsSelected(true))
                        {
                            MessageBox.Show("All cells are selected", "Selected Cells");
                        }
                        else
                        {
                            if (dgvImpresiones.Rows[e.RowIndex].IsNewRow)
                            {
                                MessageBox.Show("Ultima fila seleccionada");

                            }
                            else
                            {

                                IdTeoriasCaso = Convert.ToInt32(dgvImpresiones.Rows[e.RowIndex].Cells[0].Value.ToString());
                                DpVariable = dgvImpresiones.Rows[e.RowIndex].Cells[1].Value.ToString();
                                txtNombre.Text = dgvImpresiones.Rows[e.RowIndex].Cells[2].Value.ToString();
                                txtApellido.Text = dgvImpresiones.Rows[e.RowIndex].Cells[3].Value.ToString();
                                txtDPTeorias.Text = dgvImpresiones.Rows[e.RowIndex].Cells[1].Value.ToString();
                                LBLREGISTRO.Text = dgvImpresiones.Rows[e.RowIndex].Cells[0].Value.ToString();

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

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                    if (txtDPBuscar.Text.Length > 0 || txtDPNombre.Text.Length > 0 || txtDPApellido.Text.Length > 0)
                    {
                        con.Open();
                        adpt = new SqlDataAdapter("select *from IngresaIMP where NOMBRE like'" + txtDPNombre.Text + "%' order by NOMBRE", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvImpresiones.DataSource = dt;
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

        private void txtDPApellido_TextChanged(object sender, EventArgs e)
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
                    if (txtDPBuscar.Text.Length > 0 || txtDPNombre.Text.Length > 0 || txtDPApellido.Text.Length > 0)
                    {
                        con.Open();
                        adpt = new SqlDataAdapter("select *from IngresaIMP where APELLIDO like'" + txtDPApellido.Text + "%' order by NOMBRE", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvImpresiones.DataSource = dt;
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

        private void txtDPBuscar_TextChanged(object sender, EventArgs e)
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
                    if (txtDPBuscar.Text.Length > 0 || txtDPNombre.Text.Length > 0 || txtDPApellido.Text.Length > 0)
                    {
                        con.Open();
                        adpt = new SqlDataAdapter("select *from IngresaIMP where DP like'" + txtDPBuscar.Text + "%' order by DP", con);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        con.Close();
                        dgvImpresiones.DataSource = dt;
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DirectoryInfo DIR = new DirectoryInfo(@"C:\ProcuAbogadosPDF");
            string Combinado = "" + txtDPTeorias.Text + " &ACOPIA& " + txtAliasImputado.Text + "";

            if (DIR.Exists)
            {
                //No pasa nada
            }
            else
            {
                DIR.Create();
            }

            if (txtDPTeorias.Text == "" || txtNombre.Text=="" || txtApellido.Text=="")
            {
                MessageBox.Show("Por favor seleccione un DP de la tabla");
            }
            else
            {
                //txtDpLlenar.Text = dgvBuscar.CurrentRow.Cells["DP"].Value.ToString();
                ActivarIDT = txtDPTeorias.Text;
                //YaEstuvo = "";

                if (txtAliasImputado.Text == "")
                {
                    MessageBox.Show("Por favor, ingrese un nombre para el PDF!");
                }
                else
                {
                    string carpeta = @"C:\ProcuAbogadosPDF";

                    string archivo = @"" + ActivarIDT + " &COPIA& " + txtAliasImputado.Text + ".pdf";

                    if (File.Exists(Path.Combine(carpeta, archivo)))
                    {
                        MessageBox.Show("El archivo existe, por favor ingrese otro nombre para el archivo");

                    }
                    else
                    {
                        //string PDFNOMBRE = txtDPBuscar.Text = dgvBuscar.CurrentRow.Cells["DP"].Value.ToString();

                        DialogResult mensaje = MessageBox.Show("Estas seguro que deseas Imprimir la teoria del caso de  [" + Combinado + " en PDF ]?", "OJO", MessageBoxButtons.YesNo);
                        if (mensaje == DialogResult.Yes)
                        {
                            for (int n = 0; n < 2150; n++)
                            {

                                progressBar1.PerformStep();

                            }

                            //nodelito = "";
                            //ImprimirDefinitivo();

                            SaveFileDialog guardar = new SaveFileDialog();
                            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
                            string paginahtml_texto = Properties.Resources.plantilla2.ToString();

                            //if (dgvImpresiones.Columns.Contains("DP"))
                            //{
                                string NombreDP;

                                con.Open();
                                cmd = new SqlCommand("select DP from InfoPenal where DP like '" + ActivarIDT + "'", con);
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
                                paginahtml_texto = paginahtml_texto.Replace("@DP", NombreDP);
                            //}
                            //else
                            //{
                            //    paginahtml_texto = paginahtml_texto.Replace("@DP", "-");
                            //}


                            //if (dgvBuscar.Columns.Contains("AÑO"))
                            //{
                            string anual;

                            con.Open();
                            cmd = new SqlCommand("select AÑO from InfoPenal where DP like '" + ActivarIDT + "'", con);
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
                            //}
                            //else
                            //{
                            //    paginahtml_texto = paginahtml_texto.Replace("@AÑO", "-");
                            //}

                            //if (dgvBuscar.Columns.Contains("TRIBUNAL"))
                            //{
                            string TriD;
                            con.Open();
                            cmd = new SqlCommand("select TRIBUNAL from InfoPenal where DP like '" + ActivarIDT + "'", con);
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
                            //}
                            //else
                            //{
                            //    paginahtml_texto = paginahtml_texto.Replace("@TRIBUNAL", "-");
                            //}
                            //if (dgvBuscar.Columns.Contains("REFERENCIA"))
                            //{
                            string Ref;
                            con.Open();
                            cmd = new SqlCommand("select REFERENCIA from InfoPenal where DP like '" + ActivarIDT + "'", con);
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
                            //}
                            //else
                            //{
                            //    paginahtml_texto = paginahtml_texto.Replace("@REFERENCIA", "-");
                            //}
                            paginahtml_texto = paginahtml_texto.Replace("@NOMBREI", txtNombre.Text);
                            paginahtml_texto = paginahtml_texto.Replace("@APELLIDOI", txtApellido.Text);
                            string GenI;
                            con.Open();
                            cmd = new SqlCommand("select TipoGenero from IngresaIMP where NOMBRE like '" + txtNombre.Text + "' AND APELLIDO like '" + txtApellido.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            if (cmd.ExecuteScalar() == null)
                            {
                                GenI = "-";
                            }
                            else
                            {
                                GenI = cmd.ExecuteScalar().ToString();
                            }
                            con.Close();
                            paginahtml_texto = paginahtml_texto.Replace("@GENEROI", GenI);


                            //INFORMACION DE LAS TEORIAS

                            string TeoFi = string.Empty;
                            string TeoDe = string.Empty;
                            string InfoEx = string.Empty;
                            string TeoriaFiscalia = string.Empty;
                            string TeoriaDefensa = string.Empty;
                            string Cometario = string.Empty;



                            con.Open();
                            cmd = new SqlCommand("select TeoFiscalia from TeoCasoComent where NOMBRE like '" + txtNombre.Text + "' AND APELLIDO like '"+txtApellido.Text+"' AND DP like '" +txtDPTeorias.Text+"'", con);
                            cmd.ExecuteNonQuery();
                            if (cmd.ExecuteScalar() == null)
                            {
                                TeoriaFiscalia += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                            }
                            else
                            {
                                TeoFi = cmd.ExecuteScalar().ToString();
                            }

                            cmd = new SqlCommand("select TeoDefensor from TeoCasoComent where NOMBRE like '" + txtNombre.Text + "' AND APELLIDO like '" + txtApellido.Text + "' AND DP like '" + txtDPTeorias.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            if (cmd.ExecuteScalar() == null)
                            {
                                TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                            }
                            else
                            {
                                TeoDe = cmd.ExecuteScalar().ToString();
                            }

                            cmd = new SqlCommand("select InfoExtra from TeoCasoComent where NOMBRE like '" + txtNombre.Text + "' AND APELLIDO like '" + txtApellido.Text + "' AND DP like '" + txtDPTeorias.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            if (cmd.ExecuteScalar() == null)
                            {
                                Cometario += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                            }
                            else
                            {
                                InfoEx = cmd.ExecuteScalar().ToString();
                            }
                            con.Close();

                            int partida = -1;
                            int terminal = 0;
                            int longitudLinea = 0;
                            string Cadena = string.Empty;
                            string ULinea = string.Empty;
                            string SCadena = string.Empty;
                            int contE = 0;
                            TeoriaFiscalia += " ";

                            for (int t = 0; t < TeoFi.Length; t++)
                            {
                                if (TeoFi[t] == 10)
                                {
                                    contE++;
                                }

                            }

                            if (contE > 0)
                            {

                                for (int m = 0; m < TeoFi.Length; m++)
                                {

                                    if (TeoFi[m] == 10)
                                    {

                                        partida = partida + 1;
                                        terminal = m - 1;
                                        longitudLinea = terminal - partida;

                                        if (partida >= 0)
                                        {
                                            Cadena = TeoFi.Substring(partida, longitudLinea);
                                            if (Cadena == "")
                                            {
                                                TeoriaFiscalia += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                                TeoriaFiscalia += "</table>";
                                                TeoriaFiscalia += "<div id=\"general3\"></div>";
                                                TeoriaFiscalia += "<table>";
                                                TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                            }
                                            else
                                            {
                                                // MessageBox.Show(Cadena.Length.ToString());
                                                if (Cadena.Length > 114)
                                                {
                                                    TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                                    TeoriaFiscalia += "</table>";
                                                    TeoriaFiscalia += "<div id=\"general3\">" + Cadena + " </div>";
                                                    TeoriaFiscalia += "<table>";
                                                    TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                                }
                                                else
                                                {
                                                    TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                                    TeoriaFiscalia += "</table>";
                                                    TeoriaFiscalia += "<div id=\"general2\">" + Cadena + " </div>";
                                                    TeoriaFiscalia += "<table>";
                                                    TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                                }
                                            }
                                        }
                                        partida = m;
                                    }
                                    //else
                                    //{
                                    //    TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                    //}
                                    if (m == TeoFi.Length - 1)
                                    {
                                        if (partida >= 0)
                                        {
                                            ULinea = TeoFi.Substring(partida, TeoFi.Length - partida);
                                            if (ULinea.Length > 114)
                                            {
                                                TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                                TeoriaFiscalia += "</table>";
                                                TeoriaFiscalia += "<div id=\"general3\">" + ULinea + " </div>";
                                                TeoriaFiscalia += "<table>";
                                                TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                            }
                                            else
                                            {
                                                TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                                TeoriaFiscalia += "</table>";
                                                TeoriaFiscalia += "<div id=\"general3\">" + ULinea + " </div>";
                                                TeoriaFiscalia += "<table>";
                                                TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (TeoFi.Length > 0)
                                {
                                    TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                    TeoriaFiscalia += "</table>";
                                    TeoriaFiscalia += "<div id=\"general1\">" + TeoFi + " </div>";
                                    TeoriaFiscalia += "<table>";
                                    TeoriaFiscalia += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                }
                                else
                                {
                                    TeoriaFiscalia += "<tr><td aling =\"left\" ></td></tr>";
                                }

                            }

                            partida = -1;
                            terminal = 0;
                            longitudLinea = 0;
                            Cadena = " ";
                            ULinea = " ";
                            SCadena = " ";
                            contE = 0;
                            TeoriaDefensa += " ";

                            for (int t = 0; t < TeoDe.Length; t++)
                            {
                                if (TeoDe[t] == 10)
                                {
                                    contE++;
                                }

                            }

                            if (contE > 0)
                            {

                                for (int m = 0; m < TeoDe.Length; m++)
                                {

                                    if (TeoDe[m] == 10)
                                    {

                                        partida = partida + 1;
                                        terminal = m - 1;
                                        longitudLinea = terminal - partida;

                                        if (partida >= 0)
                                        {
                                            Cadena = TeoDe.Substring(partida, longitudLinea);
                                            if (Cadena == "")
                                            {
                                                TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                                TeoriaDefensa += "</table>";
                                                TeoriaDefensa += "<div id=\"general3\"></div>";
                                                TeoriaDefensa += "<table>";
                                                TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                            }
                                            else
                                            {
                                                // MessageBox.Show(Cadena.Length.ToString());
                                                if (Cadena.Length > 114)
                                                {
                                                    TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                                    TeoriaDefensa += "</table>";
                                                    TeoriaDefensa += "<div id=\"general3\">" + Cadena + " </div>";
                                                    TeoriaDefensa += "<table>";
                                                    TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                                }
                                                else
                                                {
                                                    TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                                    TeoriaDefensa += "</table>";
                                                    TeoriaDefensa += "<div id=\"general2\">" + Cadena + " </div>";
                                                    TeoriaDefensa += "<table>";
                                                    TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                                }
                                            }
                                        }
                                        partida = m;
                                    }
                                    //else
                                    //{
                                    //    TeoriaDefensa += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                    //}
                                    if (m == TeoDe.Length - 1)
                                    {
                                        if (partida >= 0)
                                        {
                                            ULinea = TeoDe.Substring(partida, TeoDe.Length - partida);
                                            if (ULinea.Length > 114)
                                            {
                                                TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                                TeoriaDefensa += "</table>";
                                                TeoriaDefensa += "<div id=\"general3\">" + ULinea + " </div>";
                                                TeoriaDefensa += "<table>";
                                                TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                            }
                                            else
                                            {
                                                TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                                TeoriaDefensa += "</table>";
                                                TeoriaDefensa += "<div id=\"general3\">" + ULinea + " </div>";
                                                TeoriaDefensa += "<table>";
                                                TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (TeoDe.Length > 0)
                                {

                                    TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                    TeoriaDefensa += "</table>";
                                    TeoriaDefensa += "<div id=\"general1\">" + TeoDe + " </div>";
                                    TeoriaDefensa += "<table>";
                                    TeoriaDefensa += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                }
                                else
                                {
                                    TeoriaFiscalia += "<tr><td aling =\"left\" ></td></tr>";
                                }
                            }


                            Cometario += " ";
                            partida = -1;
                            terminal = 0;
                            longitudLinea = 0;
                            Cadena = " ";
                            ULinea = " ";
                            SCadena = " ";
                            contE = 0;

                            for (int t = 0; t < InfoEx.Length; t++)
                            {
                                if (InfoEx[t] == 10)
                                {
                                    contE++;
                                }

                            }

                            if (contE > 0)
                            {

                                for (int m = 0; m < InfoEx.Length; m++)
                                {

                                    if (InfoEx[m] == 10)
                                    {

                                        partida = partida + 1;
                                        terminal = m - 1;
                                        longitudLinea = terminal - partida;

                                        if (partida >= 0)
                                        {
                                            Cadena = InfoEx.Substring(partida, longitudLinea);
                                            if (Cadena == "")
                                            {
                                                Cometario += "<tr><td colspan=\"3\" height=\"9\"></td></tr>";
                                                Cometario += "</table>";
                                                Cometario += "<div id=\"general3\"></div>";
                                                Cometario += "<table>";
                                                Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                            }
                                            else
                                            {
                                                // MessageBox.Show(Cadena.Length.ToString());
                                                if (Cadena.Length > 114)
                                                {
                                                    Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                                    Cometario += "</table>";
                                                    Cometario += "<div id=\"general3\">" + Cadena + " </div>";
                                                    Cometario += "<table>";
                                                    Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                                }
                                                else
                                                {
                                                    Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                                    Cometario += "</table>";
                                                    Cometario += "<div id=\"general2\">" + Cadena + " </div>";
                                                    Cometario += "<table>";
                                                    Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                                }
                                            }
                                        }
                                        partida = m;
                                    }
                                    //else
                                    //{
                                    //    Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                    //}
                                    if (m == InfoEx.Length - 1)
                                    {
                                        if (partida >= 0)
                                        {
                                            ULinea = InfoEx.Substring(partida, InfoEx.Length - partida);
                                            if (ULinea.Length > 114)
                                            {
                                                Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                                Cometario += "</table>";
                                                Cometario += "<div id=\"general3\">" + ULinea + " </div>";
                                                Cometario += "<table>";
                                                Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                            }
                                            else
                                            {
                                                Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                                Cometario += "</table>";
                                                Cometario += "<div id=\"general3\">" + ULinea + " </div>";
                                                Cometario += "<table>";
                                                Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (InfoEx.Length > 0)
                                {
                                    Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                    Cometario += "</table>";
                                    Cometario += "<div id=\"general1\">" + InfoEx + " </div>";
                                    Cometario += "<table>";
                                    Cometario += "<tr><td aling =\"left\" >" + " " + "</td></tr>";
                                }
                                else
                                {
                                    Cometario += "<tr><td aling =\"left\" >-</td></tr>";
                                }
                            }




                            paginahtml_texto = paginahtml_texto.Replace("@TEORIAF", TeoriaFiscalia);
                            paginahtml_texto = paginahtml_texto.Replace("@TEORIAD", TeoriaDefensa);
                            paginahtml_texto = paginahtml_texto.Replace("@COMENTARIO", Cometario);



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
                                progressBar1.Value = 0;
                                txtAliasImputado.Text = "";
                                txtDPTeorias.Text = "";
                                txtNombre.Text = "";
                                txtApellido.Text = "";


                                con.Open();
                                cmd = new SqlCommand("insert into InfoPenalImpresiones values(@DP)", con);
                                //cmd.Parameters.AddWithValue("@IdImputados", IdUbicacion);
                                cmd.Parameters.AddWithValue("@DP", Combinado);
                                cmd.ExecuteNonQuery();
                                con.Close();

                            }
                        }
                    }
                }
            }

















                        }

        private void dgvImpresiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
