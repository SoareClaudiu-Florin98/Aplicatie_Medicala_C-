using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1056_Soare_Claudiu_Florin_Proiect.Classes
{
    class Programare
    {
        int id; 
        DateTime data;
        Medic medicP;
        String mail;
        String nrTelefon;
        String specialitate;
        String numePacient;
        
        public DateTime Data
        {
            get { return data;  }
            set { data = value;  }
        }
        public int Id
        {
            get { return id;  }
            set { id = value;  }
        }
        public String NumePacient
        {
            get { return numePacient; }
            set { numePacient = value; }
        }
        public Medic MedicP
        {
            get { return medicP;  }
            set { medicP = value; }
        }
        public String Mail
        {
            get { return mail;  }
            set { mail = value;  }
        }  

        
        public String NrTelefon
        {
            get { return nrTelefon;  }
            set { nrTelefon = value;  }
        } 
        public String Specialitate
        {
            get { return specialitate;  }
            set { specialitate = value;  }
        }
        public Programare(DateTime data, Medic medicP, String mail, String nrTelefon , String specialitate,String numePacient, int id )
        {
            this.data = data;
            this.medicP = medicP;
            this.mail = mail;
            this.nrTelefon = nrTelefon;
            this.specialitate = specialitate;
            this.numePacient = numePacient;
            this.id = id; 

        }
        public Programare()
        {
            data = DateTime.Now ;
            medicP = null;
            mail = "";
            nrTelefon = "";
            specialitate = "";
            numePacient = ""; 

        }
        
          

    }
}
