using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ConfIniciales
{
    public partial class Form1 : Form
    {

        private IconButton currentBtn;
        private Form currentChilForm; //Campo para almacenar el formulario hijo actual
        
        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            OpenChildForm(new ConfIniciales.Bienvenida());
            //WindowState = FormWindowState.Maximized;
            // this.Text = string.Empty;
            // this.ControlBox = false;       

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
                PanelContenedor.Controls.Add(childForm);
                PanelContenedor.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private struct RGBColors
        {
            public static Color color1 = Color.Coral;
            public static Color color2 = Color.PaleVioletRed;
            public static Color color3 = Color.Indigo;
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.DarkViolet;
        }
            private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Khaki;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //IconCurrentChildForm
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
              


            }
        }
        private void DisableButton()
        {
            //Button

            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.SteelBlue;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        
        private void PnaelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PnaelTop_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void PnaelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
            //OpenChildForm(new ConfIniciales.IngresoImputados.ImputadosPrincipal());

           if(TitleChildForm.Text == "Home" || TitleChildForm.Text == "Historial Impresiones" || TitleChildForm.Text == "Creditos" || TitleChildForm.Text == "Imprimir pdf")
            {
                
                ActivateButton(sender, RGBColors.color1);
                TitleChildForm.Text = "Ingresar Imputados";
                OpenChildForm(new ConfIniciales.IngresoImputados.ImputadosPrincipal());
            }

            else if (TitleChildForm.Text =="Ingresar Imputados" || TitleChildForm.Text == "Buscar Imputados")
            {
                //TitleChildForm.Text = "Ingresar Imputados";
                DialogResult GuardarCambios = MessageBox.Show("¿ Desea continuar sin guardar los cambios realizados ?", "OJO", MessageBoxButtons.YesNo);
                if (GuardarCambios == DialogResult.Yes)
                {
                    ActivateButton(sender, RGBColors.color1);
                    TitleChildForm.Text = "Ingresar Imputados";
                    OpenChildForm(new ConfIniciales.IngresoImputados.ImputadosPrincipal());
                }
                else if (GuardarCambios == DialogResult.No)
                {
                   
                }
            }
           


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
                 
            if (TitleChildForm.Text == "Home" || TitleChildForm.Text == "Historial Impresiones" || TitleChildForm.Text == "Creditos" || TitleChildForm.Text == "Imprimir pdf")
            {
                ActivateButton(sender, RGBColors.color2);               
                TitleChildForm.Text = "Buscar Imputados";
                OpenChildForm(new SearchIMP());
            }

            else if (TitleChildForm.Text == "Buscar Imputados" || TitleChildForm.Text == "Ingresar Imputados")
            {
                DialogResult GuardarCambios = MessageBox.Show("¿ Desea continuar sin guardar los cambios realizados ?", "OJO", MessageBoxButtons.YesNo);
                if (GuardarCambios == DialogResult.Yes)
                {
                    ActivateButton(sender, RGBColors.color2);
                    TitleChildForm.Text = "Buscar Imputados";
                    OpenChildForm(new SearchIMP());
                }
                else if (GuardarCambios == DialogResult.No)
                {
                    
                }
            }



        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            //OpenChildForm(new ConfIniciales.IngresoImputados.ImputadosPrincipal());

            if (TitleChildForm.Text == "Home" || TitleChildForm.Text == "Creditos" || TitleChildForm.Text == "Historial Impresiones")
            {

                ActivateButton(sender, RGBColors.color3);
                TitleChildForm.Text = "Imprimir pdf";
                OpenChildForm(new ConfIniciales.IngresoImputados.Impresiones());
            }

            else if (TitleChildForm.Text == "Ingresar Imputados" || TitleChildForm.Text == "Buscar Imputados")
            {
                //TitleChildForm.Text = "Ingresar Imputados";
                DialogResult GuardarCambios = MessageBox.Show("¿ Desea continuar sin guardar los cambios realizados ?", "OJO", MessageBoxButtons.YesNo);
                if (GuardarCambios == DialogResult.Yes)
                {
                    ActivateButton(sender, RGBColors.color3);
                    TitleChildForm.Text = "Imprimir pdf";
                    OpenChildForm(new ConfIniciales.IngresoImputados.Impresiones());
                }
                else if (GuardarCambios == DialogResult.No)
                {

                }
            }
            else if(TitleChildForm.Text == "Imprimir pdf")
            {
                ActivateButton(sender, RGBColors.color3);
                TitleChildForm.Text = "Imprimir pdf";
            }



        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new ConfIniciales.IngresoImputados.ImputadosPrincipal());

            if (TitleChildForm.Text == "Home" || TitleChildForm.Text == "Creditos" || TitleChildForm.Text == "Imprimir pdf")
            {

                ActivateButton(sender, RGBColors.color3);
                TitleChildForm.Text = "Historial Impresiones";
                OpenChildForm(new HistorialImpresiones()); ;
            }

            else if (TitleChildForm.Text == "Ingresar Imputados" || TitleChildForm.Text == "Buscar Imputados")
            {
                //TitleChildForm.Text = "Ingresar Imputados";
                DialogResult GuardarCambios = MessageBox.Show("¿ Desea continuar sin guardar los cambios realizados ?", "OJO", MessageBoxButtons.YesNo);
                if (GuardarCambios == DialogResult.Yes)
                {
                    ActivateButton(sender, RGBColors.color3);
                    TitleChildForm.Text = "Historial Impresiones";
                    OpenChildForm(new HistorialImpresiones());
                }
                else if (GuardarCambios == DialogResult.No)
                {

                }
            }
            else if (TitleChildForm.Text == "Historial Impresiones")
            {
                ActivateButton(sender, RGBColors.color3);
                TitleChildForm.Text = "Historial Impresiones";
            }


        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (TitleChildForm.Text == "Home" || TitleChildForm.Text == "Historial Impresiones" || TitleChildForm.Text == "Imprimir pdf")
            {

                ActivateButton(sender, RGBColors.color4);
                TitleChildForm.Text = "Creditos";
                OpenChildForm(new Creditos());
            }

            else if (TitleChildForm.Text == "Ingresar Imputados" || TitleChildForm.Text == "Buscar Imputados")
            {
                DialogResult GuardarCambios = MessageBox.Show("¿ Desea continuar sin guardar los cambios realizados ?", "OJO", MessageBoxButtons.YesNo);
                if (GuardarCambios == DialogResult.Yes)
                {
                    ActivateButton(sender, RGBColors.color4);
                    TitleChildForm.Text = "Creditos";
                    OpenChildForm(new Creditos());
                }
                else if (GuardarCambios == DialogResult.No)
                {

                }
            }
            else if (TitleChildForm.Text == "Creditos")
            {

                ActivateButton(sender, RGBColors.color4);
                TitleChildForm.Text = "Creditos";
            }


        }

        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void Reset()
        {
            DisableButton();
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Crimson;
            TitleChildForm.Text = "Home";

        }

        private void PanelLogo_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void PanelLogo_Click(object sender, EventArgs e)
        {
            if (currentChilForm == null)
            {
               
            }
            else
            {
                //TitleChildForm.Text = "Ingresar Imputados";
                DialogResult GuardarCambios = MessageBox.Show("¿ Desea continuar sin guardar los cambios realizados ?", "OJO", MessageBoxButtons.YesNo);
                if (GuardarCambios == DialogResult.Yes)
                {
                    currentChilForm.Close();
                }
                else if (GuardarCambios == DialogResult.No)
                {

                }
            }
            
            Reset();
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }

        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);

            DialogResult mensaje = MessageBox.Show("¿ Estas seguro que desea salir del programa ?", "OJO", MessageBoxButtons.YesNo);
            if (mensaje == DialogResult.Yes)
            {

                Application.Exit();
            }
            else if (mensaje == DialogResult.No)
            {
                //No
            }
        }
    }
}
