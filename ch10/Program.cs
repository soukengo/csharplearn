using System.Collections;

namespace ch10;

internal class Program
{
    public static void Main(string[] args)
    {
        var list = new List<int>();
        list.Add(4);
        list.Add(2);
        list.Add(1);
        list.Add(6);
        list.Add(5);
        list.Add(3);
        list.Sort();
        Console.WriteLine(string.Join(",", list));

        var set = new SortedSet<string>();
        set.Add("a");
        set.Add("a");
        set.Add("b");
        Console.WriteLine(string.Join(",", set));

        var stack = new Stack<int>();

        for (var i = 0; i < 10; i++)
        {
            stack.Push(i);
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(stack.Pop());
        }

        var queue = new Queue<int>();
        for (var i = 0; i < 10; i++)
        {
            queue.Enqueue(i);
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}