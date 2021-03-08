using System;
using System.Collections.Generic;
using System.IO;

namespace Lab1
{
    class Program
    {
        private static string path = @"C:\Users\vlad\Desktop\Temp\Labs\Lab1\temp.txt";

        static void Main(string[] args)
        {
            // Stock.Add(new Computer("Intel", 4000, "ASUS", "Seagate", "NVIDIA", true, 25000, 3));
            // Stock.Add(new Computer("Ryzen", 4500, "GigaByte", "TOSHIBA", "MSI", true, 32000, 2));
            // Stock.Add(new Computer("Ryzen", 4200, "GigaByte", "Seagate", "MSI", true, 22000, 5));
            // // Stock.WriteToFile(path);
            Stock.ReadFromFile(path);
            Stock.DisplayAll();
            ShowMenu();
        }

        private static void ShowMenu()
        {
            Console.WriteLine("1 - Price off all computers, in stock \n2 - Show computer with max CPU-Clock between 20000-30000 \n3- Exit");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    _firstQuestion();
                    break;
                case 2:
                    _secondQuestion();
                    break;
                case 3: break;
                default:
                    ShowMenu();
                    break;
            }
        }

        private static void _firstQuestion()
        {
            var price = 0;
            foreach (var computer in Stock.GetComputers())
            {
                price += computer.Count * computer.Price;
            }

            Console.WriteLine(price);
            ShowMenu();
        }

        private static void _secondQuestion()
        {
            Computer bestComputer = new Computer();
            foreach (var computer in Stock.GetComputers())
            {
                if (computer.Price < 30000 && computer.Price > 20000 && bestComputer.CpuClock < computer.CpuClock)
                {
                    bestComputer = computer;
                }
            }
            bestComputer.Display();
            ShowMenu();
        }
    }
}