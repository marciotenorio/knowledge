namespace Movies.Model;

public class User
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public List<Genre> MostViewedGenres { get; set; }
}