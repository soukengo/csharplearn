using System;

namespace ch03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // bool a = 45 == 67;
            // bool b = 45 < 67;
            // bool c = 45 <= 45;
            // bool d = 45 > 67;
            // bool e = 45 >= 67;
            // bool f = 45 != 67;
            //
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(d);
            // Console.WriteLine(e);
            // Console.WriteLine(f);

            // int mathScore = Convert.ToInt32(Console.ReadLine());
            // int englishScore = Convert.ToInt32(Console.ReadLine());
            // bool isGetAward = mathScore >= 90 && englishScore >= 90;
            // Console.WriteLine(isGetAward);
            
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if( a+b>c && a+c>b && b + c > a)
            {
                Console.WriteLine("可以组成三角形");
            }
            else
            {
                Console.WriteLine("不可以组成三角形");
            }
        }
    }
}