
namespace ConfIniciales.IngresoImputados
{
    partial class PantallaFinalizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelDespedida = new ConfIniciales.GradientPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnIngresar = new FontAwesome.Sharp.IconButton();
            this.PanelDespedida.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDespedida
            // 
            this.PanelDespedida.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PanelDespedida.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelDespedida.Controls.Add(this.iconButton1);
            this.PanelDespedida.Controls.Add(this.btnIngresar);
            this.PanelDespedida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDespedida.Location = new System.Drawing.Point(0, 0);
            this.PanelDespedida.Name = "PanelDespedida";
            this.PanelDespedida.Size = new System.Drawing.Size(1013, 623);
            this.PanelDespedida.TabIndex = 0;
            this.PanelDespedida.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDespedida_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Satellite;
            this.iconButton1.IconColor = System.Drawing.Color.LightSeaGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(420, 245);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(305, 150);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "BUSCAR IMPUTADO";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnIngresar.IconColor = System.Drawing.Color.Orange;
            this.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresar.Location = new System.Drawing.Point(72, 245);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(305, 150);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "MÉNU INICIO";
            this.btnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // PantallaFinalizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 623);
            this.Controls.Add(this.PanelDespedida);
            this.Name = "PantallaFinalizacion";
            this.Text = "PantallaFinalizacion";
            this.PanelDespedida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel PanelDespedida;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}