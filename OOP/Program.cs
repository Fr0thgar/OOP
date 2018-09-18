using System;

namespace ZooOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Slange s= new Slange();
            s.navn = "per";

            Cat c = new Cat();
            c.navn = "molly";

            Dyr dyr = new Dyr();
            dyr.Tam = true;
            Console.WriteLine(dyr.Tam);
            

            
            // Create instance of Hest
            Hest minHest = new Hest();
            Hest minAndenHest = new Hest();
            
            minHest.run();
            minAndenHest.run();
            
        }
    }
}
