namespace ConsoleCsharp.Patterns.Mediator;

public class Button : BaseComponent
{
    public Button(IMediator mediator = null) : base(mediator)
    {
    }
    
    public void DoSomething()
    {
        Console.WriteLine("[Button]");
        Console.WriteLine("Finish action!");
    }
}
