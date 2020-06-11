using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _1056_Soare_Claudiu_Florin_Proiect.Classes
{
    [Serializable]
    public class Medic:ICloneable,IComparable
    {
        private String nume;
        private String clinica; 
        private int varsta;

        public string Nume

        {
            get { return nume; }
            set { nume = value; }
        }
        public string Clinica
        {
            get { return clinica; }
            set { clinica = value;  }
        }

        public int Varsta
        {
            get { return varsta; }
            set { varsta = value;  }
        }
        public void Afisare()
        {
            Console.WriteLine("Medicul {0} de la clinica {1} are {3} ani . "); 

        }
        public override string ToString()
        {
            return nume+ " "+clinica+" "+varsta +" "; 
        }

        public Medic()
        {
            nume = "Necunoscut";
            clinica = "Med Ase";
            varsta = 0; 
        }
        public Medic(String nume, String clinica, int varsta)
        {
            this.nume = nume;
            this.clinica = clinica;
            this.varsta = varsta; 
        }



        public Medic Clone()
        {
            return  (Medic)((ICloneable)this).Clone();

  
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone(); 

        }

        public int CompareTo(object obj)
        {
            Medic mNou = (Medic)obj;
            if (this.varsta > mNou.varsta)
            {
                return 1;
            }
            else if (this.varsta < mNou.varsta)
            {
                return -1;
            }
            else return String.Compare(this.nume, mNou.nume); 

        }



        //Supraincarcare operatot ++ pt incrementarea varstei 
        public static Medic operator ++(Medic m )
        {
            m.varsta = m.varsta + 1;
            return m; 

        }
    }
}
