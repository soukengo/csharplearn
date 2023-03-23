namespace ch08;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new[] {1, 2, 3, 4, 0};
        try
        {
            // int a = arr[5];
            int b = arr[1] / arr[4];
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e);
            // throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}