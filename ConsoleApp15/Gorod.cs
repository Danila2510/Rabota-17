using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Gorod
    {
        private string Imya;
        private string Strana;
        private int Kolvo;
        private string Ket_strana;
        private string Rajon;

        public Gorod() { }
        public Gorod(string i, string s, int ko, string k_st, string ra)
        {
            Imya = i;
            Strana = s;
            Kolvo = ko;
            Ket_strana = k_st;
            Rajon = ra;
        }
        public string imya { get { return Imya; } set { Imya = value; } }
        public string strana { get { return Strana; } set { Strana = value; } }
        public int kolvo { get { return Kolvo; } set { Kolvo = value; } }
        public string ket_strana { get { return Ket_strana; } set { Ket_strana = value; } }
        public string rajon { get { return Rajon; } set { Rajon = value; } }

        public void Print()
        {
            Console.WriteLine($" Город {Imya}\n Страна {Strana}\n Люди {Kolvo}\n Номер страны {Ket_strana}\n Район {Rajon}");
        }
        public override string ToString()
        {
            return $" Город  {Imya}\n Страна  {Strana}\n Люди: {Kolvo}\n Номер страны {Ket_strana}\n Район {Rajon}";
        }
        public static Gorod operator +(Gorod a, int b)
        {
            a.Kolvo += b;
            return a;
        }
        public static Gorod operator -(Gorod a, int b)
        {
            b *= -1;
            return a + b;
        }
        public static bool operator ==(Gorod a, int b)
        {
            if (a.Kolvo == b)
                return true;
            else
                return false;
        }
        public static bool operator !=(Gorod a, int b) => !(a == b);
        public static bool operator >(Gorod a, int b)
        {
            if (a.Kolvo > b)
                return true;
            else
                return false;
        }
        public static bool operator <(Gorod a, int b) => !(a > b);
    }
}
