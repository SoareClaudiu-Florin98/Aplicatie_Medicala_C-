using _1056_Soare_Claudiu_Florin_Proiect.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1056_Soare_Claudiu_Florin_Proiect.Forms
{
    public partial class FormMedic : Form
    {
        List<Medic> medics = new List<Medic>(); 
  
        public FormMedic()
        {

           InitializeComponent();
            //deserializare
            if (File.Exists("Medici.dat"))
            {
                FileStream fis1 = new FileStream("Medici.dat", FileMode.Open);
                BinaryFormatter f1 = new BinaryFormatter();
                medics = (List<Medic>)f1.Deserialize(fis1);
                fis1.Close();
                foreach (Medic i in medics)
                {
                    AdaugaMedic(i);
                }
            }
        }

        
        private void buttonAdaugaM_Click(object sender, EventArgs e)
        {

            Medic m = new Medic("", "", 0);
            m.Nume = textBoxNumeM.Text;
            m.Clinica = comboBoxClinicaM.Text;
            bool adauga = true; 
            try
            {
                m.Varsta = Convert.ToInt32(textBoxVarstaM.Text); 
            }
            catch
            {
                adauga = false;
                MessageBox.Show("Varsta nu poate  contine litere! ", "Mesaj", MessageBoxButtons.OK);

            }
            if(m.Varsta <1 || m.Varsta > 125)
            {
                MessageBox.Show("Varsta trebuie sa fie intre 1 si 125 de ani!  ", "Mesaj", MessageBoxButtons.OK);
                adauga = false; 
            }
            if (m.Nume.Length < 1)
            {
                MessageBox.Show("Introduceti un nume !", "Mesaj", MessageBoxButtons.OK);
                adauga = false; 

            }
            if(m.Nume.Length >30 )
            {
                MessageBox.Show("Numele este prea lung !", "Mesaj", MessageBoxButtons.OK);
                adauga = false;
            }
            bool avemNumere = m.Nume.Any(char.IsDigit);
            if (avemNumere)
            {
                MessageBox.Show("Numele nu poate contine numere !", "Mesaj", MessageBoxButtons.OK);
                adauga = false;
            }
            if(comboBoxClinicaM.SelectedIndex<0)
            {
                MessageBox.Show("Selectati clinica!", "Mesaj", MessageBoxButtons.OK);
                adauga = false;

            }

            if (adauga)
            {
                AdaugaMedic(m);
                medics.Add(m);

                textBoxNumeM.Clear();
                comboBoxClinicaM.Text = String.Empty;
                textBoxVarstaM.Clear();


            }
            //serializare
            FileStream fis = new FileStream("Medici.dat", FileMode.Create);
            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(fis, medics); 
            fis.Close();

        }
        private void AdaugaMedic(Medic m)
        {
            ListViewItem lvMedic = new ListViewItem(m.Nume);
            lvMedic.SubItems.Add(new ListViewItem.ListViewSubItem(lvMedic,m.Clinica));
            lvMedic.SubItems.Add(new ListViewItem.ListViewSubItem(lvMedic,m.Varsta.ToString()));
            lvMedic.Tag = m;
            listViewMedici.Items.Add(lvMedic); 


        }

        private void textBoxNumeM_Validating(object sender, CancelEventArgs e)
        { 
            TextBox tblocal = (TextBox)sender;
            if (tblocal.Text.Length < 1)
            {
                errorProvider1.SetError(tblocal, "Introduceti un nume!");
            }
            else
            {
                errorProvider1.SetError(tblocal, "");
            }
        }

        private void textBoxNumeM_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxClinicaM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxClinicaM_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cbLocal = (ComboBox)sender;
            if (cbLocal.SelectedIndex < 0)
            {
                errorProvider1.SetError(cbLocal, "Selectati clinica!");
            }
            else
            {
                errorProvider1.SetError(cbLocal, "");
            }
        }

        private void textBoxVarstaM_Validating(object sender, CancelEventArgs e)
        {
            TextBox tbLocal = (TextBox)sender;
            bool suntDoarNumere = true;
            try
            {
                int varsta = Convert.ToInt32(tbLocal.Text); 
            }
            catch
            {
                errorProvider1.SetError(tbLocal, "Varsta nu poate contine litere");
                suntDoarNumere = false;  
            }
            if (suntDoarNumere)
            {
                errorProvider1.SetError(tbLocal, "");
            }
        }

        private void listViewMedici_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMedic_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("Medici.dat"))
            {
                File.Delete("Medici.dat");
                listViewMedici.Items.Clear();
                medics.Clear();

            }
            else
            {
                MessageBox.Show("Lista este goală!", "Mesaj", MessageBoxButtons.OK);
            }

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewMedici.Refresh(); 
        }

        private void ștergeElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewMedici.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewMedici.SelectedItems[0];  //listviewMedic.SelectedItems[0];
                int pozitie = item.Index;
                listViewMedici.Items.Remove(item);
                listViewMedici.Refresh();
                Medic m = medics[pozitie];
                medics.Remove(m);
                if (File.Exists("Medici.dat"))
                {
                    File.Delete("Medici.dat");

                    FileStream fis = new FileStream("Medici.dat", FileMode.Create);
                    BinaryFormatter f = new BinaryFormatter();
                    f.Serialize(fis, medics);
                    fis.Close();



                }

            }
        }

        private void contextMenuStripMedici_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
