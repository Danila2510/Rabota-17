using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Matriza
    {
        private static int strok;
        private static int stolb;
        private int[,] maten = new int[strok, stolb];
        private int Minimum { get; set; } = 0;
        private int Maximum { get; set; } = 0;
        public Matriza()
        {
            Random random = new Random();
            for (int i = 0; i < strok; i++)
                for (int j = 0; j < stolb; j++)
                    maten[i, j] = random.Next(1, 20);
            for (int i = 0; i < strok; i++)
                for (int j = 0; j < stolb; j++)
                {
                    if (Minimum > maten[i, j])
                        Minimum = maten[i, j];
                    if (Maximum < maten[i, j])
                        Maximum = maten[i, j];
                }
        }

        static Matriza()
        {
            Console.WriteLine("Enter number of lines ");
            strok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of columns ");
            stolb = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            for (int i = 0; i < strok; i++)
            {
                for (int j = 0; j < stolb; j++)
                    Console.Write(maten[i, j] + "\t");
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            Print();
            return "";
        }

        public static Matriza operator +(Matriza a, int b)
        {
            for (int i = 0; i < a.maten.GetLength(0); i++)
                for (int j = 0; j < a.maten.GetLength(1); j++)
                    a.maten[i, j] += b;
            return a;
        }
        public static Matriza operator -(Matriza a, int b)
        {
            int buf = b * -1;
            return a + buf;
        }
        public static Matriza operator +(Matriza a, Matriza b)
        {
            for (int i = 0; i < a.maten.GetLength(0); i++)
                for (int j = 0; j < a.maten.GetLength(1); j++)
                    a.maten[i, j] += b.maten[i, j];
            return a;
        }
        public static Matriza operator -(Matriza a, Matriza b)
        {
            for (int i = 0; i < a.maten.GetLength(0); i++)
                for (int j = 0; j < a.maten.GetLength(1); j++)
                    a.maten[i, j] -= b.maten[i, j];
            return a;
        }
        public static Matriza operator *(Matriza a, int b)
        {
            for (int i = 0; i < a.maten.GetLength(0); i++)
                for (int j = 0; j < a.maten.GetLength(1); j++)
                    a.maten[i, j] *= b;
            return a;
        }
        public static Matriza operator *(Matriza a, Matriza b)
        {
            Matriza buf = new Matriza();
            for (int i = 0; i < a.maten.GetLength(0); i++)
                for (int j = 0; j < a.maten.GetLength(1); j++)
                    for (int k = 0; k < a.maten.GetLength(0); k++)
                        buf.maten[i, j] += a.maten[i, k] * b.maten[k, j];
            return buf;
        }
        public static bool operator ==(Matriza a, Matriza b)
        {
            for (int i = 0; i < a.maten.GetLength(0); i++)
                for (int j = 0; j < a.maten.GetLength(1); j++)
                {
                    if (a.maten[i, j] != b.maten[i, j])
                        return false;
                }
            return true;
        }
        public static bool operator !=(Matriza a, Matriza b)
        {
            for (int i = 0; i < a.maten.GetLength(0); i++)
                for (int j = 0; j < a.maten.GetLength(1); j++)
                {
                    if (a.maten[i, j] == b.maten[i, j])
                        return false;
                }
            return true;
        }

        public int this[int r, int c]
        {
            get
            {
                if (r >= maten.GetLength(0) || r < 0 || c >= maten.GetLength(1) || c < 0)
                    throw new Exception("Incorrect index");
                else
                    return maten[r, c];
            }
            set
            {
                if (r >= maten.GetLength(0) || r < 0 || c >= maten.GetLength(1) || c < 0)
                    throw new Exception("Incorrect index");
                else
                    maten[r, c] = value;
            }
        }

    }
}