namespace ch02;

internal class Program
{
    public static void Main(string[] args)
    {
        int a = 3, b = 8;
        Console.WriteLine(a + b); // 11
        Console.WriteLine("a + b"); //a + b
        Console.WriteLine(a + "+" + b); // 3+8
        Console.WriteLine("a+b" + a + b); //a+b38
        Console.WriteLine("a+b" + (a + b)); // a+b11
        var str = "a";
        var str1 = "10000";
        Console.WriteLine(str + "-" + str1);

        // 23+45=68
        //Console.WriteLine(a + "+" + b + "=" + (a + b));
        Console.WriteLine("{0}+{1}={2}", a, b, a + b); //0 1 2 

        Console.WriteLine("两个数字相加{0}+{0}={2}", 34, 123, 4);

        // Console.WriteLine("两个数字相加{0}+{0}={3}", 34, 123, 4);

        a += 10; //a = a+10;
        Console.WriteLine(a);
        a -= 5; //5
        Console.WriteLine(a);
        a *= 3; //15
        Console.WriteLine(a);
        a /= 6; //2
        Console.WriteLine(a);
        a %= 2; //0
        Console.WriteLine(a);
    }
}