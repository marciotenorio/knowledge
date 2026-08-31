namespace Movies.Model;

public class Room
{
    public long Id { get; set; }
    public Theater Theater { get; set; }
    public RoomType Type { get; set; }
    public List<Seat> Seats { get; set; }
}