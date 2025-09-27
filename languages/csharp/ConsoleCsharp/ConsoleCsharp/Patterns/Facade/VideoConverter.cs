using System;

namespace ConsoleCsharp.Patterns;

/// <summary>
/// Simulate a complex video converter that need to deal with a complex set of classes
/// </summary>
public class VideoConverter
{
    public string Convert(string path, string type)
    {
        Console.WriteLine("Calling a complex subsystem of classes to convert your video...");
        Console.WriteLine("Disposing resources...");
        Console.WriteLine("Audio conversion fineshed...");

        return $"Video from {path} converted to {type}!";
    }
}
