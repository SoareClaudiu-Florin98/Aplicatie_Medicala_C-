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
    public partial class FormListaPacienti : Form
    {
        List<Pacient> listaPacienti; 
        public FormListaPacienti(List<Pacient> listaPacienti )
        { 

            InitializeComponent();
            this.listaPacienti = listaPacienti;
        }

        private void AdaugaPacient(Pacient p)
        {
            ListViewItem lvi = new ListViewItem(p.Id.ToString());
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, p.Nume));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, p.VarstaPacient.ToString()));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, p.NumeMedic));
            lvi.Tag = p;
            listView1.Items.Add(lvi);
        }
        public void IncarcaLista(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Pacient p in listaPacienti)
            {
                AdaugaPacient(p);
            }


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ștergeElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];  //SelectedItems[0];
                int poz = itm.Index;
                listView1.Items.Remove(itm); listView1.Refresh();
                Pacient p = listaPacienti[poz];
                listaPacienti.Remove(p); 
               
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Refresh(); 
        }
    }

}
