using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class color : Form
    {
        start rif;
        preview form4;
        public Color main;
        public Color back;
        public color(start form1)
        {
            InitializeComponent();
            main = Settings1.Default.main_color;
            back = Settings1.Default.back_color;
            rif = form1;
        }

        #region Funzione IsOpen, verifica se un form è aperto

        public bool IsOpen(string formname)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == formname)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Gestione movimento form senza bordi

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void color_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void color_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void color_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }


        #endregion

        private void button3_Click(object sender, EventArgs e)//anteprima
        {

            if (!IsOpen("preview"))
            {
                preview test = new preview(this);
                form4 = test;
                test.BackColor = back;
                test.label1.ForeColor = main;
                test.button1.FlatAppearance.BorderColor = main;
                test.Show(); 
            }
            else
            {
                form4.Focus();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//salvataggio temporaneo dei colori
        {
            switch(comboBox1.Text)
            {
                case "Rossiccio - Nero":
                    main = Color.Maroon;
                    back = Color.Black;
                    break;
                case "Arancione - Blu":
                    main = Color.FromArgb(255,255, 128, 0);//arancione
                    back = Color.FromArgb(255, 0, 51, 102);//bluastro
                    break;
            }
            Settings1.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)//close
        {
            Dispose();
        }

        private void apply_Click(object sender, EventArgs e)//pulsante applica
        {
            Settings1.Default.main_color = main;//aggiornamento dei colori
            Settings1.Default.back_color = back;
            Settings1.Default.Save();

            #region Form1
            if (IsOpen("start"))
            {
                start i = (start)Application.OpenForms["start"];
                foreach (Control c in i.Controls)
                {
                    UpdateColorControls(c, i);
                }
            }
            #endregion//aggiorno i colori per tutti i form

            #region Form3
            
            foreach (Control c in Controls)
            {
                UpdateColorControls(c, this);
            }            

            #endregion

            #region Form4

            if (IsOpen("preview"))
            {
                preview i = (preview)Application.OpenForms["preview"];
                foreach (Control c in i.Controls)
                {
                    UpdateColorControls(c, i);
                } 
            }

            #endregion

            #region Form2

            if (IsOpen("exit"))
            {
                exit i = (exit)Application.OpenForms["exit"];
                foreach (Control c in i.Controls)
                {
                    UpdateColorControls(c, i);
                }
            }

            #endregion

        }

        #region Aggiornamento generico dei colori del controllo
        public void UpdateColorControls(Control mc, Form frm)
        {
            if (mc is Button)
            {
                Button b = (Button)mc;
                if((string)mc.Tag == "1")//se il tag vale 1 il programma aggiorna sia bordi che testo
                {
                    b.ForeColor = Settings1.Default.main_color;
                    b.FlatAppearance.BorderColor = Settings1.Default.main_color;
                }
                else
                {
                    if((string)mc.Tag == "2")//Se il tag vale 2 aggiorno solo il bordo
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
                d.BackgroundColor = Settings1.Default.back_color;
                d.RowsDefaultCellStyle.BackColor = Settings1.Default.back_color;
                d.RowsDefaultCellStyle.ForeColor = Settings1.Default.main_color;
                d.DefaultCellStyle.SelectionForeColor = Settings1.Default.main_color;
                d.RowHeadersDefaultCellStyle.ForeColor = Settings1.Default.main_color;
                d.RowHeadersDefaultCellStyle.SelectionForeColor = Settings1.Default.main_color;
            }
            if (mc is Label)
            {
                mc.ForeColor = Settings1.Default.main_color;
            }
            if(mc is ComboBox)
            {
                mc.ForeColor = Settings1.Default.main_color;
                mc.BackColor = Settings1.Default.back_color;
            }
            if (mc is TextBox)
            {
                mc.ForeColor = Settings1.Default.main_color;
                mc.BackColor = Settings1.Default.back_color;
            }
            if(mc is CheckBox)
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

        private void button4_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                main = colorDialog1.Color;               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                back = colorDialog1.Color;
            }
        }

        private void color_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                UpdateColorControls(c, this);
            }
        }
    }
}
