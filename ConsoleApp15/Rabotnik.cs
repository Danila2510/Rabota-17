using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Rabotnik
    {
        private string FIO { get; set; }
        private string Den_rojdenie { get; set; }
        private string Nomer { get; set; }
        private string Description { get; set; }
        private string Tip { get; set; }
        private int Zarplata { get; set; }

        private static string Email;

        public Rabotnik() { }
        public Rabotnik(string fio, string den_rojdenie, string nomer, string description, string tip, int zarplata)
        {
            FIO = fio;
            Den_rojdenie = den_rojdenie;
            Nomer = nomer;
            Description = description;
            Tip = tip;
            Zarplata = zarplata;
        }
        static Rabotnik()
        {
            Console.WriteLine("Enter email ");
            Email = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($" ФИО {FIO}\n День рождение {Den_rojdenie}\n Номер {Nomer}\n Эмеил  {Email}\n Описание {Description}\n Тип {Tip}\n ЗП {Zarplata}$");
        }
        public override string ToString()
        {
            return $" ФИО: {FIO}\n День рождение {Den_rojdenie}\n Номер {Nomer}\n Эмеил {Email}\n Описание: {Description}\n Тип: {Tip}\n ЗП {Zarplata}$";
        }

        public static Rabotnik operator +(Rabotnik a, int b)
        {
            a.Zarplata += b;
            return a;
        }
        public static Rabotnik operator -(Rabotnik a, int b)
        {
            a.Zarplata -= b;
            return a;
        }
        public static bool operator ==(Rabotnik a, Rabotnik b)
        {
            if (a.Zarplata == b.Zarplata)
                return true;
            else
                return false;
        }
        public static bool operator !=(Rabotnik a, Rabotnik b) => !(a == b);

        public static bool operator >(Rabotnik a, Rabotnik b)
        {
            if (a.Zarplata > b.Zarplata)
                return true;
            else
                return false;
        }
        public static bool operator <(Rabotnik a, Rabotnik b) => !(a.Zarplata > b.Zarplata);

    }
}