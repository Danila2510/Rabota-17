using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Matriza matrixes = new Matriza();
            Console.WriteLine(matrixes + "\n\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    try
                    {
                        matrixes[i, j] = i + j;
                        Console.Write(matrixes[i, j] + "\t");
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine(a.Message);
                    }
                }
                Console.WriteLine("\n");

            }
        }
    }
}