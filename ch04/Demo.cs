namespace ch04;

public class Demo
{
    internal static void DoSomething(int number)
    {
        Console.Write("您选择的是：");
        switch (number)
        {
            case 1:
            case 2:
                Console.WriteLine("矿泉水");
                Console.WriteLine("红茶");
                break;
            case 3:
                Console.WriteLine("绿茶");
                break;
            case 4:
                Console.WriteLine("雪碧");
                break;
            case 5:
                Console.WriteLine("可口可乐");
                break;
            case 6:
                Console.WriteLine("脉动");
                break;
            default:
                Console.WriteLine("没有你要购买的商品");
                break;
        }
    }
}