namespace Monitor;

public class Publisher
{
    public string Name { get; set; }
    public event EventHandler<EventArguments>? Event; //Manipulador de eventos

    public void Notify(string message)
    {
        EventArguments args = new EventArguments(message);
        if (Event != null) Event(this, args);
        
    }
}