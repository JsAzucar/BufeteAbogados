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

namespace ConfIniciales.IngresoImputados
{
    public partial class PantallaFinalizacion : Form
    {
        private Form currentChilForm; //Campo para almacenar el formulario hijo actual

        public PantallaFinalizacion()
        {
            InitializeComponent();
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
                PanelDespedida.Controls.Add(childForm);
                PanelDespedida.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PanelDespedida_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bienvenida());
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SearchIMP());
        }
    }
}
