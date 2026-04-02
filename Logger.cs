namespace knightmoves;

public class Logger
{
    public List<string> Messages { get; }

    public Logger()
    {
        Messages = new List<string>();
    }

    public void Log(string message)
    {
        Messages.Add(message);
    }
}
