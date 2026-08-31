namespace Movies.Model;

public class Session
{
    public long Id { get; set; }
    public Movie Movie { get; set; }
    public DateTime Begin { get; set; }
    public Room Room { get; set; }
    public Theater Theater { get; set; }
}