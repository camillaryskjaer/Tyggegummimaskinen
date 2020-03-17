using System;
using System.Collections.Generic;
using System.Threading;

namespace Tyggegummimaskinen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TyggegummiDispenser tyggegummiDispenser = new TyggegummiDispenser();

            List<Tyggegummi> TyggegummiMaskine = new List<Tyggegummi>
            {
            //6
            new Tyggegummi("Æble"),
            new Tyggegummi("Æble"),
            new Tyggegummi("Æble"),
            new Tyggegummi("Æble"),
            new Tyggegummi("Æble"),
            new Tyggegummi("Æble"),
            //7
            new Tyggegummi("Brombær"),
            new Tyggegummi("Brombær"),
            new Tyggegummi("Brombær"),
            new Tyggegummi("Brombær"),
            new Tyggegummi("Brombær"),
            new Tyggegummi("Brombær"),
            new Tyggegummi("Brombær"),
            //10
            new Tyggegummi("Appelsin"),
            new Tyggegummi("Appelsin"),
            new Tyggegummi("Appelsin"),
            new Tyggegummi("Appelsin"),
            new Tyggegummi("Appelsin"),
            new Tyggegummi("Appelsin"),
            new Tyggegummi("Appelsin"),
            new Tyggegummi("Appelsin"),
            new Tyggegummi("Appelsin"),
            new Tyggegummi("Appelsin"),
            //11
            new Tyggegummi("TuttiFrutti"),
            new Tyggegummi("TuttiFrutti"),
            new Tyggegummi("TuttiFrutti"),
            new Tyggegummi("TuttiFrutti"),
            new Tyggegummi("TuttiFrutti"),
            new Tyggegummi("TuttiFrutti"),
            new Tyggegummi("TuttiFrutti"),
            new Tyggegummi("TuttiFrutti"),
            new Tyggegummi("TuttiFrutti"),
            new Tyggegummi("TuttiFrutti"),
            new Tyggegummi("TuttiFrutti"),
            //8
            new Tyggegummi("jordbærd"),
            new Tyggegummi("jordbærd"),
            new Tyggegummi("jordbærd"),
            new Tyggegummi("jordbærd"),
            new Tyggegummi("jordbærd"),
            new Tyggegummi("jordbærd"),
            new Tyggegummi("jordbærd"),
            new Tyggegummi("jordbærd"),
            //13
            new Tyggegummi("blåbær"),
            new Tyggegummi("blåbær"),
            new Tyggegummi("blåbær"),
            new Tyggegummi("blåbær"),
            new Tyggegummi("blåbær"),
            new Tyggegummi("blåbær"),
            new Tyggegummi("blåbær"),
            new Tyggegummi("blåbær"),
            new Tyggegummi("blåbær"),
            new Tyggegummi("blåbær"),
            new Tyggegummi("blåbær"),
            new Tyggegummi("blåbær"),
            new Tyggegummi("blåbær")
            };

            Console.WriteLine("Tryk på en knap for at trække et tyggegummi");

            while (true)
            {
                if (TyggegummiMaskine.Count > 0)
                {
                    for (int i = 0; i < 55; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("Tryk på en knap for at trække et tyggegummi\n");
                        Console.WriteLine("Du trak et tyggegummi med {0} smag", DrawGum().Flavour);
                        Console.WriteLine("\nDer er {0} tyggegummier tilbage i automaten", TyggegummiMaskine.Count);
                        Console.ReadKey();
                        Console.Clear();


                    }
                }
                else
                {
                    Console.WriteLine("Desvære er din tyggegummi automat tom. Du kan fylder den op igen med et abonnement på 100kr om måneden");
                    Console.WriteLine("\nTryk på en knap for at starte dit abonnement");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Fylder op");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(300);
                    }
                    FillUpGumDispenser();
                    Console.Clear();
                    Console.WriteLine("Din automat er fyldt op");
                    Thread.Sleep(3000);
                    Console.Clear();

                }


            }





            Tyggegummi DrawGum()
            {
                Tyggegummi YouDrew = TyggegummiMaskine[0];
                TyggegummiMaskine.RemoveAt(0);

                return YouDrew;
            }

            void FillUpGumDispenser()
            {
                //6
                TyggegummiMaskine.Add(new Tyggegummi("Æble"));
                TyggegummiMaskine.Add(new Tyggegummi("Æble"));
                TyggegummiMaskine.Add(new Tyggegummi("Æble"));
                TyggegummiMaskine.Add(new Tyggegummi("Æble"));
                TyggegummiMaskine.Add(new Tyggegummi("Æble"));
                TyggegummiMaskine.Add(new Tyggegummi("Æble"));
                //7
                TyggegummiMaskine.Add(new Tyggegummi("Brombær"));
                TyggegummiMaskine.Add(new Tyggegummi("Brombær"));
                TyggegummiMaskine.Add(new Tyggegummi("Brombær"));
                TyggegummiMaskine.Add(new Tyggegummi("Brombær"));
                TyggegummiMaskine.Add(new Tyggegummi("Brombær"));
                TyggegummiMaskine.Add(new Tyggegummi("Brombær"));
                TyggegummiMaskine.Add(new Tyggegummi("Brombær"));

                //10
                TyggegummiMaskine.Add(new Tyggegummi("Appelsin"));
                TyggegummiMaskine.Add(new Tyggegummi("Appelsin"));
                TyggegummiMaskine.Add(new Tyggegummi("Appelsin"));
                TyggegummiMaskine.Add(new Tyggegummi("Appelsin"));
                TyggegummiMaskine.Add(new Tyggegummi("Appelsin"));
                TyggegummiMaskine.Add(new Tyggegummi("Appelsin"));
                TyggegummiMaskine.Add(new Tyggegummi("Appelsin"));
                TyggegummiMaskine.Add(new Tyggegummi("Appelsin"));
                TyggegummiMaskine.Add(new Tyggegummi("Appelsin"));
                TyggegummiMaskine.Add(new Tyggegummi("Appelsin"));

                //11
                TyggegummiMaskine.Add(new Tyggegummi("TuttiFrutti"));
                TyggegummiMaskine.Add(new Tyggegummi("TuttiFrutti"));
                TyggegummiMaskine.Add(new Tyggegummi("TuttiFrutti"));
                TyggegummiMaskine.Add(new Tyggegummi("TuttiFrutti"));
                TyggegummiMaskine.Add(new Tyggegummi("TuttiFrutti"));
                TyggegummiMaskine.Add(new Tyggegummi("TuttiFrutti"));
                TyggegummiMaskine.Add(new Tyggegummi("TuttiFrutti"));
                TyggegummiMaskine.Add(new Tyggegummi("TuttiFrutti"));
                TyggegummiMaskine.Add(new Tyggegummi("TuttiFrutti"));
                TyggegummiMaskine.Add(new Tyggegummi("TuttiFrutti"));
                TyggegummiMaskine.Add(new Tyggegummi("TuttiFrutti"));

                //8
                TyggegummiMaskine.Add(new Tyggegummi("jordbærd"));
                TyggegummiMaskine.Add(new Tyggegummi("jordbærd"));
                TyggegummiMaskine.Add(new Tyggegummi("jordbærd"));
                TyggegummiMaskine.Add(new Tyggegummi("jordbærd"));
                TyggegummiMaskine.Add(new Tyggegummi("jordbærd"));
                TyggegummiMaskine.Add(new Tyggegummi("jordbærd"));
                TyggegummiMaskine.Add(new Tyggegummi("jordbærd"));
                TyggegummiMaskine.Add(new Tyggegummi("jordbærd"));
                //13
                TyggegummiMaskine.Add(new Tyggegummi("blåbær"));
                TyggegummiMaskine.Add(new Tyggegummi("blåbær"));
                TyggegummiMaskine.Add(new Tyggegummi("blåbær"));
                TyggegummiMaskine.Add(new Tyggegummi("blåbær"));
                TyggegummiMaskine.Add(new Tyggegummi("blåbær"));
                TyggegummiMaskine.Add(new Tyggegummi("blåbær"));
                TyggegummiMaskine.Add(new Tyggegummi("blåbær"));
                TyggegummiMaskine.Add(new Tyggegummi("blåbær"));
                TyggegummiMaskine.Add(new Tyggegummi("blåbær"));
                TyggegummiMaskine.Add(new Tyggegummi("blåbær"));
                TyggegummiMaskine.Add(new Tyggegummi("blåbær"));
                TyggegummiMaskine.Add(new Tyggegummi("blåbær"));
                TyggegummiMaskine.Add(new Tyggegummi("blåbær"));
            }
        }
    }

}
