using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Lab1
{
    public static class Stock
    {
        private static List<Computer> _computers = new List<Computer>();

        public static void Add(Computer computer) => _computers.Add(computer);
        public static void Remove(Computer computer) => _computers.Remove(computer);

        public static void DisplayAll()
        {
            foreach (var computer in _computers)
            {
                computer.Display();
                Console.WriteLine("================");
            }
        }

        public static void Find(Computer computer)
        {
            if (_computers.Contains(computer))
            {
                Console.WriteLine("Match");
                Console.WriteLine("================");
                computer.Display();
                Console.WriteLine("================");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        public static void ReadFromFile(string path)
        {
            var i = 0;
            using (StreamReader streamReader = new StreamReader(path))
            {
                while (streamReader.ReadLine() != null)
                {
                    i++;
                }
                streamReader.Close();
            }

            using (StreamReader streamReader = new StreamReader(path))
            {
                for (int j = 0; j < i / 8; j++)
                {
                    var computer = new Computer();
                    computer.CpuBrand = streamReader.ReadLine();
                    computer.CpuClock = Convert.ToInt32(streamReader.ReadLine());
                    computer.Motherboard = streamReader.ReadLine();
                    computer.VideoCard = streamReader.ReadLine();
                    computer.HardDrive = streamReader.ReadLine();
                    computer.WiFi = Convert.ToBoolean(streamReader.ReadLine());
                    computer.Price = Convert.ToInt32(streamReader.ReadLine());
                    computer.Count = Convert.ToInt32(streamReader.ReadLine());
                    _computers.Add(computer);
                }
                streamReader.Close();
            }
        }

        public static IEnumerable<Computer> GetComputers()
        {
            foreach (var computer in _computers)
            {
                yield return computer;
            }
        }
        public static void WriteToFile(string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (var computer in _computers)
                {
                    streamWriter.WriteLine(computer.CpuBrand);
                    streamWriter.WriteLine(computer.CpuClock);
                    streamWriter.WriteLine(computer.Motherboard);
                    streamWriter.WriteLine(computer.VideoCard);
                    streamWriter.WriteLine(computer.HardDrive);
                    streamWriter.WriteLine(computer.WiFi);
                    streamWriter.WriteLine(computer.Price);
                    streamWriter.WriteLine(computer.Count);
                }
                streamWriter.Close();
            }
        }
    }
}