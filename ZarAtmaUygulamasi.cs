using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            while (true)
            {
                Console.WriteLine("Kaç zar atmak istiyorsunuz?");
                var zarSayisi = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Zar sayısı: " + zarSayisi);

                for (var i = 0; i < zarSayisi; i++)
                {
                    var zar = rnd.Next(1, 7);

                    Console.WriteLine(" ___________");
                    Console.WriteLine("|           |");
                    if (zar <= 3)
                    {
                        if (zar == 2 || zar == 3) Console.WriteLine("|       X   |");
                        else Console.WriteLine("|           |");
                        if (zar == 1 || zar == 3) Console.WriteLine("|     X     |");
                        else Console.WriteLine("|           |");
                        if (zar == 2 || zar == 3) Console.WriteLine("|   X       |");
                        else Console.WriteLine("|           |");
                        Console.WriteLine("|___________|");
                        continue;
                    }
                    Console.WriteLine("|   X   X   |");
                    if (zar == 4) Console.WriteLine("|           |");
                    else if (zar == 5) Console.WriteLine("|     X     |");
                    else Console.WriteLine("|   X   X   |");
                    Console.WriteLine("|   X   X   |");
                    Console.WriteLine("|___________|");
                }
            }
        }
    }
}