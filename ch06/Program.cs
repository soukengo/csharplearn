namespace ch06;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Read: {0}", Color.Read.GetHashCode());
        Console.WriteLine(Color.Blue.GetHashCode());
        Console.WriteLine(Color.Yellow.GetHashCode());

        var p = new Pairs("a", "101");
        Console.WriteLine(p);
        Console.WriteLine(p.Key);
        Console.WriteLine(p.Value);
        Console.WriteLine(p.Value = "0000");
    }

    public enum Color
    {
        Read,
        Blue,
        Yellow = 5
    }

    struct Pairs
    {
        public string Key;

        public string Value;

        public Pairs(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return "key: " + Key + ",value: " + Value;
        }
    }
}