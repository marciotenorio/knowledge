namespace Lang.Basics;

public class AnonymousMethod
{
    private delegate int Transformer(int x);
    public AnonymousMethod()
    {
        //An anonymous method uses the delegate keyword followed
        // by an optional parameter declaration and method body.
        //C# allows you to create a delegate and immediately assign a code block to it.
        //This code block can be either an anonymous method or a lambda expression.
        //The following statement defines an anonymous method and assigns it to the Transformer delegate:
        Transformer transform = delegate (int x) { return x * x; };
        Console.WriteLine(transform(10));
    }
}