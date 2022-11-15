using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Esercizio2_Universita_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<CorsoDiLaurea, List<string>>> university = new Dictionary<string, Dictionary<CorsoDiLaurea, List<string>>>();
           
            university.Add("1044", new Dictionary<CorsoDiLaurea, List<string>>());
            university.Add("1145", new Dictionary<CorsoDiLaurea, List<string>>());
            university.Add("1255", new Dictionary<CorsoDiLaurea, List<string>>());

            university["1044"].Add(CorsoDiLaurea.Decorazione, new List<string>());
           
            university["1145"].Add(CorsoDiLaurea.Pittura, new List<string>());
                      
            university["1255"].Add(CorsoDiLaurea.Scultura, new List<string>());

            if (university["1044"].ContainsKey(CorsoDiLaurea.Decorazione))
            {
               
                university["1044"][CorsoDiLaurea.Decorazione].Add("Voto del Corso "+Esame.StoriaDellArteContemporanea+": 28");
                university["1044"][CorsoDiLaurea.Decorazione].Add("Voto del Corso " + Esame.StoriaDeiNuoviMedia + ": 30");
                university["1044"][CorsoDiLaurea.Decorazione].Add("Voto del Corso " + Esame.LinguaggiMultimediali + ": 28");
            }
            else
            {
                Console.WriteLine("N.Matricola 1044 was not exist");
            }

            if (university["1145"].ContainsKey(CorsoDiLaurea.Pittura))
            {
               
                university["1145"][CorsoDiLaurea.Pittura].Add("Voto del Corso " + Esame.StoriaDellArteContemporanea + ": 27");
                university["1145"][CorsoDiLaurea.Pittura].Add("Voto del Corso " + Esame.StoriaDeiNuoviMedia + ": 25");
                university["1145"][CorsoDiLaurea.Pittura].Add("Voto del Corso " + Esame.LinguaggiMultimediali + ": 28");
            }
            else
            {
                Console.WriteLine("N.Matricola 1145 was not exist");
            }

            if (university["1255"].ContainsKey(CorsoDiLaurea.Scultura))
            {
               
                university["1255"][CorsoDiLaurea.Scultura].Add("Voto del Corso " + Esame.StoriaDellArteContemporanea + ": 26");
                university["1255"][CorsoDiLaurea.Scultura].Add("Voto del Corso " + Esame.StoriaDeiNuoviMedia + ": 28");
                university["1255"][CorsoDiLaurea.Scultura].Add("Voto del Corso " + Esame.LinguaggiMultimediali + ": 27");
            }
            else
            {
                Console.WriteLine("N.Matricola 1255 was not exist");
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Codice Fiscale:");
                int i = 1;
                foreach (var item in university.Keys)
                {
                    Console.WriteLine(i++ + ") " + item);
                }
                Console.WriteLine("----------------------------------");
                Console.Write("Please insert codice fiscale that you want see information about that:");
                string cf = Console.ReadLine();
               
                if (cf == "1044")
                {
                    Console.WriteLine("Student: Darya Dalaei");
                    foreach (var item in university["1044"][CorsoDiLaurea.Decorazione])
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (cf == "1145")
                {
                    Console.WriteLine("Student: Antonio Serrano");
                    foreach (var item in university["1145"][CorsoDiLaurea.Pittura])
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (cf == "1255")
                {
                    Console.WriteLine("Student: Letizia Conte");
                    foreach (var item in university["1255"][CorsoDiLaurea.Scultura])
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("Sorry student with this C.F: " + cf + " was not found, please try again.");
                }

                Console.ReadKey();


            }



        }
    }
    public enum CorsoDiLaurea
    {
        Decorazione,
        Pittura,
        Scultura
    }
    public enum Esame
    {
        StoriaDeiNuoviMedia,
        StoriaDellArteContemporanea,
        LinguaggiMultimediali

    }
}
