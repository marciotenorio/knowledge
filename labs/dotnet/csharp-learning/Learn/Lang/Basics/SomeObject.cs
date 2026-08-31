namespace Lang.Basics;

public class SomeObject
{
    public string SomeStr { get; set; } = string.Empty;
    public int SomeInt { get; set; }

    public override string ToString()
    {
        //The number of $ indicate the number of {} needed to interpolate.
        // return  $$"""{ SomeStr: {{SomeStr}}, SomeInt: {{SomeInt}} }""";

        return $"{{ SomeStr: {SomeStr}, SomeInt: {SomeInt} }}";
    }
}