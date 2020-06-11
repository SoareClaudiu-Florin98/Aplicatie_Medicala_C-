using _1056_Soare_Claudiu_Florin_Proiect.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1056_Soare_Claudiu_Florin_Proiect.Forms
{
    public partial class FormPacienti : Form
    {
        List<Pacient> listaPacienti = new List<Pacient>();

        FormListaPacienti fCopil;
        public FormPacienti()
        {
            InitializeComponent();
            fCopil = new FormListaPacienti(listaPacienti);
            fCopil.MdiParent = this;
            fCopil.Text = "Fereastra centralizatoare";
            fCopil.Show();
            //adaugare a functiei incarca lista sa ruleze pe functia lista modificata
            this.ListaModificata += fCopil.IncarcaLista ;
            
        }
        public event EventHandler ListaModificata;
        public virtual void OnListaModificata(EventArgs e)
        {
            ListaModificata?.Invoke(this, e);
        }
        //prototip de Event Handler
        public delegate void ListaModificataEventHandler(object sender, EventArgs e);

        private void fereastraNouaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdaugaPacient fcopil = new FormAdaugaPacient(listaPacienti);
            fcopil.MdiParent = this;
            fcopil.Show();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void ștergeListăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaPacienti.Clear();
            OnListaModificata(EventArgs.Empty);

        }

        private void printListaPacienti_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            FontFamily fontFamily = new FontFamily("Georgia");
            Font font = new Font(fontFamily,30, FontStyle.Regular, GraphicsUnit.Pixel);
            int miscareY = 200;
            int miscareX = 50;
            g.DrawString("Id", font, new SolidBrush(Color.Green), e.MarginBounds.X + miscareX, e.MarginBounds.Y + miscareY - 50);
            g.DrawString("Nume", font, new SolidBrush(Color.Green), e.MarginBounds.X + miscareX + 150, e.MarginBounds.Y + miscareY - 50);
            g.DrawString("Varsta", font, new SolidBrush(Color.Green), e.MarginBounds.X + miscareX + 300, e.MarginBounds.Y + miscareY - 50);
            g.DrawString("Medic", font, new SolidBrush(Color.Green), e.MarginBounds.X + miscareX + 450, e.MarginBounds.Y + miscareY - 50);
            foreach(Pacient i in listaPacienti)
            {

                g.DrawString(i.Id.ToString(), font, new SolidBrush(Color.Black), e.MarginBounds.X + miscareX, e.MarginBounds.Y + miscareY + 50);
                g.DrawString(i.Nume, font, new SolidBrush(Color.Black), e.MarginBounds.X+150 + miscareX, e.MarginBounds.Y + miscareY + 50);
                g.DrawString(i.VarstaPacient.ToString(), font, new SolidBrush(Color.Black), e.MarginBounds.X+300 + miscareX, e.MarginBounds.Y + miscareY + 50);
                g.DrawString(i.NumeMedic, font, new SolidBrush(Color.Black), e.MarginBounds.X+450 + miscareX, e.MarginBounds.Y + miscareY + 50);
                miscareX = 50;
                miscareY += 50;
            }



        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialogListaPacienti.ShowDialog(); 
        }

        private void printDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printListaPacienti.Print(); 
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printPreviewDialogListaPacienti_Load(object sender, EventArgs e)
        {

        }

        private void printDoc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printListaPacienti.Print(); 
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form grafic = new FormGrafic(listaPacienti) ;
            grafic.ShowDialog();  
        }
    }
}
