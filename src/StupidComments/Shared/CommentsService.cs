namespace StupidComments.Shared;

public class CommentsService
{
    private readonly List<Topic> _allTopics = new()
    {
        new(1, TopicKind.Book, "Ugly Love", new() 
        {
            new(1, "Bla"),
            new(50, "Bla"),
            new(101, "Bla"),
            new(102, "Bla nochmal"),
            new(103, "So geht das doch nicht!"),
            new(104, "So geht das doch nicht!"),
            new(105, "So geht das doch nicht!"),
            new(106, "So geht das doch nicht!"),
            new(107, "So geht das doch nicht!"),
            new(108, "So geht das doch nicht!"),
            new(109, "So geht das doch nicht!"),
            new(110, "So geht das doch nicht!"),
            new(111, "Bla"),
            new(112, "Bla nochmal"),
            new(113, "So geht das doch nicht!"),
            new(114, "So geht das doch nicht!"),
            new(115, "So geht das doch nicht!"),
            new(116, "So geht das doch nicht!"),
            new(117, "So geht das doch nicht!"),
            new(118, "So geht das doch nicht!"),
            new(119, "So geht das doch nicht!"),
            new(120, "So geht das doch nicht!"),
            new(121, "Bla"),
            new(122, "Bla nochmal"),
            new(123, "So geht das doch nicht!"),
            new(124, "So geht das doch nicht!"),
            new(125, "So geht das doch nicht!"),
            new(126, "So geht das doch nicht!"),
            new(127, "So geht das doch nicht!"),
            new(128, "So geht das doch nicht!"),
            new(129, "So geht das doch nicht!"),
            new(201, "Bla"),
            new(202, "Bla nochmal"),
            new(203, "So geht das doch nicht!"),
            new(301, "Bla"),
            new(302, "Bla nochmal"),
            new(303, "So geht das doch nicht!"),
            new(401, "Bla"),
            new(402, "Bla nochmal"),
            new(403, "So geht das doch nicht!"),
            new(501, "Bla"),
            new(502, "Bla nochmal"),
            new(503, "So geht das doch nicht!"),
            new(601, "Bla"),
            new(602, "Bla nochmal"),
            new(603, "So geht das doch nicht!"),
            new(701, "Bla"),
            new(702, "Bla nochmal"),
            new(703, "So geht das doch nicht!"),
            new(8888, "So geht das doch nicht!"),
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