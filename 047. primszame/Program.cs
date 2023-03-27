using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047.primszame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            int szam = Convert.ToInt32(Console.ReadLine());

            //Console.Clear();

            int oszto = 0;

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    oszto++;
                }

                else
                {

                }
            }

            if(oszto == 2)
            {
                Console.WriteLine("A szám prímszám mert 1-en és önmagán kívül más számokkal nem osztható.");
            }

            else
            {
                Console.WriteLine("A szám nem prímszám, mert 1-en és önmagán kívül más számokkal is osztható.");
            }

            Console.ReadKey();
        }
    }
}
