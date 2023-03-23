namespace ch09;

internal class Program
{
    public static void Main(string[] args)
    {
        IStrategy strategy = new AlipayStrategy();
        strategy.Process();
    }
}