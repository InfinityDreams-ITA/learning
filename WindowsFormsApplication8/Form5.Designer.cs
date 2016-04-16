namespace WindowsFormsApplication8
{
    partial class input
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
            this.SI = new System.Windows.Forms.Button();
            this.NO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SI
            // 
            this.SI.BackColor = System.Drawing.Color.Transparent;
            this.SI.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SI.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.SI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SI.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.SI.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.SI.Location = new System.Drawing.Point(307, 72);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(33, 23);
            this.SI.TabIndex = 4;
            this.SI.Text = "OK";
            this.SI.UseVisualStyleBackColor = false;
            this.SI.Click += new System.EventHandler(this.SI_Click);
            // 
            // NO
            // 
            this.NO.BackColor = System.Drawing.Color.Transparent;
            this.NO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NO.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.NO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NO.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.NO.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.NO.Location = new System.Drawing.Point(227, 72);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(74, 23);
            this.NO.TabIndex = 5;
            this.NO.Text = "ANNULLA";
            this.NO.UseVisualStyleBackColor = false;
            this.NO.Click += new System.EventHandler(this.NO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inserisci nuova materia :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Kristen ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.textBox1.Location = new System.Drawing.Point(18, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SI);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.NO);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 105);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.input_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.input_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.input_MouseUp);
            // 
            // input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(351, 105);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "input";
            this.Text = "Form5";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.input_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.input_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.input_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SI;
        private System.Windows.Forms.Button NO;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}