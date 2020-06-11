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
    public partial class FormRetete : Form
    {
        public FormRetete()
        {
            InitializeComponent();
            startUC1.BringToFront(); 
        }

        private void buttonGripa_Click(object sender, EventArgs e)
        {
            gripaUC1.BringToFront(); 
        }

        private void buttonRaceala_Click(object sender, EventArgs e)
        {
            racealaUC1.BringToFront(); 
        }

        private void buttonTuse_Click(object sender, EventArgs e)
        {
            tuseUC1.BringToFront(); 
        }
    }
}
