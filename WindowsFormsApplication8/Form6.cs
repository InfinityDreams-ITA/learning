using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class sub : Form
    {
        public sub()
        {
            InitializeComponent();
        }
        private bool insert = true;
        input mate;
        private void button1_Click(object sender, EventArgs e)//aggiungi
        {
            if (!IsOpen("input"))
            {
                input materia = new input();
                mate = materia;//riferimento della custom input box
                if (materia.ShowDialog() == DialogResult.OK)
                {
                    if (insert)
                    {
                        listBox1.Items.Clear();
                        insert = false;
                    }
                    listBox1.Items.Add(materia.textBox1.Text);
                }
                else
                {
                    materia.Close();
                }
            }
            else
            {
                mate.Focus();
            }
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

        private void sub_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void sub_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void sub_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)//rimuovi
        {
            if (insert != true)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add("Aggiungi materia ...");
                    insert = true;
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SI_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
