using System.Drawing;
using System.Windows.Forms;
using AnimatorNS;
using System;
using System.Data;
using System.IO;
using System.Xml;

namespace WindowsFormsApplication8
{

    public partial class start : Form
    {    
           
        color rif;
        private int value=1;//gestisce le animazioni
        private bool skip = true; //controlla e stoppa le animazioni
        public start()
        {
            InitializeComponent();
        }

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
                d.BackgroundColor = Settings1.Default.back_color;
                d.RowsDefaultCellStyle.BackColor = Settings1.Default.back_color;
                d.DefaultCellStyle.SelectionForeColor = Settings1.Default.main_color;
                d.RowsDefaultCellStyle.ForeColor = Settings1.Default.main_color;
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
            if(mc is TextBox)
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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        #endregion

        private void animator1_AnimationCompleted(object sender, AnimationCompletedEventArg e)//gestisce tutte le animazioni di tutti gli step (normalmente show)
        {
            if (skip)//controllo sulla generazione degli eventi
            {
                switch (value)
                {
                    case 1://testo centrale e niente pulsanti                    
                        System.Threading.Thread.Sleep(1500);                       
                        value++;
                        animator1.Hide(label1);                       
                        break;
                    case 2://inserimento nome
                        animator1.Interval = 13;
                        animator1.Show(label2);//visualizzo tutti i controlli dello step 2   
                        animator1.Show(textBox1);
                        animator1.Show(lblC);
                        animator1.Show(OK);
                        animator1.Show(btnX);
                        animator1.Show(btnR);
                        animator1.Show(label3);
                        animator1.Show(bck);
                        skip = false;
                        break;
                    case 3://inserimento materie e info generali
                        animator1.Show(label4);//visualizzo tutti i controlli dello step 3                                
                        animator1.Show(dataGridView1);
                        animator1.Show(checkBox1);
                        animator1.Show(btnload);
                        skip = false;                        
                        break;
                    case 4://saluti vari e personalizzazione
                        animator1.Hide(btnload);//nascondo tutti i controlli dello step 3 (datagrid)
                        animator1.Hide(bck);
                        animator1.Hide(checkBox1);
                        animator1.Hide(dataGridView1);                                                                     
                        animator1.Hide(label4);
                        animator1.Hide(lblC);
                        skip = false;
                        //-----------Fine step 3------------//
                        //-----------Inzio step finale------------// 
                        animator1.Show(lblF);                                             
                        animator1.Show(label13);
                        animator1.Show(label14);
                        //System.Threading.Thread.Sleep(1500);
                        skip = false;

                        //Close();

                        break;
                }//end switch
            }//end skip
                     
        }

        private void Form1_Load(object sender, EventArgs e)//load del form, con settaggio di tutti i colori e load del datagrid
        {
            foreach (Control c in Controls)//aggiorno i colori di tutto lo sfondo
            {
                UpdateColorControls(c, this);
            }
            for (int i = 0; i < 8; i++)//imposto il datagrid dello step 3
            {
                dataGridView1.Rows.Add();
            }         
            for(int i=0; i < dataGridView1.Rows.Count; i++)//inizializzo tutte le celle del datagrid a una stringa vuota
            {
                for(int j=0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = " ";
                }
            }
            for(int i=0; i < dataGridView1.Rows.Count; i++)//testi degli header di riga
            {
                dataGridView1.Rows[i].HeaderCell.Value = i + 1 + " ora";
            }



            dataGridView1.Columns["sab"].Visible = true;
            animator1.Show(label1);//inizio la visualizzazione dello step 1            
        }

        private void btnX_Click(object sender, EventArgs e)//chiede se si vuole chiudere il form
        {

            if (!Settings1.Default.exit_true)//definisce il "non mostrare più"
            {
                if (!IsOpen("close"))
                {
                    exit dialog = new exit();//form di uscita
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Dispose();
                    }
                }               
            }
            else
            {
                Dispose();
                
            }
        }

        #region Imposto un dataset con i valori del datagrid
        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add();
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        } 
        #endregion

        private void btnR_Click(object sender, System.EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void OK_Click(object sender, System.EventArgs e)//pulsante continua
        {
            if (value == 2)//se arriva a 2 -> modifica settimana se a 3 -> saluti
            {
                skip = true;
                value++;
                    Settings1.Default.name = textBox1.Text;             
                    animator1.Hide(label2);//hide controlli step 2
                    animator1.Hide(textBox1); 
                //-----------Fine step 2------------//
            }
            else
            {
                if (value == 3)
                {
                    DataTable dT = GetDataTableFromDGV(dataGridView1);
                    dT.Columns["Column1"].ColumnName = "Lunedi";
                    dT.Columns["Column2"].ColumnName = "Martedi'";
                    dT.Columns["Column3"].ColumnName = "Mercoledi'";
                    dT.Columns["Column4"].ColumnName = "Giovedi'";
                    dT.Columns["Column5"].ColumnName = "Venerdi'";
                    dT.Columns["Column6"].ColumnName = "Sabato";
                    DataSet dS = new DataSet();
                    dS.Tables.Add(dT);
                    dS.WriteXml(File.OpenWrite("xml" + Settings1.Default.test.ToString() + ".xml"));
                    Settings1.Default.test++;
                    Settings1.Default.Save();


                    //Settings1.Default.settimana.AddRange();
                    Console.Write(Settings1.Default.settimana);

                    skip = true;//inizio hide dei controlli dello step 3
                    value++;
                    animator1.Hide(label3);
                }
                else
                {
                    if(value == 4)//quando si clicca dopo le ultime label
                    {
                        Dispose();
                    }
                }
            } 
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)//invio nella textbox
        {
            if(e.KeyCode == Keys.Enter)
            {
                OK_Click(OK,e);
            }
        }

        private void bck_Click(object sender, EventArgs e)//pulsante modifica colore
        {
            if(!IsOpen("color"))
            {
                color colore = new color(this);
                rif = colore;
                colore.Show();
            }
            else
            {
                rif.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)//riduci a icona
        {
            WindowState = FormWindowState.Maximized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//nascondo il sabato ***** 
        {
            if(checkBox1.Checked)
            {
                if (dataGridView1.Columns["sab"] != null)
                {
                    dataGridView1.Columns["sab"].Visible = false; 
                }
            }
            else
            {
                dataGridView1.Columns["sab"].Visible = true;
            }
        } 

        private void button1_Click_2(object sender, EventArgs e)//carica settimana, carica l'xml nel datagrid *****
        {
            XmlReader xml;
            DataSet ds = new DataSet();
            openFileDialog1.FileName = "Seleziona ...";       
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xml = XmlReader.Create(openFileDialog1.FileName, new XmlReaderSettings());
                ds.ReadXml(xml);
                dataGridView1.Columns.Clear();                
                dataGridView1.DataSource = ds.Tables[0];
                for (int i = 0; i < dataGridView1.Rows.Count; i++)//testi degli header di riga
                {
                    dataGridView1.Rows[i].HeaderCell.Value = i + 1 + " ora";
                }
                checkBox1.Enabled = false;          
            }                        
        }

        private void help_Click(object sender, EventArgs e)
        {

        }
    }
}
