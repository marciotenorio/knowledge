namespace Lang.Patterns.Strategy;

public class TripCalculator
{
    private IRouteCalculatorStrategy _routeCalculatorStrategy;

    public TripCalculator(IRouteCalculatorStrategy strategy)
    {
        _routeCalculatorStrategy = strategy;
    }

    public TripCalculator()
    {
    }

    public void SetStrategy(IRouteCalculatorStrategy strategy) => _routeCalculatorStrategy = strategy;

    public string BuildRoute(string begin, string end)
    {
        System.Console.WriteLine("Gathering data...");
        System.Console.WriteLine("Validate user infos...");

        if (_routeCalculatorStrategy is null)
        {
            throw new NotImplementedException("You should provide a trip strategy...");
        }
        
        var route = _routeCalculatorStrategy.BuildRoute(begin, end);
        System.Console.WriteLine("Disposing resources...");
        return route;
    }
}