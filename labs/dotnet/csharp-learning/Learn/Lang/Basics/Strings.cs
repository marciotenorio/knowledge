using System.Security.Cryptography;
using System.Text;

namespace Lang.Basics;

/// <summary>
/// <see href="https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/"/>
/// </summary>
public class Strings
{
    public Strings()
    {
        // Verbatim string. @ tells to treat backslashes as ordinary character.
        // Can have multiple lines. 
        // Because backslash no longer escapes quotes, a quote is represented by doubling it.
        string verbatim = @"write path without scapes: c:\folder\hehe.exe ""hello"" ";

        // $ enable interpolation. For each $ -> {}, $$ -> {{}}, ...
        // Scape for { is {{
        string interpolated = $"Eae mermao {2 + 2}";

        string interpolatedVerbabim = $@"Path: c:\here\{nameof(Strings)}";

        //Default do C# é UTF16
        string ut8Encoded = Encoding.UTF8.GetBytes("hehe").ToString();
        //Works on C# 11
        //string utf8EncodedImproved = "hehe"u8.ToString();

        string str1 = @"Oi";
        string str2 = @"Oi";
        // == funciona aqui, diferente do Java
        Console.WriteLine(str1.Equals(str2));

        //Raw strings. """... acts as delimiter 
        // " quantity are based on necessity in the number of " together.
        // Available only in csharp 11
        string rawString = """" ola """oi""" tudo bem """";

        //Error when use json syntax like { field }, use $$ instead
        // var json = $""" {"Name": "{name}" } """;
        var json = $$""" { "Name": "{{nameof(Strings)}}" } """;


        // $"""Value: {value}"""           // Interpolated raw string
        // $$"""JSON: { "v": {{value}} }""" // Interpolated raw with 2 $
    }
}