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

    public partial class FormAdaugaPacient : Form
    {
        //List<Medic> medics = new List<Medic>();
        Pacient P;
        List<Pacient> listaPacienti;
        List<Medic> medics = new List<Medic>();

        public FormAdaugaPacient(List<Pacient> listaPacienti)
        {
            P = new Pacient();


            InitializeComponent();
            this.listaPacienti = listaPacienti;
            this.PacientModificat += ActualizeazaFormular;
            if (File.Exists("Medici.dat"))
            {
                FileStream fis1 = new FileStream("Medici.dat", FileMode.Open);
                BinaryFormatter f1 = new BinaryFormatter();
                medics = (List<Medic>)f1.Deserialize(fis1);
                fis1.Close();
                foreach (Medic i in medics)
                {
                    comboBoxMedicP.Items.Add(i.Nume);
                }
            }

        }
        public event EventHandler PacientModificat;

        public virtual void OnPacientModificat(EventArgs e)
        {
            PacientModificat?.Invoke(this, e);
        }

        public delegate void PacientModificatEventHandler(object sender, EventArgs e);
        public void ActualizeazaFormular(object sender, EventArgs e)
        {   
            textBoxId.Text = P.Id.ToString();
            textBoxNumeP.Text = P.Nume;
            textBoxVarstaP.Text = P.VarstaPacient.ToString();
            comboBoxMedicP.Text = P.NumeMedic;
        }

        private void FormAdaugaPacient_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdaugaP_Click(object sender, EventArgs e)
        {
            P = new Pacient(); 
            P.Nume = textBoxNumeP.Text;
            P.NumeMedic = comboBoxMedicP.Text;
            bool ok = true;
            try
            {
                P.Id = Convert.ToInt32(textBoxId.Text);
                P.VarstaPacient = Convert.ToInt32(textBoxVarstaP.Text);
            }
            catch
            {
                MessageBox.Show("Eroare");
                ok = false;
            }
            if (P.VarstaPacient < 1 || P.VarstaPacient > 125)
            {
                MessageBox.Show("Varsta trebuie sa fie intre 1 si 125 de ani!  ", "Mesaj", MessageBoxButtons.OK);
                ok = false;
            }
            if (P.Nume.Length < 1)
            {
                MessageBox.Show("Introduceti un nume !", "Mesaj", MessageBoxButtons.OK);
                ok = false;

            }
            if (P.Nume.Length > 30)
            {
                MessageBox.Show("Numele este prea lung !", "Mesaj", MessageBoxButtons.OK);
                ok = false;
            }
            bool avemNumere = P.Nume.Any(char.IsDigit);
            if (avemNumere)
            {
                MessageBox.Show("Numele nu poate contine numere !", "Mesaj", MessageBoxButtons.OK);
                ok = false;
            }
            if (comboBoxMedicP.SelectedIndex < 0)
            {
                MessageBox.Show("Selectati medicul!", "Mesaj", MessageBoxButtons.OK);
                ok = false;

            }
            if (ok)
            {
                MessageBox.Show("Pacientul a fost adaugat in lista ! ");
                listaPacienti.Add(P);
                OnPacientModificat(EventArgs.Empty);
                ((FormPacienti)(this.MdiParent)).OnListaModificata(EventArgs.Empty);

                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }


        }

        private void buttonRenuntaP_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void textBoxId_Validating(object sender, CancelEventArgs e)
        {
            TextBox tbLocal = (TextBox)sender;

            bool suntDoarNumere = true;
            try
            {
                int idUl = Convert.ToInt32(tbLocal.Text);
            }
            catch
            {
                errorProvider1.SetError(tbLocal, "Id nu poate contine litere");
                suntDoarNumere = false;
            }
            if (suntDoarNumere)
            {
                errorProvider1.SetError(tbLocal, "");
            }

        }

        private void textBoxNumeP_Validating(object sender, CancelEventArgs e)
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
            bool avemNumere = tblocal.Text.Any(char.IsDigit);
            if (avemNumere)
            {
                errorProvider1.SetError(tblocal, "Numele nu poate contine cifre!");

            }

        }

        private void textBoxVarstaP_Validating(object sender, CancelEventArgs e)
        {
            TextBox tbLocal = (TextBox)sender;

            bool suntDoarNumere = true;
            try
            {
                int idUl = Convert.ToInt32(tbLocal.Text);
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

        private void comboBoxMedicP_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cbLocal = (ComboBox)sender;
            if (cbLocal.SelectedIndex < 0)
            {
                errorProvider1.SetError(cbLocal, "Selectati medicul!");
            }
            else
            {
                errorProvider1.SetError(cbLocal, "");
            }
        }

        private void labelNumeP_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBoxNumeP_TextChanged(object sender, EventArgs e)
        {

        }

        private void salveazaInFisierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.CheckPathExists = true;
            fd.Filter = "fisiere pacienti (*.pac)|*.pac";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream myfile = File.Create(fd.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                serializator.Serialize(myfile, this.P);
                myfile.Close();
            }
        }

        private void incarcaDinFisierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog filed = new OpenFileDialog();
            filed.CheckFileExists = true;
            filed.Filter = "fisiere pacienti (*.pac)|*.pac";
            if (filed.ShowDialog() == DialogResult.OK)
            {
                Stream myfile = File.OpenRead(filed.FileName);
                BinaryFormatter deserializator = new BinaryFormatter();
                P = new Pacient();
                P = (Pacient)deserializator.Deserialize(myfile);
                //listaPacienti.Add(P);
                OnPacientModificat(EventArgs.Empty);
            }


        }

        private void salveazaInFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog filed = new SaveFileDialog();
            // fd.CheckFileExists = true;
            filed.Filter = "Text files (*.txt)|*.txt";
            if (filed.ShowDialog() == DialogResult.OK)
            {
                FileStream files = new FileStream(filed.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter write = new StreamWriter(files);
                write.WriteLine(P.ToString());
                write.Close();
                files.Close();
            }

        }

        private void incarcaDinFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog filed = new OpenFileDialog();
            filed.Filter = "Text files (*.txt)|*.txt";
            if (filed.ShowDialog() == DialogResult.OK)
            {
                FileStream files = new FileStream(filed.FileName, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(files);
                //aici se face citirea
                string[] pers = read.ReadToEnd().Split(' ');
                P = new Pacient(Convert.ToInt32(pers[0]), pers[1], Convert.ToInt32(pers[2]), pers[3]);
                read.Close();
                files.Close();
                OnPacientModificat(EventArgs.Empty);
            }
        }
    }

}

