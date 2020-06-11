using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1056_Soare_Claudiu_Florin_Proiect.Classes
{
    class Retete
    {
        private Medic medicR;
        private Pacient pacientR;
        private String indicatiiR;
        private Pacient pacient; 

        public Medic MedicR {
            get { return medicR;  }
            set { medicR = value; }
        }
        public Pacient Pacient
        {
            get { return pacient;  }
            set { pacient = value;  }
        }
        public Pacient PacientR {
            get { return pacientR;  }
            set { pacientR = value;  }
        }
        public String IndicatiiR
        {
            get { return indicatiiR;  }
            set { indicatiiR = value;  }
        }
        public Retete(Medic medicR, Pacient pacientR, String indicatiiR,Pacient p )
        {
            this.medicR = medicR;
            this.pacientR = pacientR;
            this.indicatiiR = indicatiiR;
            this.Pacient = p; 
        }
        public Retete()
        {
            this.medicR = null;
            this.pacientR = null;
            this.indicatiiR = "";
            this.pacient = null; 
        }


    }
}
