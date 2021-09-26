using System;

namespace _20110573_Problem1
{
    public class ThoiGian
    {
        private static string Name;
        int Nam;
        int Thang, Ngay, Gio, Phut, Giay;
        public void PresentTime()
        {
            Console.WriteLine("Bieu dien thoi gian bang {0}", Name);
            Console.WriteLine("Display Curent Time: {1}/{0}/{2}--{3}:{4}{5}", Ngay, Thang, Nam, Gio, Phut, Giay);
        }
        static ThoiGian()
        {
            Name = "#C";
        }
        public ThoiGian(DateTime dt)
        {
            Nam = dt.Year; Thang = dt.Month; Ngay = dt.Day;
            Gio = dt.Hour; Phut = dt.Minute; Giay = dt.Second;
        }
    }
    public class Tester
    {
        static void Main()
        {
            DateTime currentTime = DateTime.Now;
            ThoiGian t = new ThoiGian(currentTime);
            t.PresentTime();
        }
    }
}
