using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nemci3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете броя на учениците: ");
            int broiuchenici = int.Parse(Console.ReadLine());

            for (int i = 1; i <= broiuchenici; i++)
            {
                Console.Write($"Въведете годините на {i}-ия ученик: ");
                int godini = int.Parse(Console.ReadLine());

                int mesec = 0;
                while (true)
                {
                    Console.Write($"Въведете месеца на раждане на {i}-ия ученик: ");
                    mesec = int.Parse(Console.ReadLine());
                    if (mesec >= 1 && mesec <= 12)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Грешка: невалиден месец.");
                    }
                }
                int klas = 0;

                if (godini == 14)
                {
                    if (mesec >= 10)
                    {
                        klas = 8;
                    }
                    else
                    {
                        klas = 9;
                    }
                }
                else if (godini == 15)
                {
                    if (mesec >= 10)
                    {
                        klas = 9;
                    }
                    else
                    {
                        klas = 10;
                    }
                }
                else if (godini == 16)
                {
                    if (mesec >= 10)
                    {
                        klas = 10;
                    }
                    else
                    {
                        klas = 11;
                    }
                }
                else if (godini == 17)
                {
                    if (mesec >= 10)
                    {
                        klas = 11;
                    }
                    else
                    {
                        klas = 12;
                    }
                }
                else if (godini == 18)
                {
                    if (mesec >= 10)
                    {
                        Console.WriteLine("Грешка: невалидна възраст за влизане в клас.");
                        return;
                    }
                    else
                    {
                        klas = 12;
                    }
                }
                else
                {
                    Console.WriteLine("Грешка: невалидна възраст за влизане в клас.");
                    return;
                }

                Console.WriteLine($"Ученикът трябва да влезе в {klas} клас.");




            }
        }
    }
}
