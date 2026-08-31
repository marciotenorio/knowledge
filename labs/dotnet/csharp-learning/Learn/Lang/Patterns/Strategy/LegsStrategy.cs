namespace Lang.Patterns.Strategy;

public class LegsStrategy : IRouteCalculatorStrategy
{
    public string BuildRoute(string begin, string end)
    {
        System.Console.WriteLine($"Running {this.GetType().Name}...");
        System.Console.WriteLine($"End of {this.GetType().Name}...");
        return $"Starts in {begin}, walks pra caralho and ends in {end}!";
    }
}
