using System.Runtime.CompilerServices;
using Lang.Basics;
using Microsoft.VisualBasic;

namespace Lang;

public class Program
{
    static void Main(string[] args)
    {
        /* Basics */

        // DocumentationTags doc = new DocumentationTags();

        // BuiltInValueTypes valueTypes = new BuiltInValueTypes();

        // BuiltInReferenceTypes referenceTypes = new BuiltInReferenceTypes();  

        // Strings strings = new Strings();

        // Arrays arrays = new Arrays();

        // ListPatterns listPatterns = new ListPatterns();

        // AnonymousMethod anonymousMethod = new AnonymousMethod();

        // CliDoc cli = new CliDoc();

        // DelegateEx delegateEx = new DelegateEx();

        // DocumentationTags doc = new DocumentationTags();

        // InKeyword inKeyword = new InKeyword();

        // ForEach forEach = new ForEach();

        // using (var diposableResource = new DisposableImpl())
        // {
        //     Console.WriteLine("Inside using block...");
        // }

        /* Patterns */
        // FacadeConverter facadeConverter = new FacadeConverter();
        // Console.WriteLine("Path result is " + facadeConverter.ConvertAudio("c:/here", "mp3"));
        // Console.WriteLine("Path result is " + facadeConverter.ConvertVideo("c:/here", "av"));

        //Mediator
        // var textBox = new TextBox();
        // var button = new Button();
        // var _ = new ConcreteMediator(textBox, button);

        // textBox.FinishWrite("Márcio Tenório................");
        // textBox.FinishWrite("Márcio Tenório");

        //Strategy
        // var tripCalculator = new TripCalculator();
        // var carStrategy = new CarStrategy();

        // tripCalculator.SetStrategy(carStrategy);
        // System.Console.WriteLine(tripCalculator.BuildRoute("Touros", "Natal"));

        // System.Console.WriteLine("---------------------------------------------");

        // var legsStrategy = new LegsStrategy();
        // tripCalculator.SetStrategy(legsStrategy);

        // System.Console.WriteLine(tripCalculator.BuildRoute("Natal", "Touros"));

        // tripCalculator.SetStrategy(null);
        // tripCalculator.BuildRoute("", "");

        //----------- ref, in and out -----------

        System.Console.WriteLine("---- assign inside method ----");
        var some1 = new SomeObject{ SomeInt = 1, SomeStr = "Some1" };
        System.Console.WriteLine($"{RuntimeHelpers.GetHashCode(some1)}: {some1}");
        OutRefIn.AssignInsideMethod(some1);
        System.Console.WriteLine($"{RuntimeHelpers.GetHashCode(some1)}: {some1}");

        System.Console.WriteLine("---- out ----");
        var some2 = new SomeObject{ SomeInt = 2, SomeStr = "Some2" };
        System.Console.WriteLine($"{RuntimeHelpers.GetHashCode(some2)}: {some2}");
        OutRefIn.TryOut(out some2);
        System.Console.WriteLine($"{RuntimeHelpers.GetHashCode(some2)}: {some2}");

        OutRefIn.TryOut(out var outObjGenerated); //getting only the result

        System.Console.WriteLine("---- ref ----");
        var some3 = new SomeObject{ SomeInt = 3, SomeStr = "some3" };
        System.Console.WriteLine($"{RuntimeHelpers.GetHashCode(some3)}: {some3}");
        OutRefIn.TryRef(ref some3);
        System.Console.WriteLine($"{RuntimeHelpers.GetHashCode(some3)}: {some3}");

        System.Console.WriteLine("---- in ----");
        var some4 = new SomeObject{ SomeInt = 4, SomeStr = "some4" };
        System.Console.WriteLine($"{RuntimeHelpers.GetHashCode(some4)}: {some4}");
        //you can omit the "in" and pass using ref (will be handled as "in" inside the method)
        OutRefIn.TryIn(some4);
        System.Console.WriteLine($"{RuntimeHelpers.GetHashCode(some4)}: {some4}");
    }
}
