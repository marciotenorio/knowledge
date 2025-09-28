using Lang.Basics;

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
        
        
    }
}
