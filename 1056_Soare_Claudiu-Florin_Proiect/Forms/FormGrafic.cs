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
    public partial class FormGrafic : Form
    {
        private List<Pacient> listaPacienti;
        Pen p1; Brush b1;
        public FormGrafic(List<Pacient> listaPacienti )
        {
            InitializeComponent();
            this.listaPacienti = listaPacienti;
            p1 = new Pen(Color.Red, 3); 
            b1 = new SolidBrush(Color.Red);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int vl = e.ClipRectangle.X + 10, vr = e.ClipRectangle.Width - 20;
            int vt = e.ClipRectangle.Y + 10, vb = e.ClipRectangle.Height - 20;
            g.DrawRectangle(p1, vl, vt, vr - vl, vb - vt);
            //double[] vy = { 150, 90, 180, 50 };
            int under18 = 0;
            int between18_35 = 0;
            int between35_50 = 0;
            int between50_60 = 0;
            int over60 = 0;
            foreach (var i in listaPacienti)
            {
                if (i.VarstaPacient<=18)
                {
                    under18 += 1;
                }
                if (i.VarstaPacient > 18 && i.VarstaPacient <= 35)
                {
                    between18_35 += 1;
                }
                if (i.VarstaPacient > 35 && i.VarstaPacient <= 50)
                {
                    between35_50 += 1;
                }
                if (i.VarstaPacient > 50 && i.VarstaPacient <= 60)
                {
                    between50_60 += 1;
                }
                if (i.VarstaPacient >60)
                {
                    over60 += 1;
                }


            }
            double[] vy = { under18 * 20, between18_35 * 20, between35_50 * 20,between50_60 * 20, over60 *20};
            Brush[] vp =
            {
                new SolidBrush(Color.Purple), new SolidBrush(Color.Blue), new SolidBrush(Color.Yellow), new SolidBrush(Color.Green),new SolidBrush(Color.Black)
            };
            int nrObs = vy.Length, lat = (vr - vl) / nrObs;
            for (int i = 0; i < nrObs; i++)
            {
                g.FillRectangle(vp[i % 4], new Rectangle(vl + i * lat, (int)(vb - vy[i]), lat, (int)vy[i]));
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
