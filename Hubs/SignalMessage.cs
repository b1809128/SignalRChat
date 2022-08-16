public class SignalMessage
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Receiver { get; set; }
    public object Content { get; set; }

    public SignalMessage()
    {
        Code = "";
        Name = "";
        Receiver = "";
        Content = new object();
    }
}