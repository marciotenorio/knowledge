namespace ConsoleCsharp.Patterns.Mediator;

public class TextBox : BaseComponent
{
    public string Text { get; set; }

    public TextBox(IMediator mediator = null) : base(mediator)
    {
    }

    public void FinishWrite(string text)
    {
        Console.WriteLine("[TextBox]");
        Console.WriteLine("Finish write.");
        Text = text;
        this._mediator.Notify(this, "FinishWrite");
    }

    public void Warning()
    {
        Console.WriteLine("[TextBox]");
        Console.WriteLine("Invalid text, write again...");
    }
}
