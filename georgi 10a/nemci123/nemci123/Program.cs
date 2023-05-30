using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nemci123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kolko uchenici vlizat
            // na kolko godini sa
            // sprqmo godinite koi klas          
            // Задаване на граници за възрастта на учениците
            int osmi1 = 14;
            int osmi = 15;
            int deveti = 16;
            int deseti = 17;
            int edinaisti = 18;
            int dvanaisti = 19;
            // Въвеждане на броя на учениците и техните години
            Console.WriteLine("vuvedi broq uchenici");
            int broiuchenici = int.Parse(Console.ReadLine());

            int[] ages = new int[broiuchenici];
            int[] meseci = new int[broiuchenici];
            for (int i = 0; i < broiuchenici; i++)
            {
                Console.WriteLine($" na kolko godina e uchenik {i + 1}:");
                ages[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($" V koi mesec e roden uchenik {i + 1}:");
                meseci[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < broiuchenici; i++)
            {
                int godini = ages[i];
                int mesec = meseci[i];
                if (godini < osmi1)
                {
                    Console.WriteLine($"uchenik {i + 1} maluk si za daskalo");
                }
                else if (godini >= osmi1)
                {
                    osmi1++;
                    Console.WriteLine($"uchenik {i + 1} e na {godini} godini toi e za osmi klas ");
                }
                else if (godini >= osmi && godini < deveti)
                {
                    osmi++;
                    Console.WriteLine($"uchenik {i + 1} e na {godini} godini toi e za osmi ili za deveti klas ");
                }
                else if (godini >= deveti && godini < deseti)
                {
                    deveti++;
                    Console.WriteLine($"uchenik {i + 1} e na {godini} godini toi е za deveti ili deseti klas ");
                }
                else if (godini >= deseti && godini < edinaisti)
                {
                    deseti++;
                    Console.WriteLine($"uchenik {i + 1} e na {godini} godini toi e za deseti ili edinaisti klas ");
                }
                else if (godini >= edinaisti && godini < dvanaisti)
                {
                    edinaisti++;
                    Console.WriteLine($"uchenik {i + 1} e na  {godini} godini toi e za edinaisti ili dvanaisti klas ");
                }
                else if (godini >= dvanaisti)
                {
                    dvanaisti++;
                    Console.WriteLine($"uchenik {i + 1} e na  {godini} godini toi e za dvanaisti klas ");
                }
                
                
                // imam 6

            }
        }
    }
}    

