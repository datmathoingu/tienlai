using System;
using System.Text;
namespace tienlai
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 1.0;
            int month = 1;
            double intersetRate = 1.0;
            double kq;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập số tiền gửi: ");
            money = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tháng gửi: ");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lãi suất: ");
            intersetRate = Double.Parse(Console.ReadLine());
            kq = lai(money,month,intersetRate);
            Console.WriteLine("Lãi suất nhận được: " + kq);
        }
        static double lai(double tien, int thang, double tile)
        {
            double totalInterset = 0;
            for (int i = 0; i < thang; i++)
            {
                totalInterset = tien * (tile / 100) / 12 * 3;
            } return totalInterset;
        }
    }
}
