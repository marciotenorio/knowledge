using System.Text;

namespace ConsoleCsharp.Topics
{
    public class Strings
    {
        public Strings()
        {
            string verbatim = @"write path without scapes: c:\folder\hehe.exe";
            string interpolated = $"Eae mermao {2 + 2}";
            //Default do C# é UTF16
            string ut8Encoded = Encoding.UTF8.GetBytes("hehe").ToString();
            //Works on C# 11
            //string utf8EncodedImproved = "hehe"u8.ToString();

            string str1 = @"Oi";
            string str2 = @"Oi";
            // == funciona aqui, diferente do Java
            Console.WriteLine(str1.Equals(str2));

            //Raw strings. " quantity are based on necessity in the number of " together.
            // Available only in csharp 11
            //string rawString = """" ola tudo bem """"";
            //Error when use json syntax like { field }, use $$ instead
            //var json = $""" {"Name": "{name}" } """;
            //var json = $$""" { "Name": "{{name}}" } """;
        }
    }
}
