namespace Lang.Basics;

public class LambdaExpression
{
    public LambdaExpression()
    {
        //A lambda expression is an anonymous method written in place of a delegate instance.
        //A lambda expression is used to create an anonymous function.
        //A lambda expression can have one of two forms: expression lambda and statement lambda.
        // '=>' is called lambda operator
        // (parameters) => expression or (parameters) => { statements; }
        
        //If a lambda expression has exactly one parameter and the C# compiler can infer the type
        //of the parameter, you can omit the parentheses like this:
        //Func<T, TResult> lambda = parameter => expression;
        
        var square = (int x) => x * x;
        Console.WriteLine(square(2));
        
        //Note that you can explicitly specify the return type of a lambda expression.
        var square2 = int (int x) => x * x;
        Console.WriteLine(square2(10));
        
        //When the C# compiler encounters a lambda expression, it converts the lambda expression
        //to a delegate instance.
        //In the above example, the C# compiler converts the lambda expression to Func<int,int>.

        //Because the Func<int, int> accepts an integer and returns an integer, we don’t need to explicitly specify
        //the type for the input parameter of the lambda expression. Therefore, we can omit the parentheses.
        Func<int, int> square3 = x => x * x;
        var result = square3(15);
        Console.WriteLine(result);
        
        //A lambda expression can reference any variables including local variables, parameters, and members
        //that are accessible from the location where you define the lambda expression.
        //These variables are called outer variables.
        //The variables referenced by a lambda expression are known as captured variables.
        //When a lambda expression has captured variables, it is called a closure. 
        Console.WriteLine("-----Closure example-----");
        int factor = 10;

        var multiplier = (int x) => x * factor;
        var result2 = multiplier(10);
        Console.WriteLine(result2); // 100

        //It’s important to note that the lambda expression evaluates the captured variables when it is executed,
        //not when the variables were captured
        factor = 2;
        result2 = multiplier(10);
        Console.WriteLine(result2); //20
        
        //Another example:
        Console.WriteLine("-----Another closure example-----");
        var multipliers = new List<Func<int, int>>();

        for(int i = 1; i <= 3; i++)
        {
            multipliers.Add(x => x * i);
        }
        
        foreach (var multipler in multipliers)
        {
            int result3 = multipler(10); //i always equals 4, is the value in the end of the for loop
            Console.WriteLine(result3); 
        }
        
        //Fixing the problem of fixed i in the closure above
        Console.WriteLine("-----Fixing the fixed i=4 outer variable in the back closure-----");
        var multipliers2 = new List<Func<int, int>>();

        for(int i = 1; i <= 3; i++)
        {
            //In this example, each iteration creates a new factor variable. Therefore,
            //each lambda expression captures a different variable.
            int factor2 = i;
            multipliers2.Add(x => x * factor2);
        }

        foreach (var multipler in multipliers2)
        {
            int result4 = multipler(10); 
            Console.WriteLine(result4);
        }
        
        //Static lambda expressions
        //When a lambda expression captures variables, the C# compiler needs to create a private class and instantiate
        //it to store a reference to the captured variables. This incurs a small performance.
        //Starting with C# 9, you can use a static keyword to ensure that the lambda expression doesn’t
        //capture any variables. For example:

        // var outerVar = 2;
        // var square4 = static (int x) => x * outerVar; //error you can't do this in a static lambda expression.
        
    }
}