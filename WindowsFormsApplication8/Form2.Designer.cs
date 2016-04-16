namespace WindowsFormsApplication8
{
    partial class exit
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
            this.label1 = new System.Windows.Forms.Label();
            this.NO = new System.Windows.Forms.Button();
            this.SI = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vuoi veramente uscire?";
            // 
            // NO
            // 
            this.NO.BackColor = System.Drawing.Color.Transparent;
            this.NO.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.NO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NO.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.NO.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.NO.Location = new System.Drawing.Point(232, 41);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(46, 23);
            this.NO.TabIndex = 2;
            this.NO.Tag = "1";
            this.NO.Text = "NO";
            this.NO.UseVisualStyleBackColor = false;
            this.NO.Click += new System.EventHandler(this.button1_Click);
            this.NO.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.NO.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // SI
            // 
            this.SI.BackColor = System.Drawing.Color.Transparent;
            this.SI.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.SI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SI.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.SI.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.SI.Location = new System.Drawing.Point(193, 41);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(33, 23);
            this.SI.TabIndex = 1;
            this.SI.Tag = "1";
            this.SI.Text = "SI";
            this.SI.UseVisualStyleBackColor = false;
            this.SI.Click += new System.EventHandler(this.button2_Click);
            this.SI.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.SI.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = global::WindowsFormsApplication8.Settings1.Default.main_color;
            this.checkBox1.Location = new System.Drawing.Point(8, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Non mostrare più";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NO);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.SI);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 76);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            // 
            // exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::WindowsFormsApplication8.Settings1.Default.back_color;
            this.ClientSize = new System.Drawing.Size(295, 76);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.exit_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NO;
        private System.Windows.Forms.Button SI;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
    }
}