namespace ConsoleCsharp.Patterns;

/// <summary>
/// Simplifica a interface para quem consome.
/// </summary>
public class FacadeConverter
{
    protected VideoConverter _videoConverter;
    protected AudioConverter _audioConverter;

    public FacadeConverter()
    {
        _videoConverter = new VideoConverter();
        _audioConverter = new AudioConverter();
    }


    public string ConvertAudio(string path, string type)
    {
        return _audioConverter.Convert(path, type);
    }

    public string ConvertVideo(string path, string type)
    {
        return _videoConverter.Convert(path, type);
    }
}
