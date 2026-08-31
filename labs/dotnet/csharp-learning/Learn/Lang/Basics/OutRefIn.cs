using System.Runtime.CompilerServices;

namespace Lang.Basics;

public class OutRefIn
{

    /// <summary>
    /// In methods values types are copied and reference types, the reference is copied.
    /// It means that for reference, change properties are reflected to outside of method and assignment not works.
    /// </summary>
    public static void AssignInsideMethod(SomeObject someObj)
    {
        someObj.SomeStr = "Tony";
        someObj = new SomeObject
        {
             SomeInt = 10,
             SomeStr = "Toninho"
        };

        System.Console.WriteLine($"{RuntimeHelpers.GetHashCode(someObj)}: {someObj}");
    }

    /// <summary>
    /// You can only overload using ONE modifier.
    /// Ex: You already has a overload using 'ref'(this), you can't create other using 'out'.
    /// </summary>
    /// <param name="someObj"></param>
    public static void AssignInsideMethod(ref SomeObject someObj)
    {
        someObj.SomeStr = "Tony";
        someObj = new SomeObject
        {
             SomeInt = 10,
             SomeStr = "Toninho"
        };

        System.Console.WriteLine($"{RuntimeHelpers.GetHashCode(someObj)}: {someObj}");
    }

    /// <summary>
    /// out is used to state that the parameter passed must be modified by the method.
    /// The parameter can be null or not. 
    /// A new assignment here change the callee object reference.
    /// </summary>
    public static void TryOut(out SomeObject someObj)
    {
        // obj.SomeInt = 10; // not works
        someObj = new SomeObject
        {
            SomeInt = 99,
            SomeStr = "Out"
        };

        System.Console.WriteLine($"{RuntimeHelpers.GetHashCode(someObj)}: {someObj}");
    }

    /// <summary>
    /// ref is used to state that the parameter passed may be modified by the method.
    /// The parameter can be null or not. 
    /// A new assignment here change the callee object reference.
    /// </summary>
    public static void TryRef(ref SomeObject someObj)
    {
        //Do nothing works

        someObj.SomeInt = 10; // works

        //works
        // someObj = new SomeObject
        // {
        //     SomeInt = 100,
        //     SomeStr = "Ref"
        // };

        System.Console.WriteLine($"{RuntimeHelpers.GetHashCode(someObj)}: {someObj}");
    }

    /// <summary>
    /// in is used to state that the parameter passed cannot be modified by the method.
    /// The parameter can be null or not. 
    /// </summary>
    public static void TryIn(in SomeObject someObj)
    {
        //Do nothing works

        someObj.SomeInt = 10; // works

        //not works
        // obj = new SomeObject
        // {
        //     SomeInt = 100,
        //     SomeStr = "Ref"
        // };

        System.Console.WriteLine($"{RuntimeHelpers.GetHashCode(someObj)}: {someObj}");
    }
}