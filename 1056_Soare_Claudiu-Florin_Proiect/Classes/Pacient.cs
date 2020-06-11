using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1056_Soare_Claudiu_Florin_Proiect.Classes
{
    [Serializable]
    public class Pacient:ICloneable,IComparable
    {
        private int id;
        private String nume;
        private int varstaPacient;
        private String numeMedic;

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public int VarstaPacient
        {
            get { return varstaPacient; }
            set { varstaPacient = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String NumeMedic
        {
            get { return numeMedic;  }
            set { numeMedic = value;  }
        }
        public Pacient()
        {
            nume = "Necunoscut";
            varstaPacient = 0;
            id = 0;
            numeMedic = ""; 
        }
        public Pacient(int id, String nume, int varsta ,  String medic)
        {
            this.nume = nume;
            this.varstaPacient = varsta;
            this.id = id;
            this.numeMedic = medic;
        }
        public override string ToString()
        {
            return id + " " + nume + " " +varstaPacient  + " " + numeMedic;

        }

        public void AfisarePacient()
        {
            Console.WriteLine("Pacientul {0}, in varsta de {1} e inregistrat la medicul {2}", nume, varstaPacient, numeMedic);

        }

        public Pacient Clone()
        {
            Pacient p1 =   (Pacient)((ICloneable)this).Clone();
            p1.id++;
            return p1; 
            //deep copy 
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone(); //copie superficiala

        }

        public int CompareTo(object obj)
        {
            Pacient p = (Pacient)obj; 
            if (this.varstaPacient > p.varstaPacient)
            {
                return 1;
            }
            else if (this.varstaPacient < p.varstaPacient)
            {
                return -1;
            }
            else return String.Compare(this.nume, p.nume);
        }
        //Supraincarcare operatot ++ pt incrementarea varstei 
        public static Pacient operator ++(Pacient p)
        {
            p.varstaPacient = p.varstaPacient + 1;
            return p;

        }
    }
}
