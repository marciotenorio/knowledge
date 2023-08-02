using static System.Console;

namespace ConsoleCsharp.Service

{
    internal class IDisposableImpl : IDisposable
    {
        public const string OI = "OI";
        public void Dispose()
        {
            WriteLine("Disposing...");
        }
    }
}
