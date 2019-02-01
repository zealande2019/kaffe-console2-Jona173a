using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KaffeConsoleAppNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cortado cortado = new Cortado();
            Latte latte = new Latte();
            SortKaffe sortKaffe = new SortKaffe();
            FlatWhite flatWhite = new FlatWhite(12);

            List<Imælk> liste = new List<Imælk>();
            liste.Add(cortado);
            liste.Add(latte);

            foreach (var item in liste)
            {
                Console.WriteLine("Før cast" + item.MlMælk());

                if (item is Latte)
                {
                    Latte 1 = item as Latte;
                    Console.WriteLine("Latte styrker" + 1.Styrke());
                }
                else if (item is Cortado)
                {
                    Cortado c = item as Cortado;
                }
            }

        }
    }
}
