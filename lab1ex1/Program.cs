using System;

namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Ex1
                 Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
                 paralelipiped dreptunghic, va afisa volumul lui */
            int lungime;
            int latime;
            int inaltime;

            Console.WriteLine("Acest program va calcula volumul unui paralelipiped dreptunghic");

            Console.WriteLine("Introduceti lungimea");
            lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti lungimea");
            latime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti lungimea");
            inaltime = int.Parse(Console.ReadLine());

            Console.WriteLine("Volumul este: " + lungime * latime * inaltime);
        }
    }
}
