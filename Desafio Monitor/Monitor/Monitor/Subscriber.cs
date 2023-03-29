namespace Monitor;

public class Subscriber
{
    public void Subscribe(Publisher pub)
    {
        pub.Event += Update;
    }
    
    public void UnSubscribe(Publisher pub)
    {
        pub.Event -= Update;
    }
    
    public void Update(object sender, EventArguments args)
    {
        Publisher pub = (Publisher)sender;
        Console.WriteLine(pub.Name + "Preço das ações: " + args.Message);
    }
}