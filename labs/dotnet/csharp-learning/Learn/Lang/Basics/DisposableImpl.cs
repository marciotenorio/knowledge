using static System.Console;

namespace Lang.Service

{
    internal class DisposableImpl : IDisposable
    {
        public const string OI = "OI";
        public void Dispose()
        {
            WriteLine("Disposing...");
        }
    }
}
