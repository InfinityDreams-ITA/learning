using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class preview : Form
    {
        color form3;
        public preview(color form)
        {
            InitializeComponent();
            form3 = form;
        }

        private void preview_Load(object sender, EventArgs e)
        {
            BackColor = form3.back;
            label1.ForeColor = form3.main;
        }

        #region Gestione movimento form senza bordi

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void preview_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void preview_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void preview_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        #endregion

        private void btnX_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
