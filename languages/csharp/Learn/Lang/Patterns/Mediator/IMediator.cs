namespace Lang.Patterns.Mediator;

public interface IMediator
{
    void Notify(object sender, string ev);
}