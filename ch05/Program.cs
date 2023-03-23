namespace ch05;

public class Program
{
    const int a = 1;
    public static int b = 2;

    public static void Main(string[] args)
    {
        var i = 0;
        while (i < 10)
        {
            Console.WriteLine("while: " + i++);
        }

        do
        {
            i++;
            Console.WriteLine("do while: " + i++);
        } while (i < 10);

        for (var j = 0; j < i; j++)
        {
            Console.WriteLine("for: " + j);
        }

        int[] ages = {34, 12, 56, 67, 2, 3, 4, 6, 6, 2};

        Console.Write(ages.Length);
        for (var k = 0; k < ages.Length; k++)
        {
            Console.Write(ages[k] + " ");
        }

        foreach (var t in ages)
        {
            Console.Write(t + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Sum: " + Add(1, 2, 3, 4, 5));
        Dictionary<string, string> map = new Dictionary<string, string>();
        map.Add("a", "0");
        map.Add("b", "1");
        map.Add("c", "2");

        foreach (var kv in map)
        {
            Console.WriteLine("k: {0} v: {1}", kv.Key, kv.Value);
        }
    }

    private static int Add(params int[] values)
    {
        values[0] = 1;
        return values.Sum();
    }
}