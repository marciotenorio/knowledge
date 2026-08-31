namespace Movies.Model;

public class Schedule
{
    public long Id { get; set; }
    public List<Movie> MainMovies { get; set; }
    public TYPE Type { get; set; }
}