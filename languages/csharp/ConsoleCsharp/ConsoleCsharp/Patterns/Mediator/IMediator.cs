namespace ConsoleCsharp.Patterns;

public interface IMediator
{
    void Notify(object sender, string ev);
}