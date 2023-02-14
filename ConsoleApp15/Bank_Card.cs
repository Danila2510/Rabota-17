using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Bank
    {
        public string NomerKarty { get; set; } = null;
        public string Imya { get; set; } = null;
        public int? CVV { get; set; } = null;
        public string Data { get; set; } = null;
        public int Dengi { get; set; } = 0;
        public Bank() { }
        public Bank(string nomerkarty, string imya, int? cvv, string data, int dengi)
        {
            NomerKarty = nomerkarty;
            Imya = imya;
            CVV = cvv;
            Data = data;
            Dengi = dengi;
        }

        public override string ToString()
        {
            return $" ФИО {Imya}\n Номер карты  {NomerKarty}\n Дата  {Data}\n CVV  {CVV}\n Деньги {Dengi}";
        }
        public static Bank operator +(Bank a, int b)
        {
            a.Dengi += b;
            return a;
        }
        public static Bank operator -(Bank a, int b)
        {
            b *= -1;
            return a + b;
        }
        public static bool operator ==(Bank a, int b)
        {
            if (a.CVV == b)
                return true;
            else
                return false;
        }
        public static bool operator !=(Bank a, int b) => !(a == b);
        public static bool operator >(Bank a, int b)
        {
            if (a.Dengi > b)
                return true;
            else
                return false;
        }
        public static bool operator <(Bank a, int b) => !(a > b);
    }
}
