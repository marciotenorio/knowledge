namespace Movies.Model;

public class CastMember
{
    public long Id { get; set; }
    public string Name { get; set; }
    public Movie Movie { get; set; }
    public Role Role { get; set; }
}