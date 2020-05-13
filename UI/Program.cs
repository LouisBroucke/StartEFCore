using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Model.Repositories;
using System;
using System.Reflection;

namespace UI
{
    class Program
    {
        //private static readonly EFOpleidingenContext context = new EFOpleidingenContext();

        static void Main(string[] args)
        {
            string keuze = String.Empty;

            while (keuze.ToUpper() != "X")
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("----");
                Console.WriteLine("Menu");
                Console.WriteLine("----");

                Console.WriteLine("1 - Menu item");
                //Hier komen de verschillende items

                Console.WriteLine("Kies X om te stoppen");
                keuze = Console.ReadLine();

                Console.WriteLine("----------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.Blue;

                if (keuze.ToUpper() != "X")
                {
                    //Reflection
                    Program p = new Program();
                    Type t = p.GetType();

                    try
                    {
                        MethodInfo mi = t.GetMethod("Item" + "00".Substring(0, -keuze.Length + 2) + keuze,
                            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                        mi.Invoke(p, null);
                        //string result = mi.Invoke(p, new object[] { par1, par2 }).ToString();   
                    }
                    catch
                    {
                        Console.WriteLine("Ongeldige keuze");
                    }
                }

                switch (keuze)     
                {     case "X": case "x": break;
                      case "1": 
                        {   
                            Item01(); 
                            break; 
                        }
                      default:  
                        { 
                            Console.WriteLine("Ongeldige keuze"); 
                            break;
                        }     
                } 

                if (keuze.ToUpper() == "X") break;

                Console.WriteLine("\nDruk een toets");
                Console.ReadKey();
                Console.Clear();
            } //While

            //Menu-items
            static void Item01()
            {
                using var context = new EFOpleidingenContext();

                foreach (var docent in context.Docenten)
                {
                    Console.WriteLine(docent.Naam);
                }
            }

        } //Main
    } //Program
}
