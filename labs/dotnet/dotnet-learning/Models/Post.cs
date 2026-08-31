namespace DotNetLearning.Models;

public class Post
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateOnly PublishedOn { get; set; }
    public bool Archived { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}