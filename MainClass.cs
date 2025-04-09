using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            /*Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;*/
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tere! Hea Päev! Привет!");
            // I.osa Andmetüübd, If, Case, Random, Alamfunktsioonid
            int a = 0;
            string tekst = "Python";
            char taht= 'A';
            Console.WriteLine("Double arv: ");
            double arv = Convert.ToDouble(Console.ReadLine());
            //double.TryParse(Console.ReadLine(), out double arv)
            Console.WriteLine("Float arv: ");
            float arv1 = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("Mis on sinu nimi? ");
            tekst = Console.ReadLine();
            Console.WriteLine("Tere!\n"+tekst);
            Console.WriteLine("Tere!\n {0}",tekst);
            FunktsioonideClass.Juku(tekst);
            Console.Write("Arv 2: ");
            int arv2=int.Parse(Console.ReadLine());
            //Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
            arv1=FunktsioonideClass.Kalkulaator(a, arv2);
            Console.WriteLine(arv1);
            Console.WriteLine("Switch'i kasutamine");
            Random rnd = new Random();
            a=rnd.Next(1,7);
            Console.WriteLine(a);
            tekst=FunktsioonideClass.Nadala_paev(a);
            Console.WriteLine(tekst);
            Console.ReadKey();
        }

    }

}
