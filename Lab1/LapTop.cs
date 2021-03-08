namespace Lab1
{
    public class LapTop : Computer
    {
        public LapTop(string cpuBrand, int cpuClock, string motherboard, string hardDrive, string videoCard, bool wiFi, int price, int count, int diagonal, int battery) : base(cpuBrand, cpuClock, motherboard, hardDrive, videoCard, wiFi, price, count)
        {
            Diagonal = diagonal;
            Battery = battery;
        }

        public LapTop()
        {
            
        }

        public int Diagonal;
        public int Battery;
    }
}