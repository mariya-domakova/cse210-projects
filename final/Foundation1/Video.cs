public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Length { get; set; }
    public List<Comment> Comments { get; } = new List<Comment>();

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int CountComments()
    {
        return Comments.Count;
    }
}