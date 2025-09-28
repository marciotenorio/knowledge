namespace Lang.Basics;

/// <summary>
/// The integral numeric types represent integer numbers. 
/// All integral numeric types are value types. 
/// They're also simple types and can be initialized with literals. 
/// All integral numeric types support arithmetic, bitwise logical, comparison, and equality operators.<br/>
/// 
/// <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types"/>
/// Search for suffixed.
/// </summary>
public class BuiltInValueTypes
{
    public BuiltInValueTypes()
    {
        Console.WriteLine($"=== {this.GetType().Name} ===");

        int a = default;
        long l = 99L;
        ulong unsignedLong = 99UL;
        a = (int)l;
        float b = 1.3487F;
        double c = 10.5D;
        decimal money = 10M;
        uint unsignedInt = 10u;
        bool e;
        char f;
        bool result = "oi" == "oi";

        Console.WriteLine(result);

        System.Int64 ka = 2, some = 3, somemore = 4;

        Console.WriteLine($"The age is {a}");
        Console.WriteLine($"Learning print floating points numbers: {b:0.###}");
        double fp = 19_000.349834D;
        Console.WriteLine($"Define float point precision in print: {fp:0.##}");
    }
}

