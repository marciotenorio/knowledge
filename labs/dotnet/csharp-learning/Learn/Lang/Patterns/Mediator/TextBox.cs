namespace Lang.Patterns.Mediator;

public class TextBox(IMediator mediator = null) : BaseComponent(mediator)
{
    public string Text { get; set; }

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
