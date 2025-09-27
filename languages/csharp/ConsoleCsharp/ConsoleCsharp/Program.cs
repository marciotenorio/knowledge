

using ConsoleCsharp.Basics;
using ConsoleCsharp.Patterns.Strategy;
using ConsoleCsharp.Service;
using ConsoleCsharp.Topics;
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

		var tripCalculator = new TripCalculator();
		var carStrategy = new CarStrategy();

		tripCalculator.SetStrategy(carStrategy);
		System.Console.WriteLine(tripCalculator.BuildRoute("Touros", "Natal"));

		System.Console.WriteLine("---------------------------------------------");

		var legsStrategy = new LegsStrategy();
		tripCalculator.SetStrategy(legsStrategy);

		System.Console.WriteLine(tripCalculator.BuildRoute("Natal", "Touros"));

		tripCalculator.SetStrategy(null);
		tripCalculator.BuildRoute("", "");
	}
}