using System.Diagnostics;

var t = new Thread(o =>
{
    Thread.Sleep(3_000);
    Console.WriteLine(Environment.CurrentManagedThreadId);
});

var sw = new Stopwatch();
sw.Start();

t.Start();

sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);