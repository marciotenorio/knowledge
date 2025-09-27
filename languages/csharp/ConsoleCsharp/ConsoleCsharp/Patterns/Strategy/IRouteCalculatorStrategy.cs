namespace ConsoleCsharp.Patterns.Strategy;

public interface IRouteCalculatorStrategy
{
    string BuildRoute(string begin, string end);
}
