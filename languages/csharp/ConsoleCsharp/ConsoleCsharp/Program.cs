

using ConsoleCsharp.Service;
using ConsoleCsharp.Topics;
using System.Numerics;

public class Program
{
	static void Main(string[] args)
	{
		int a = default;
		long l = a;
		a = (int)l;
		float b = 1.3487F;
		double c = 10.5D;
		string d;
		bool e;
		char f;

		System.Int64 ka = 2, some = 3, someMore = 4;

        Console.WriteLine($"The age is {a}");
		Console.WriteLine($"Learning print floating points numbers: {b:0.###}");
		FloatPointPrecisionPrint fp = new FloatPointPrecisionPrint();
		Console.WriteLine(int.MinValue);
		Strings strs = new Strings();
		Bools bools = new Bools();
    }
}