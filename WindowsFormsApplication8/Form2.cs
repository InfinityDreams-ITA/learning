using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class exit : Form
    {
        public exit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//NO
        {
            if (checkBox1.Checked)
            {
                Settings1.Default.exit_true = true;
                Settings1.Default.Save();
            }
            DialogResult = DialogResult.Cancel;
            
        }

        private void button2_Click(object sender, EventArgs e)//SI
        {
            if (checkBox1.Checked)
            {
                Settings1.Default.exit_true = true;
                Settings1.Default.Save();
            }
            DialogResult = DialogResult.OK;
        }

        #region Gestione movimento form senza bordi

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        #endregion

        #region Gestione bordi buttons modali
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            SI.FlatAppearance.BorderSize = 1;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            SI.FlatAppearance.BorderSize = 0;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            NO.FlatAppearance.BorderSize = 1;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            NO.FlatAppearance.BorderSize = 0;
        }


        #endregion

        #region Aggiornamento generico dei colori del controllo
        public void UpdateColorControls(Control mc, Form frm)
        {
            if (mc is Button)
            {
                Button b = (Button)mc;
                if ((string)mc.Tag == "1")//se il tag vale 1 il programma aggiorna sia bordi che testo
                {
                    b.ForeColor = Settings1.Default.main_color;
                    b.FlatAppearance.BorderColor = Settings1.Default.main_color;
                }
                else
                {
                    if ((string)mc.Tag == "2")//Se il tag vale 2 aggiorno solo il bordo
                    {
                        b.FlatAppearance.BorderColor = Settings1.Default.main_color;
                    }
                }
            }
            if (mc is DataGridView)
            {
                DataGridView d = (DataGridView)mc;
                d.DefaultCellStyle.BackColor = Settings1.Default.back_color;
                d.DefaultCellStyle.ForeColor = Settings1.Default.main_color;
                d.GridColor = Settings1.Default.main_color;
            }
            if (mc is Label)
            {
                mc.ForeColor = Settings1.Default.main_color;
            }
            if (mc is ComboBox)
            {
                mc.ForeColor = Settings1.Default.main_color;
                mc.BackColor = Settings1.Default.back_color;
            }
            if (mc is TextBox)
            {
                mc.ForeColor = Settings1.Default.main_color;
                mc.BackColor = Settings1.Default.back_color;
            }
            if (mc is CheckBox)
            {
                mc.ForeColor = Settings1.Default.main_color;
            }
            frm.BackColor = Settings1.Default.back_color;
            foreach (Control subC in mc.Controls)
            {
                UpdateColorControls(subC, frm);
            }
        }
        #endregion

        private void exit_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                UpdateColorControls(c, this);
            }
        }
    }
}
