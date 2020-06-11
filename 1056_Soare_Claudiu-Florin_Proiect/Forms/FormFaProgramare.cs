using _1056_Soare_Claudiu_Florin_Proiect.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1056_Soare_Claudiu_Florin_Proiect.Forms
{
    public partial class FormFaProgramare : Form
    {
        private const string ConnectionString = "Data Source=DBProgramare.db";
        private readonly List<Programare> programari = new List<Programare>();
        private List<Medic> listaMedici;
        public FormFaProgramare()
        {
            InitializeComponent();
            if (File.Exists("Medici.dat"))
            {
                FileStream file = new FileStream("Medici.dat", FileMode.Open);
                BinaryFormatter f = new BinaryFormatter();
                listaMedici = (List<Medic>)f.Deserialize(file);
                file.Close();
                foreach (Medic i in listaMedici)
                {
                    comboBoxMediciBD.Items.Add(i.Nume); 
                }


            }
        }
        private void AfiseazaProgramari()
        {
            
            listViewBD.Items.Clear();

            foreach (Programare p in programari)
            {
                var listViewItem = new ListViewItem(p.NumePacient);
                listViewItem.SubItems.Add(p.Data.ToShortDateString());
                listViewItem.SubItems.Add(p.MedicP.Nume);
                listViewItem.SubItems.Add(p.Mail);
                listViewItem.SubItems.Add(p.NrTelefon);
                listViewItem.SubItems.Add(p.Specialitate);


                listViewItem.Tag = p;

                listViewBD.Items.Add(listViewItem);
            }
        }
        private void AddProgramare(Programare p)
        {
            var queryString = "insert into Programare( Data ,Medic ,Mail,Telefon,Specialitate,Pacient)" +
                                " values(@data,@medic,@mail,@telefon,@specialitate,@pacient);  " +
                                "SELECT last_insert_rowid()";

            SQLiteConnection connection = new SQLiteConnection(ConnectionString);

            connection.Open();
            SQLiteCommand command = new SQLiteCommand(queryString, connection);

            command.Parameters.AddWithValue("@data", p.Data);
            command.Parameters.AddWithValue("@medic", p.MedicP.Nume);
            command.Parameters.AddWithValue("@mail", p.Mail);
            command.Parameters.AddWithValue("@telefon", p.NrTelefon);
            command.Parameters.AddWithValue("@specialitate", p.Specialitate);
            command.Parameters.AddWithValue("@pacient", p.NumePacient);
            p.Id = Convert.ToInt32(command.ExecuteScalar());
            programari.Add(p);


        }

        private void buttonProgramare_Click(object sender, EventArgs e)
        {
            var Data = Convert.ToDateTime(dateTimePicker1.Text); 
            String medic = comboBoxMediciBD.Text;
            String mail = textBoxMail.Text;
            String nrTelefon = textBoxTelefon.Text;
            String specialitate = comboBoxSpecialitate.Text;
            String pacient = textBoxPacient.Text; 


            Programare p = new Programare(Data,new Medic(medic,"",0),mail,nrTelefon,specialitate,pacient,0);
            try
            {
                AddProgramare(p);
                AfiseazaProgramari();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoadProgramari()
        {
            const string stringSql = "SELECT * FROM Programare";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(stringSql, connection);

                SQLiteDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    int id = Convert.ToInt32(sqlReader["ID"]);
                    DateTime data = Convert.ToDateTime(sqlReader["Data"]);
                    String medic = (String)sqlReader["Medic"];

                    String mail = (String)sqlReader["Mail"];
                    String telefon = (String)sqlReader["Telefon"];
                    String specialitate = (String)sqlReader["Specialitate"];
                    String pacient = (String)sqlReader["Pacient"];

                    Programare p = new Programare(data,new Medic(medic,"",0),mail,telefon,specialitate,pacient,id);
                    programari.Add(p);
                }
            }
        }


        private void StergeRezervare(Programare p)
        {
            const string stringSql = "DELETE FROM Programare WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@id", p.Id);
                command.ExecuteNonQuery();
                programari.Remove(p);
            }
        }

        private void FormFaRezervare_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProgramari();
                AfiseazaProgramari(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void stergeProgramareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewBD.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alege o programare ");
                return;
            }

            if (MessageBox.Show("Esti sigur? ", "Sterge programarea", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ListViewItem selectedItem = listViewBD.SelectedItems[0];
                    Programare p = (Programare)selectedItem.Tag;

                    StergeRezervare(p);

                    AfiseazaProgramari();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxTelefon_Validating(object sender, CancelEventArgs e)
        {
            TextBox tbLocal = (TextBox)sender;

            bool suntDoarNumere = true;
            try
            {
                double nrTel = Convert.ToDouble(tbLocal.Text);
            }
            catch
            {
                errorProvider1.SetError(tbLocal, "Numarul de telefon  nu poate contine litere");
                suntDoarNumere = false;
            }
            if (suntDoarNumere)
            {
                errorProvider1.SetError(tbLocal, "");
            }
            if(tbLocal.TextLength!= 10)
            {
                errorProvider1.SetError(tbLocal, "Numarul de telefon contine 10 cifre! ");
            }
        }

        private void comboBoxMediciBD_Validating(object sender, CancelEventArgs e)
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

        private void comboBoxSpecialitate_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cbLocal = (ComboBox)sender;
            if (cbLocal.SelectedIndex < 0)
            {
                errorProvider1.SetError(cbLocal, "Selectati specialitatea!");
            }
            else
            {
                errorProvider1.SetError(cbLocal, "");
            }
        }

        private void textBoxPacient_Validating(object sender, CancelEventArgs e)
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
                errorProvider1.SetError(tblocal, "Numele pacientului nu poate contine cifre!");

            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            string obiect = listBox1.Items[listBox1.SelectedIndex].ToString();
            if (obiect != null)
                listBox1.DoDragDrop(obiect, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void textBoxPacient_DragDrop(object sender, DragEventArgs e)
        {
            Control cine = (TextBox)sender;
            cine.Text += e.Data.GetData(DataFormats.Text);
        }

        private void textBoxPacient_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.KeyState & 8) == 8 && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.Move;
        }
    }
}
