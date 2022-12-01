namespace StupidComments.Shared;

public class CommentsService
{
    private readonly List<Topic> _allTopics = new()
    {
        new(1, TopicKind.Book, "Ugly Love", new() 
        {
            new(101, "Bla"),
            new(102, "Bla nochmal"),
            new(103, "So geht das doch nicht!"),
        })
    };

    public List<Topic> GetTopics(TopicKind kind)
    {
        return this._allTopics.Where(f => f.Kind == kind).ToList();
    }

    public Topic GetTopic(int id)
    {
        return this._allTopics.First(f => f.Id == id);
    }
}

public enum TopicKind
{
    Book
}

public record CommentItem(int Number, string Comment);
public record Topic(int Id, TopicKind Kind, string Title, List<CommentItem> Comments);