using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm kuvab kasutaja vanust

            Console.WriteLine("Sisesta oma sünniaastat:");

            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            Console.WriteLine($"Sa oled {Age} aastat vana.");

        }
    }
}
