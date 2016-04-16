namespace WindowsFormsApplication8
{
    partial class start
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnX = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.bck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.help = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.lblF = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.Transparent;
            this.animator1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.animator1.DefaultAnimation = animation2;
            this.animator1.Interval = 50;
            this.animator1.MaxAnimationTime = 15000;
            this.animator1.AnimationCompleted += new System.EventHandler<AnimatorNS.AnimationCompletedEventArg>(this.animator1_AnimationCompleted);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.label1.Location = new System.Drawing.Point(272, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Diary ++ : tutto a portata di mano.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label2, AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.label2.Location = new System.Drawing.Point(312, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Benvenuto. Come ti chiami ?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animator1.SetDecoration(this.textBox1, AnimatorNS.DecorationType.None);
            this.textBox1.Font = new System.Drawing.Font("Kristen ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.textBox1.Location = new System.Drawing.Point(369, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnX.BackgroundImage")));
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.animator1.SetDecoration(this.btnX, AnimatorNS.DecorationType.None);
            this.btnX.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.Transparent;
            this.btnX.Location = new System.Drawing.Point(947, 12);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(36, 32);
            this.btnX.TabIndex = 9;
            this.btnX.Tag = "2";
            this.btnX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tip.SetToolTip(this.btnX, "Chiudi");
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Visible = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.Transparent;
            this.btnR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnR.BackgroundImage")));
            this.btnR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.animator1.SetDecoration(this.btnR, AnimatorNS.DecorationType.None);
            this.btnR.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.ForeColor = System.Drawing.Color.Transparent;
            this.btnR.Location = new System.Drawing.Point(905, 12);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(36, 32);
            this.btnR.TabIndex = 10;
            this.btnR.Tag = "2";
            this.btnR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tip.SetToolTip(this.btnR, "Riduci ad icona");
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Visible = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Transparent;
            this.OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OK.BackgroundImage")));
            this.OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.animator1.SetDecoration(this.OK, AnimatorNS.DecorationType.None);
            this.OK.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.OK.FlatAppearance.BorderSize = 0;
            this.OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.ForeColor = System.Drawing.Color.Transparent;
            this.OK.Location = new System.Drawing.Point(455, 292);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(87, 68);
            this.OK.TabIndex = 12;
            this.OK.Tag = "2";
            this.OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tip.SetToolTip(this.OK, "Ok");
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Visible = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // bck
            // 
            this.bck.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bck, AnimatorNS.DecorationType.None);
            this.bck.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bck.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.bck.Location = new System.Drawing.Point(818, 337);
            this.bck.Name = "bck";
            this.bck.Size = new System.Drawing.Size(165, 23);
            this.bck.TabIndex = 13;
            this.bck.Tag = "1";
            this.bck.Text = "MODIFICA COLORE SFONDO";
            this.tip.SetToolTip(this.bck, "Colore di sfondo");
            this.bck.UseVisualStyleBackColor = false;
            this.bck.Visible = false;
            this.bck.Click += new System.EventHandler(this.bck_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label3, AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.label3.Location = new System.Drawing.Point(639, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "I colori non ti piacciono ?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label4, AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.label4.Location = new System.Drawing.Point(14, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "La tua settimana :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.help);
            this.panel1.Controls.Add(this.btnload);
            this.panel1.Controls.Add(this.lblF);
            this.panel1.Controls.Add(this.lblC);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnR);
            this.panel1.Controls.Add(this.bck);
            this.panel1.Controls.Add(this.OK);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.animator1.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 376);
            this.panel1.TabIndex = 19;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.help, AnimatorNS.DecorationType.None);
            this.help.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.help.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.help.Location = new System.Drawing.Point(11, 341);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(24, 23);
            this.help.TabIndex = 34;
            this.help.Tag = "1";
            this.help.Text = "?";
            this.tip.SetToolTip(this.help, "Colore di sfondo");
            this.help.UseVisualStyleBackColor = false;
            this.help.Visible = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.btnload, AnimatorNS.DecorationType.None);
            this.btnload.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnload.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnload.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.btnload.Location = new System.Drawing.Point(59, 298);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(125, 23);
            this.btnload.TabIndex = 33;
            this.btnload.Tag = "1";
            this.btnload.Text = "CARICA SETTIMANA";
            this.tip.SetToolTip(this.btnload, "Colore di sfondo");
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Visible = false;
            this.btnload.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lblF
            // 
            this.lblF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblF.AutoSize = true;
            this.lblF.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblF, AnimatorNS.DecorationType.None);
            this.lblF.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.lblF.Location = new System.Drawing.Point(473, 355);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(50, 16);
            this.lblF.TabIndex = 32;
            this.lblF.Text = "Chiudi";
            this.lblF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblF.Visible = false;
            // 
            // lblC
            // 
            this.lblC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblC, AnimatorNS.DecorationType.None);
            this.lblC.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.lblC.Location = new System.Drawing.Point(464, 355);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(67, 16);
            this.lblC.TabIndex = 31;
            this.lblC.Text = "Continua";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.animator1.SetDecoration(this.checkBox1, AnimatorNS.DecorationType.None);
            this.checkBox1.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.Maroon;
            this.checkBox1.Location = new System.Drawing.Point(836, 298);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 20);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Nascondi il sabato";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lun,
            this.mar,
            this.mer,
            this.gio,
            this.ven,
            this.sab});
            this.animator1.SetDecoration(this.dataGridView1, AnimatorNS.DecorationType.None);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView1.Location = new System.Drawing.Point(20, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(961, 223);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 19;
            this.tip.SetToolTip(this.dataGridView1, "La tua settimana");
            this.dataGridView1.Visible = false;
            // 
            // lun
            // 
            this.lun.HeaderText = "Lunedi";
            this.lun.Name = "lun";
            // 
            // mar
            // 
            this.mar.HeaderText = "Martedi";
            this.mar.Name = "mar";
            // 
            // mer
            // 
            this.mer.HeaderText = "Mercoledi";
            this.mer.Name = "mer";
            // 
            // gio
            // 
            this.gio.HeaderText = "Giovedi";
            this.gio.Name = "gio";
            // 
            // ven
            // 
            this.ven.HeaderText = "Venerdi";
            this.ven.Name = "ven";
            // 
            // sab
            // 
            this.sab.HeaderText = "Sabato";
            this.sab.Name = "sab";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label13, AnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.label13.Location = new System.Drawing.Point(206, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(584, 33);
            this.label13.TabIndex = 29;
            this.label13.Text = "Ok, qui abbiamo finito, possiamo cominciare!";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label14, AnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.label14.Location = new System.Drawing.Point(172, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(652, 27);
            this.label14.TabIndex = 30;
            this.label14.Text = "Potrai personalizzare il tuo programma ulteriormente più tardi.";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Visible = false;
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.Black;
            this.tip.ForeColor = System.Drawing.Color.Maroon;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = global::WindowsFormsApplication8.Settings1.Default.back_color;
            this.ClientSize = new System.Drawing.Size(998, 376);
            this.Controls.Add(this.panel1);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AnimatorNS.Animator animator1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ToolTip tip;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button bck;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnX;
        public System.Windows.Forms.Button btnR;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lblC;
        public System.Windows.Forms.Label lblF;
        public System.Windows.Forms.Button btnload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lun;
        private System.Windows.Forms.DataGridViewTextBoxColumn mar;
        private System.Windows.Forms.DataGridViewTextBoxColumn mer;
        private System.Windows.Forms.DataGridViewTextBoxColumn gio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven;
        private System.Windows.Forms.DataGridViewTextBoxColumn sab;
        public System.Windows.Forms.Button help;
    }
}

