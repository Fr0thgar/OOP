using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOP
{
    class Hest: Dyr
    {
      //Maxhastighed målt i km/t
        public double maxHastighed;
      public Hest()
        {
            Console.WriteLine("Hvad skal hesten hedde?");
            navn = Console.ReadLine();
            Console.WriteLine("Hvad er hestens fødselsår");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvor hurtig er du?");
            maxHastighed = Convert.ToDouble(Console.ReadLine());
        }

        private void eat()
        {
            Console.WriteLine("Gnaske gnaske...");
        }

        public void run()
        {
            if (2018- year <= 1)
            {
                Console.WriteLine("Weeeeeeeiii");
            }
            else
            {
                Console.WriteLine("Wrinske wrinske ");
            }
            Console.WriteLine("Jeg hedder " +navn);
//            Console.Write("Wrinske wrinske ");
            Console.WriteLine("jeg løber med " +maxHastighed+ " km/t");
            Console.WriteLine("Jeg er " +(2018-year)+ " år gammel");
            eat();
        }

        public void age()
        {

            Console.WriteLine("Wrinske wrinske, jeg er ");
            Console.ReadLine();
        }
    }
}
