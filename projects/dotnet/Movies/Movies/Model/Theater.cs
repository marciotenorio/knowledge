namespace Movies.Model;

public class Theater
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public DateTime OpenTime { get; set; }
    public DateTime CloseTime { get; set; }
    public List<Room> Rooms { get; set; }
    public City City { get; set; }
}