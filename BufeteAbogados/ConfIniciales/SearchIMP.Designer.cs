
namespace ConfIniciales
{
    partial class SearchIMP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelBuscar = new ConfIniciales.GradientPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDpLlenar = new System.Windows.Forms.TextBox();
            this.pbTiempo = new System.Windows.Forms.ProgressBar();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.txtDPpdf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.txtDPEliminar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.txtDPEditar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.txtDPBuscar = new System.Windows.Forms.TextBox();
            this.txtDPApellido = new System.Windows.Forms.TextBox();
            this.txtDPNombre = new System.Windows.Forms.TextBox();
            this.PanelBuscar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBuscar
            // 
            this.PanelBuscar.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PanelBuscar.ColorTop = System.Drawing.Color.White;
            this.PanelBuscar.Controls.Add(this.groupBox3);
            this.PanelBuscar.Controls.Add(this.label4);
            this.PanelBuscar.Controls.Add(this.groupBox2);
            this.PanelBuscar.Controls.Add(this.groupBox1);
            this.PanelBuscar.Controls.Add(this.label3);
            this.PanelBuscar.Controls.Add(this.label2);
            this.PanelBuscar.Controls.Add(this.label1);
            this.PanelBuscar.Controls.Add(this.dgvBuscar);
            this.PanelBuscar.Controls.Add(this.txtDPBuscar);
            this.PanelBuscar.Controls.Add(this.txtDPApellido);
            this.PanelBuscar.Controls.Add(this.txtDPNombre);
            this.PanelBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBuscar.Location = new System.Drawing.Point(0, 0);
            this.PanelBuscar.Name = "PanelBuscar";
            this.PanelBuscar.Size = new System.Drawing.Size(1013, 609);
            this.PanelBuscar.TabIndex = 0;
            this.PanelBuscar.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBuscar_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDpLlenar);
            this.groupBox3.Controls.Add(this.pbTiempo);
            this.groupBox3.Controls.Add(this.iconButton5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnImprimir);
            this.groupBox3.Controls.Add(this.txtDPpdf);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(510, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 218);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IMPRIMIR PDF";
            this.groupBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox3_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "DP";
            // 
            // txtDpLlenar
            // 
            this.txtDpLlenar.Enabled = false;
            this.txtDpLlenar.Location = new System.Drawing.Point(65, 46);
            this.txtDpLlenar.Name = "txtDpLlenar";
            this.txtDpLlenar.Size = new System.Drawing.Size(143, 24);
            this.txtDpLlenar.TabIndex = 19;
            // 
            // pbTiempo
            // 
            this.pbTiempo.Location = new System.Drawing.Point(5, 134);
            this.pbTiempo.Margin = new System.Windows.Forms.Padding(2);
            this.pbTiempo.Maximum = 90;
            this.pbTiempo.Name = "pbTiempo";
            this.pbTiempo.Size = new System.Drawing.Size(234, 12);
            this.pbTiempo.TabIndex = 18;
            // 
            // iconButton5
            // 
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(174, 0);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(48, 26);
            this.iconButton5.TabIndex = 16;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "NOMBRE DE COPIA";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImprimir.IconColor = System.Drawing.Color.Black;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.Location = new System.Drawing.Point(82, 153);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(111, 36);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtDPpdf
            // 
            this.txtDPpdf.Location = new System.Drawing.Point(65, 96);
            this.txtDPpdf.Name = "txtDPpdf";
            this.txtDPpdf.Size = new System.Drawing.Size(143, 24);
            this.txtDPpdf.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(507, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "APELLIDO";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.iconButton4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.txtDPEliminar);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(266, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 189);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ELIMINAR";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            this.iconButton4.IconColor = System.Drawing.Color.Blue;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(174, 0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(48, 36);
            this.iconButton4.TabIndex = 16;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "DP";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Location = new System.Drawing.Point(54, 110);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 36);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtDPEliminar
            // 
            this.txtDPEliminar.Location = new System.Drawing.Point(29, 66);
            this.txtDPEliminar.Name = "txtDPEliminar";
            this.txtDPEliminar.Size = new System.Drawing.Size(128, 24);
            this.txtDPEliminar.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.iconButton3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.txtDPEditar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(29, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 189);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VER/EDITAR";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(146, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(48, 42);
            this.iconButton3.TabIndex = 15;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "DP";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.Location = new System.Drawing.Point(42, 105);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 36);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "VER/EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtDPEditar
            // 
            this.txtDPEditar.Location = new System.Drawing.Point(29, 66);
            this.txtDPEditar.Name = "txtDPEditar";
            this.txtDPEditar.Size = new System.Drawing.Size(128, 24);
            this.txtDPEditar.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(341, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(197, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "DP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "BUSCAR";
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgvBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuscar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBuscar.ColumnHeadersHeight = 29;
            this.dgvBuscar.EnableHeadersVisualStyles = false;
            this.dgvBuscar.Location = new System.Drawing.Point(29, 79);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBuscar.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBuscar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBuscar.RowTemplate.Height = 30;
            this.dgvBuscar.Size = new System.Drawing.Size(661, 182);
            this.dgvBuscar.TabIndex = 21;
            this.dgvBuscar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscar_CellDoubleClick);
            // 
            // txtDPBuscar
            // 
            this.txtDPBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDPBuscar.Location = new System.Drawing.Point(143, 49);
            this.txtDPBuscar.Name = "txtDPBuscar";
            this.txtDPBuscar.Size = new System.Drawing.Size(128, 24);
            this.txtDPBuscar.TabIndex = 18;
            this.txtDPBuscar.TextChanged += new System.EventHandler(this.txtDPBuscar_TextChanged);
            this.txtDPBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDPBuscar_KeyPress);
            // 
            // txtDPApellido
            // 
            this.txtDPApellido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDPApellido.Location = new System.Drawing.Point(464, 49);
            this.txtDPApellido.Name = "txtDPApellido";
            this.txtDPApellido.Size = new System.Drawing.Size(148, 24);
            this.txtDPApellido.TabIndex = 20;
            this.txtDPApellido.TextChanged += new System.EventHandler(this.txtDPApellido_TextChanged);
            this.txtDPApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDPApellido_KeyPress);
            // 
            // txtDPNombre
            // 
            this.txtDPNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDPNombre.Location = new System.Drawing.Point(295, 49);
            this.txtDPNombre.Name = "txtDPNombre";
            this.txtDPNombre.Size = new System.Drawing.Size(150, 24);
            this.txtDPNombre.TabIndex = 19;
            this.txtDPNombre.TextChanged += new System.EventHandler(this.txtDPNombre_TextChanged);
            this.txtDPNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDPNombre_KeyPress);
            // 
            // SearchIMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 609);
            this.Controls.Add(this.PanelBuscar);
            this.Name = "SearchIMP";
            this.Text = "SearchIMP";
            this.PanelBuscar.ResumeLayout(false);
            this.PanelBuscar.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel PanelBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.TextBox txtDPEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.TextBox txtDPEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.TextBox txtDPBuscar;
        private System.Windows.Forms.TextBox txtDPApellido;
        private System.Windows.Forms.TextBox txtDPNombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDpLlenar;
        private System.Windows.Forms.ProgressBar pbTiempo;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.TextBox txtDPpdf;
    }
}