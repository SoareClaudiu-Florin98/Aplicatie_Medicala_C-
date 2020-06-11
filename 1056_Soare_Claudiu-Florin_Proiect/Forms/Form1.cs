
using _1056_Soare_Claudiu_Florin_Proiect.Classes;
using _1056_Soare_Claudiu_Florin_Proiect.Forms;
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

namespace _1056_Soare_Claudiu_Florin_Proiect
{
    public partial class Form1 : Form
    {
        bool misca = false;
        Point start = new Point(0,0);
        public Form1()
        {
            InitializeComponent();
            timerActual.Start();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormStart copil1 = new FormStart();
            copil1.Dock = DockStyle.Fill;
            copil1.TopLevel = false;
            copil1.TopMost = true;
            this.panContainer.Controls.Add(copil1);
            copil1.BringToFront(); 
            copil1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerActual_Tick(object sender, EventArgs e)
        {

            DateTime dataCurenta = new DateTime();
            dataCurenta = DateTime.Now;
            labelForTimer.Text = dataCurenta.ToString("HH:mm:ss");
        }

        private void Pacienti_Click(object sender, EventArgs e)
        {
            FormPacienti copil1 = new FormPacienti();
            copil1.Show();

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            misca = false;  // daca mouse ul nu e apasat , nu putem misca imaginea 
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            misca = true; //daca mouse ul e apasat, putem muta 
            start = new Point(e.X, e.Y); //pentru a ramane mouse ul pe  pozitia curenta  
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (misca)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start.X, p.Y - start.Y); //mutam
            }
        }
        //O sa facem la fel si pt label uri, pt a putea muta imaginea si daca apasam pe ele  
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            misca = true;
            start = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            misca = false; 
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (misca)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start.X, p.Y - start.Y);
            }

        }


        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            misca = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            misca = true;
            start = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (misca)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start.X, p.Y - start.Y);
            }
        }
        //Facem si pt aceasta imagine 
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormStart copil1 = new FormStart();
            copil1.Dock = DockStyle.Fill;
            copil1.TopLevel = false;
            copil1.TopMost = true;
            this.panContainer.Controls.Add(copil1);
            copil1.BringToFront();
            copil1.Show();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            misca = true;
            start = new Point(e.X, e.Y); 
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            misca = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (misca)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start.X, p.Y - start.Y);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; 
        }

        private void Medici_Click(object sender, EventArgs e)
        {

            FormMedic copil = new FormMedic() ;

            copil.Dock = DockStyle.Fill;
            copil.TopLevel = false;
            copil.TopMost = true;

            this.panContainer.Controls.Add(copil);


            copil.BringToFront(); 
            copil.Show();

        }

        private void listaMediciUC1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonPaginaPrincipala_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            FormStart copil1 = new FormStart();
            copil1.Dock = DockStyle.Fill;
            copil1.TopLevel = false;
            copil1.TopMost = true;
            this.panContainer.Controls.Add(copil1);
            copil1.BringToFront();
            copil1.Show();
        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRetete_Click(object sender, EventArgs e)
        {
            FormRetete copil = new FormRetete();

            copil.Dock = DockStyle.Fill;
            copil.TopLevel = false;
            copil.TopMost = true;

            this.panContainer.Controls.Add(copil);


            copil.BringToFront();
            copil.Show();

        }

        private void buttonProgramari_Click(object sender, EventArgs e)
        {
            FormFaProgramare fcopil = new FormFaProgramare();
            fcopil.ShowDialog(); 
        }
    }
}
