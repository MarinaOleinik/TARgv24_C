using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C
{

    class Person
    {
        public string Name { get; set; }
    }
    internal class FunktsioonideClass_3osa
    {
        
        public static void Esimene_naide()
        {
            ArrayList nimed = new ArrayList();
            nimed.Add("Kati");
            nimed.Add("Mati");
            nimed.Add("Juku");

            if (nimed.Contains("Mati"))
                Console.WriteLine("Mati olemas");

            Console.WriteLine("Nimesid kokku: " + nimed.Count);

            nimed.Insert(1, "Sass");

            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

            foreach (string nimi in nimed)
                Console.WriteLine(nimi);
        }
       
        public static void Teine_naide()
        {
            Tuple<float, char, string> route = new Tuple<float, char, string>(2.5f, 'N', "North");
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}, Kirjeldus: {route.Item3}");
        }
        public static void Kolmas_naide()
        {
            List<Person> nimed = new List<Person>();
            nimed.Add(new Person { Name = "Kati" });
            nimed.Add(new Person { Name = "Mati" });
            nimed.Add(new Person { Name = "Juku" });
            foreach (var item in nimed)
                Console.WriteLine(item.Name);
        }
    }
}
