namespace ConsoleCsharp.Patterns.Strategy;

public class CarStrategy : IRouteCalculatorStrategy
{
    public string BuildRoute(string begin, string end)
    {
        System.Console.WriteLine($"Running {this.GetType().Name}...");
        System.Console.WriteLine($"End of {this.GetType().Name}...");
        return $"Starts in {begin}, dirige pra caralho and ends in {end}!";
    }
}
