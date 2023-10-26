namespace ConsoleCsharp.Basics;

/// <summary>
/// - Is the C# way to work with "callback style".
/// - delegates are types that represent references to methods with a particular parameter list
/// and return type.
/// - delegates encapsulate both an object instance and a method.
/// - A delegate can hold references to multiple methods. In this case,
/// the delegate is called a multicast delegate.
/// - It’s important to note that the delegate may call the methods in its invocation list in any order.
/// Therefore, you should not rely on the order of the methods.
/// </summary>
delegate void Greeting(string name);

public class DelegateEx
{
    static void SayHi(string fullName) => Console.WriteLine($"Relou meinn {fullName}");
    static void SayBye(string name) => Console.WriteLine($"Bye {name}");

    delegate bool Callback(int a);
    //Example of callback style
    static List<int> Filter(List<int> numbers, Callback callback)
    {
        var results = new List<int>();

        foreach (var number in numbers)
        {
            if (callback(number))
            {
                results.Add(number);
            }
        }

        return results;
    }

    public static bool IsEven(int x) => x % 2 == 0;

    public DelegateEx()
    {
        Greeting greeting = new Greeting(SayHi);
        
        //Same as SayHi("Márcio"); 
        greeting.Invoke("Márcio");
        
        //Short way to call
        Greeting shortGreeting = SayHi;
        shortGreeting("Tony");
        
        //Example callback
        Console.WriteLine("IsEven:");
        Filter(new List<int>() { 1, 2 }, IsEven)
            .ForEach((a) => Console.WriteLine(a));
        Console.WriteLine("IsOdd");
        Filter(new List<int>(){1, 2, 3}, (a) => a % 2 != 0)
            .ForEach((a) => Console.WriteLine(a));
        
        //Multicast delegate
        Console.WriteLine("Multicast delegate:");
        Greeting multicast = SayHi;
        
        //Delegates are immutable. It means that a delegate cannot be changed once it is created.
        //Therefore, the following creates a new delegate and assigns it to the greeting variable:
        multicast += SayBye;
        multicast("Tenório");
        
        //I can remove a method from delegate's list
        //Note that C# will issue an error if you attempt to call a delegate with an empty invocation list.
        multicast = multicast - SayHi;
        multicast("!!! Remove SayHi from delegates list");
        
        //Invocating a delegate with null check
        multicast -= SayBye;
        // multicast.Invoke("With error without null check!");
        multicast?.Invoke("No error with null check!");
    }
}