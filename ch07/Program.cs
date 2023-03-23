namespace ch07;

internal class Program
{
    private static void OnSuccess(int code, string message, object data)
    {
        Console.WriteLine("code: {0}, message: {1}, data: {2}", code, message, data);
    }

    public static void Main(string[] args)
    {
        Callback callback = OnSuccess;
        Do(callback);
    }


    public static void Do(Callback callback)
    {
        callback(1, "hello", true);
    }
}

delegate void Callback(int code, string message, object data);