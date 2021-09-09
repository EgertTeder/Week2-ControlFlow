using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kasutajal palub sisestada numbrit -10 kuni 10;
            //programm kontrollib numbrit;
            //kui number on positiivne, konsool kuvab "positive";
            //kui number on negatiivne, konsool kuvab "negative";
            //kui number on 0, siis konsool kuvab "null";

            Consle.WriteLine("Palun sisesta arv -10 kuni 10");
            int UserNumber = Convert.ToInt32(Console.ReadLine());

            if(UserNumber > 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("null");
            }

    
        }
    }
}
