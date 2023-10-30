
namespace ConfIniciales.IngresoImputados
{
    partial class ImputadosPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelImputadoPrincipal = new ConfIniciales.GradientPanel();
            this.gradientPanel1 = new ConfIniciales.GradientPanel();
            this.gbImputado = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.DataGridViewIMPp = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rdFemenino = new System.Windows.Forms.RadioButton();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComboAño = new System.Windows.Forms.ComboBox();
            this.lblDPinformacion = new System.Windows.Forms.Label();
            this.lblDP = new System.Windows.Forms.Label();
            this.btnEditarInfo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReferencia_ImpPrincipal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDcaso_ImpPrincipal = new System.Windows.Forms.TextBox();
            this.txtDP_ImpPrincipal = new System.Windows.Forms.TextBox();
            this.txtDproceso_ImpPrincipal = new System.Windows.Forms.TextBox();
            this.txtTribunal_ImpPrincipal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLimpiar = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PanelImputadoPrincipal.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.gbImputado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIMPp)).BeginInit();
            this.gbGenero.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelImputadoPrincipal
            // 
            this.PanelImputadoPrincipal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelImputadoPrincipal.ColorBottom = System.Drawing.Color.RoyalBlue;
            this.PanelImputadoPrincipal.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelImputadoPrincipal.Controls.Add(this.gradientPanel1);
            this.PanelImputadoPrincipal.Controls.Add(this.btnSiguiente);
            this.PanelImputadoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelImputadoPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelImputadoPrincipal.Name = "PanelImputadoPrincipal";
            this.PanelImputadoPrincipal.Size = new System.Drawing.Size(1013, 609);
            this.PanelImputadoPrincipal.TabIndex = 27;
            this.PanelImputadoPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelImputadoPrincipal_Paint);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.AutoScroll = true;
            this.gradientPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.gbImputado);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.groupBox3);
            this.gradientPanel1.Controls.Add(this.lblLimpiar);
            this.gradientPanel1.Location = new System.Drawing.Point(12, 12);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(730, 436);
            this.gradientPanel1.TabIndex = 27;
            // 
            // gbImputado
            // 
            this.gbImputado.BackColor = System.Drawing.Color.Transparent;
            this.gbImputado.Controls.Add(this.txtApellido);
            this.gbImputado.Controls.Add(this.btnAgregar2);
            this.gbImputado.Controls.Add(this.DataGridViewIMPp);
            this.gbImputado.Controls.Add(this.label1);
            this.gbImputado.Controls.Add(this.btnEliminar);
            this.gbImputado.Controls.Add(this.txtNombre);
            this.gbImputado.Controls.Add(this.btnEditar);
            this.gbImputado.Controls.Add(this.gbGenero);
            this.gbImputado.Controls.Add(this.label5);
            this.gbImputado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImputado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbImputado.Location = new System.Drawing.Point(9, 279);
            this.gbImputado.Name = "gbImputado";
            this.gbImputado.Size = new System.Drawing.Size(932, 326);
            this.gbImputado.TabIndex = 28;
            this.gbImputado.TabStop = false;
            this.gbImputado.Text = "IMPUTADO";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(173, 62);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(167, 27);
            this.txtApellido.TabIndex = 13;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar2.Location = new System.Drawing.Point(6, 201);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(91, 43);
            this.btnAgregar2.TabIndex = 23;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = true;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // DataGridViewIMPp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(128)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewIMPp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewIMPp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(128)))), ((int)(((byte)(216)))));
            this.DataGridViewIMPp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewIMPp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewIMPp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewIMPp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewIMPp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.DataGridViewIMPp.EnableHeadersVisualStyles = false;
            this.DataGridViewIMPp.Location = new System.Drawing.Point(346, 38);
            this.DataGridViewIMPp.Name = "DataGridViewIMPp";
            this.DataGridViewIMPp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewIMPp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(128)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewIMPp.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewIMPp.RowTemplate.Height = 30;
            this.DataGridViewIMPp.Size = new System.Drawing.Size(568, 309);
            this.DataGridViewIMPp.TabIndex = 28;
            this.DataGridViewIMPp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewIMPp_CellDoubleClick_1);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "IdImputados";
            this.Column6.HeaderText = "IdImputados";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.DataPropertyName = "DP";
            this.Column7.HeaderText = "DP";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.DataPropertyName = "NOMBRE";
            this.Column8.HeaderText = "Nombre";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 200;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column9.DataPropertyName = "APELLIDO";
            this.Column9.HeaderText = "Apellido";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 200;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column10.DataPropertyName = "TipoGenero";
            this.Column10.HeaderText = "Género";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(224, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Apellido";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(220, 201);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 43);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(12, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 27);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(116, 201);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 43);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rdFemenino);
            this.gbGenero.Controls.Add(this.rdMasculino);
            this.gbGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenero.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gbGenero.Location = new System.Drawing.Point(13, 95);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(191, 100);
            this.gbGenero.TabIndex = 25;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // rdFemenino
            // 
            this.rdFemenino.AutoSize = true;
            this.rdFemenino.Location = new System.Drawing.Point(6, 64);
            this.rdFemenino.Name = "rdFemenino";
            this.rdFemenino.Size = new System.Drawing.Size(105, 23);
            this.rdFemenino.TabIndex = 21;
            this.rdFemenino.TabStop = true;
            this.rdFemenino.Text = "Femenino";
            this.rdFemenino.UseVisualStyleBackColor = true;
            // 
            // rdMasculino
            // 
            this.rdMasculino.AutoSize = true;
            this.rdMasculino.Location = new System.Drawing.Point(6, 25);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(106, 23);
            this.rdMasculino.TabIndex = 20;
            this.rdMasculino.TabStop = true;
            this.rdMasculino.Text = "Masculino";
            this.rdMasculino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(62, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(281, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "ASIGNAR IMPUTADOS";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.ComboAño);
            this.groupBox3.Controls.Add(this.lblDPinformacion);
            this.groupBox3.Controls.Add(this.lblDP);
            this.groupBox3.Controls.Add(this.btnEditarInfo);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtReferencia_ImpPrincipal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDcaso_ImpPrincipal);
            this.groupBox3.Controls.Add(this.txtDP_ImpPrincipal);
            this.groupBox3.Controls.Add(this.txtDproceso_ImpPrincipal);
            this.groupBox3.Controls.Add(this.txtTribunal_ImpPrincipal);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(9, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 193);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Penal";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ComboAño
            // 
            this.ComboAño.AccessibleDescription = "";
            this.ComboAño.AccessibleName = "";
            this.ComboAño.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ComboAño.DisplayMember = "2022";
            this.ComboAño.DropDownHeight = 80;
            this.ComboAño.FormatString = "N0";
            this.ComboAño.FormattingEnabled = true;
            this.ComboAño.IntegralHeight = false;
            this.ComboAño.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2034",
            "2035",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.ComboAño.Location = new System.Drawing.Point(172, 42);
            this.ComboAño.Name = "ComboAño";
            this.ComboAño.Size = new System.Drawing.Size(85, 27);
            this.ComboAño.TabIndex = 36;
            this.ComboAño.Tag = "";
            this.ComboAño.Text = "2022";
            this.ComboAño.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDPinformacion
            // 
            this.lblDPinformacion.AutoSize = true;
            this.lblDPinformacion.Location = new System.Drawing.Point(39, 139);
            this.lblDPinformacion.Name = "lblDPinformacion";
            this.lblDPinformacion.Size = new System.Drawing.Size(44, 19);
            this.lblDPinformacion.TabIndex = 33;
            this.lblDPinformacion.Text = "-----";
            // 
            // lblDP
            // 
            this.lblDP.AutoSize = true;
            this.lblDP.Location = new System.Drawing.Point(6, 139);
            this.lblDP.Name = "lblDP";
            this.lblDP.Size = new System.Drawing.Size(33, 19);
            this.lblDP.TabIndex = 32;
            this.lblDP.Text = "DP:";
            // 
            // btnEditarInfo
            // 
            this.btnEditarInfo.Enabled = false;
            this.btnEditarInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarInfo.Location = new System.Drawing.Point(464, 128);
            this.btnEditarInfo.Name = "btnEditarInfo";
            this.btnEditarInfo.Size = new System.Drawing.Size(187, 40);
            this.btnEditarInfo.TabIndex = 31;
            this.btnEditarInfo.Text = "Editar";
            this.btnEditarInfo.UseVisualStyleBackColor = true;
            this.btnEditarInfo.Click += new System.EventHandler(this.btnEditarInfo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(228, 128);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(187, 40);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(196, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 19);
            this.label18.TabIndex = 29;
            this.label18.Text = "Año";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(408, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(170, 19);
            this.label17.TabIndex = 27;
            this.label17.Text = "Defensor del proceso\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Defensor del caso\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "    DP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(569, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Referencia";
            // 
            // txtReferencia_ImpPrincipal
            // 
            this.txtReferencia_ImpPrincipal.Location = new System.Drawing.Point(497, 38);
            this.txtReferencia_ImpPrincipal.Name = "txtReferencia_ImpPrincipal";
            this.txtReferencia_ImpPrincipal.Size = new System.Drawing.Size(218, 27);
            this.txtReferencia_ImpPrincipal.TabIndex = 23;
            this.txtReferencia_ImpPrincipal.TextChanged += new System.EventHandler(this.txtReferencia_ImpPrincipal_TextChanged);
            this.txtReferencia_ImpPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReferencia_ImpPrincipal_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tribunal";
            // 
            // txtDcaso_ImpPrincipal
            // 
            this.txtDcaso_ImpPrincipal.Location = new System.Drawing.Point(90, 92);
            this.txtDcaso_ImpPrincipal.Name = "txtDcaso_ImpPrincipal";
            this.txtDcaso_ImpPrincipal.Size = new System.Drawing.Size(245, 27);
            this.txtDcaso_ImpPrincipal.TabIndex = 15;
            this.txtDcaso_ImpPrincipal.TextChanged += new System.EventHandler(this.txtDcaso_ImpPrincipal_TextChanged);
            this.txtDcaso_ImpPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDcaso_ImpPrincipal_KeyPress);
            // 
            // txtDP_ImpPrincipal
            // 
            this.txtDP_ImpPrincipal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDP_ImpPrincipal.Location = new System.Drawing.Point(4, 42);
            this.txtDP_ImpPrincipal.Name = "txtDP_ImpPrincipal";
            this.txtDP_ImpPrincipal.Size = new System.Drawing.Size(157, 27);
            this.txtDP_ImpPrincipal.TabIndex = 25;
            this.txtDP_ImpPrincipal.TextChanged += new System.EventHandler(this.txtDP_ImpPrincipal_TextChanged);
            this.txtDP_ImpPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDP_ImpPrincipal_KeyPress);
            // 
            // txtDproceso_ImpPrincipal
            // 
            this.txtDproceso_ImpPrincipal.Location = new System.Drawing.Point(369, 90);
            this.txtDproceso_ImpPrincipal.Name = "txtDproceso_ImpPrincipal";
            this.txtDproceso_ImpPrincipal.Size = new System.Drawing.Size(261, 27);
            this.txtDproceso_ImpPrincipal.TabIndex = 17;
            this.txtDproceso_ImpPrincipal.TextChanged += new System.EventHandler(this.txtDproceso_ImpPrincipal_TextChanged);
            this.txtDproceso_ImpPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDproceso_ImpPrincipal_KeyPress);
            // 
            // txtTribunal_ImpPrincipal
            // 
            this.txtTribunal_ImpPrincipal.Location = new System.Drawing.Point(276, 38);
            this.txtTribunal_ImpPrincipal.Name = "txtTribunal_ImpPrincipal";
            this.txtTribunal_ImpPrincipal.Size = new System.Drawing.Size(215, 27);
            this.txtTribunal_ImpPrincipal.TabIndex = 21;
            this.txtTribunal_ImpPrincipal.TextChanged += new System.EventHandler(this.txtTribunal_ImpPrincipal_TextChanged);
            this.txtTribunal_ImpPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTribunal_ImpPrincipal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 19;
            // 
            // lblLimpiar
            // 
            this.lblLimpiar.AutoSize = true;
            this.lblLimpiar.BackColor = System.Drawing.Color.Blue;
            this.lblLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpiar.Location = new System.Drawing.Point(146, 257);
            this.lblLimpiar.Name = "lblLimpiar";
            this.lblLimpiar.Size = new System.Drawing.Size(67, 19);
            this.lblLimpiar.TabIndex = 27;
            this.lblLimpiar.Text = "Limpiar";
            this.lblLimpiar.Click += new System.EventHandler(this.lblLimpiar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiguiente.Location = new System.Drawing.Point(514, 454);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(228, 44);
            this.btnSiguiente.TabIndex = 26;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.button5_Click);
            // 
            // ImputadosPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 609);
            this.Controls.Add(this.PanelImputadoPrincipal);
            this.DoubleBuffered = true;
            this.Name = "ImputadosPrincipal";
            this.Text = "ImputadosPrincipal";
            this.Load += new System.EventHandler(this.ImputadosPrincipal_Load);
            this.PanelImputadoPrincipal.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.gbImputado.ResumeLayout(false);
            this.gbImputado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIMPp)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReferencia_ImpPrincipal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDcaso_ImpPrincipal;
        private System.Windows.Forms.TextBox txtDP_ImpPrincipal;
        private System.Windows.Forms.TextBox txtDproceso_ImpPrincipal;
        private System.Windows.Forms.TextBox txtTribunal_ImpPrincipal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton rdFemenino;
        private System.Windows.Forms.RadioButton rdMasculino;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditarInfo;
        private System.Windows.Forms.Label lblLimpiar;
        private System.Windows.Forms.Label lblDPinformacion;
        private System.Windows.Forms.Label lblDP;
        private System.Windows.Forms.ComboBox ComboAño;
        private GradientPanel PanelImputadoPrincipal;
        private System.Windows.Forms.DataGridView DataGridViewIMPp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbImputado;
    }
}