namespace Movies.Model;

public class Movie
{
    public long Id { get; set; }
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    public List<Genre> Genres { get; set; }
    public List<CastMember> Actors { get; set; }
    public List<CastMember> Directors { get; set; }
}