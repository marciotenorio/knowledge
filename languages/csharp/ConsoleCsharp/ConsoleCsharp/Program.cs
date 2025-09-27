

using ConsoleCsharp.Basics;
using ConsoleCsharp.Patterns;
using ConsoleCsharp.Patterns.Mediator;
using ConsoleCsharp.Service;
using ConsoleCsharp.Topics;
using Microsoft.VisualBasic;
using System.Numerics;

public class Program
{
	static void Main(string[] args)
	{
		// FloatPointPrecisionPrint fp = new FloatPointPrecisionPrint();
		//Console.WriteLine(int.MinValue);
		//Strings strs = new Strings();
		//Bools bools = new Bools();

		//DefaultParameters defaultParameters = new DefaultParameters();
		//defaultParameters.DefaultParametersExample();
		// Arrays arrs = new Arrays();
		//int[] arr = {1,2,3, 4, 5};
		//arrs.myFunc(arr);
		//Console.WriteLine(arr[0]);
		// Arrays arrs = default;
		// System.Console.WriteLine("Oi");

		// DelegateEx delegateEx = new DelegateEx();
		// AnonymousMethod anonymousMethod = new AnonymousMethod();
		// LambdaExpression le = new LambdaExpression();

		// FacadeConverter facadeConverter = new FacadeConverter();
		// Console.WriteLine("Path result is " + facadeConverter.ConvertAudio("c:/here", "mp3"));
		// Console.WriteLine("Path result is " + facadeConverter.ConvertVideo("c:/here", "av"));

		var textBox = new TextBox();
		var button = new Button();
		var _ = new ConcreteMediator(textBox, button);

		textBox.FinishWrite("Márcio Tenório................");
		textBox.FinishWrite("Márcio Tenório");
	}
}