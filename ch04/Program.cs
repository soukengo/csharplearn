// See https://aka.ms/new-console-template for more information


namespace ch04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("您想喝什么饮料：");
            int number = Convert.ToInt32(Console.ReadLine());
            Demo.DoSomething(number);
        }
    }
}