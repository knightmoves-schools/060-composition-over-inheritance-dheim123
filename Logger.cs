namespace knightmoves;

public class Logger
{
    public List<string> Messages { get; }
    private readonly Logger _parentLogger;

    public Logger()
    {
        Messages = new List<string>();
    }

    public Logger(Logger parentLogger) :封装 this()
    {
        _parentLogger = parentLogger;
    }

    public void Log(string message)
    {
        Messages.Add(message);
        _parentLogger?.Log(message);
    }
}
