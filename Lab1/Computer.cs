using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Lab1
{
    public class Computer
    {
        public Computer(string cpuBrand, int cpuClock, string motherboard, string hardDrive, string videoCard, bool wiFi, int price, int count)
        {
            CpuBrand = cpuBrand;
            CpuClock = cpuClock;
            Motherboard = motherboard;
            HardDrive = hardDrive;
            VideoCard = videoCard;
            WiFi = wiFi;
            Price = price;
            Count = count;
        }

        public Computer()
        {
            
        }


        public string CpuBrand;
        public int CpuClock;
        public string Motherboard;
        public string HardDrive;
        public string VideoCard;
        public bool WiFi;
        public int Price;
        public int Count;


        public static bool operator ==(Computer a, Computer b)
        {
            if (a.CpuBrand == b.CpuBrand && a.CpuClock == b.CpuClock && a.Motherboard == b.Motherboard && a.VideoCard == b.VideoCard && a.HardDrive == b.HardDrive)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Computer a, Computer b)
        {
            return !(a == b);
        }


        public void Display()
        {

            Console.WriteLine("CPU Brand - {0}\nCPU CLock - {1}\nMotherBoard - {2}\nHardDrive - {3}\nWiFi - {4}\nVideoCard - {5}\nPrice - {6}\nCount- {7}",
                CpuBrand, CpuClock, Motherboard, HardDrive, WiFi, VideoCard, Price, Count);


        }
    }
}