// See https://aka.ms/new-console-template for more information

using Monitor;

    Publisher pub1 = new Publisher();
    pub1.Name = "BrApi";

    Subscriber sub1 = new Subscriber();
    Subscriber sub2 = new Subscriber();
    Subscriber sub3 = new Subscriber();
    
    sub1.Subscribe(pub1);
    sub2.Subscribe(pub1);
    sub3.Subscribe(pub1);

    pub1.Notify("Preço das Ações");
    
    sub2.UnSubscribe(pub1);
    
    pub1.Notify("Teste");

