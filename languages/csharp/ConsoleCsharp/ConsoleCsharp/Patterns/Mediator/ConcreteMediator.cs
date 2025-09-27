namespace ConsoleCsharp.Patterns.Mediator;

/// <summary>
/// Simplifica a comunicação entre os objetos.
/// </summary>
public class ConcreteMediator : IMediator
{
    private readonly TextBox _textBox;
    private readonly Button _button;

    public ConcreteMediator(TextBox textBox, Button button)
    {
        _textBox = textBox;
        _textBox.SetMediator(this);
        _button = button;
        _button.SetMediator(this);
    }

    public void Notify(object sender, string ev)
    {
        Console.WriteLine("[ConcreteMediator]");
        if (ev == "FinishWrite")
        {
            Console.WriteLine("Mediator reacts on TextBox and triggers following operations:");

            if (((TextBox)sender).Text.Length < 20)
            {
                Console.WriteLine("TextBox has a valid length.");
                _button.DoSomething();
            }
            else
            {
                Console.WriteLine("TextBox don't have a valid length, not calling button...");
                _textBox.Warning();
            }
        }
    }
}
