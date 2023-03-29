namespace Monitor;

public class EventArguments : EventArgs
{
    public string Message { get; set; }

    public EventArguments(string message)
    {
        this.Message = message;
    }
}