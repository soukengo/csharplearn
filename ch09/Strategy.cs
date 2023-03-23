using System.Text.Json.Nodes;

namespace ch09;

public interface IStrategy
{
    public void Process();
}

public abstract class AbstractStrategy : IStrategy
{
    private string Name { get; }

    protected AbstractStrategy(string name)
    {
        Name = name;
    }

    public void Process()
    {
        Console.WriteLine("Process: " + Name);
        Console.WriteLine("Params: " + JsonValue.Create(GetParams())?.ToJsonString());
    }

    public abstract Dictionary<string, string> GetParams();
}

public class AlipayStrategy : AbstractStrategy

{
    public AlipayStrategy() : base("alipay")
    {
    }

    public override Dictionary<string, string> GetParams()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("appId", "101");
        dictionary.Add("appKey", "abcde");
        return dictionary;
    }
}

public class WeixinPayStrategy : AbstractStrategy

{
    public WeixinPayStrategy() : base("weixinpay")
    {
    }

    public override Dictionary<string, string> GetParams()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("wxid", "1111");
        dictionary.Add("wxkey", "bbb");
        return dictionary;
    }
}