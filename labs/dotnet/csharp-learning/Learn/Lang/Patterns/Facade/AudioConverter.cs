namespace Lang.Patterns.Facade;

public class AudioConverter
{
    public string Convert(string path, string type)
    {
        Console.WriteLine("Calling a complex subsystem of classes to convert your audio...");
        Console.WriteLine("Disposing resources...");
        Console.WriteLine("Audio conversion fineshed...");

        return $"Audio from {path} converted to {type}!";
    }
}
