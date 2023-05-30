using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Заведение
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new menu1());
            Console.WriteLine("Колко човека сте? ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Пушачи или Непушачи ");
            string masa = Console.ReadLine();
            string[] salata = new string[a];
            string[] osnovno = new string[a];
            string[] desert = new string[a];
            Console.WriteLine(" ИЗбери храна ");
            for (int i = 0; i < a; i++)
            {
               
                Console.Write($"Salati");
                salata[i] = Console.ReadLine();
                Console.Write($"Osnovno");
                osnovno[i] = Console.ReadLine();
                Console.Write($"Deserti");
                desert[i] = Console.ReadLine();
            }
            string[] napitka = new string[a];
            for (int i = 0; i < a; i++)
            {
                Console.Write($"Napitka");
                napitka[i] = Console.ReadLine();
            }

        }
    }
}
