namespace StupidComments.Shared;

public class CommentsService
{
    private readonly List<Topic> _allTopics = new()
    {
        new(1, TopicKind.Book, "Ugly Love", new() 
        {
            new (108, "Not wasting any time xD"),
            new (111, "They are hilariously awkward. But I guess neither of them has experience with FWB so that makes sense "),
            new (125, "Okay, that was way more detailed than I expected 😂"),
            new (129, "Thats how you know he really likes her. He’s getting curtains xD"),
            new (132, "Cute that he picks out stuff that she thinks look good"),
            new (138, "I think I should get curtains too xD"),
            new (139, "Oh, no more details? :("),
            new (142, "Late as in maybe pregnant?! 😱 That’s gonna make it way more complicated for them. "),
            new (149, "How much can one talk about *sleep* xD "),
            new (151, "All men just want one thing. Sleep xD"),
            new (157, "That „wow. Okay, then“ made me laugh, I don’t know why xD"),
            new (162, "Not Bad. That were like 6 pages of a lot of details xD and it kinda feels hot in here 🥵"),
            new (165, "Kinda feeling bad for her. She seems to be in love with Miles, but with his rules, she might never her from him what she wants. On the other hand, it’s a book with hopefully a Happy End xD"),
            new (169, "I was right. But very nice how supportive he is. Not asking for an abortion or something like that (thinking about it, that probably isn’t even an option in religious USA), but searching how to make it work. respect. "),
            new (170, "I just said on page 165 how I feel bad for her, and she is now thinking about it too!"),
            new (173, "I hate Dillon"),
            new (185, "Wow, that was quite rude how he just left her without saying anything. I’m sure there will be a reason for it, but that really wasn’t nice. "),
            new (194, "Weird how Tate even thinks that she did something wrong to upset him. Nothing she could do would make it okay how he treated her. But I’m curious what will come out of this conversation. "),
            new (197, "MOOOOO. Sorry, that was inappropriate. Sad what happened in this chapter, but I totally expect a Happy End. So I just wanna keep reading and see them become a real couple. "),
            new (205, "Haha, he’s jealous"),
            new (209, "I think it’s funny how they don’t just have sex, but there also are these games they are playing during it 😂 like in the car before"),
            new (210, "They seem really good together. I hope Miles can fix his issues somehow."),
            new (211, "Miles is a fucking liar. He does love her. I don’t believe anything else!"),
            new (215, "I still think he is in love with her. But he forbids himself to feel that way, probably because of what happened to Rachel. I have a theory btw, maybe there were complications during birth and she and the baby passed away. That could fuck you up how Miles is. "),
            new (219, "Glad they are still living together and their parents didn’t kill them"),
            new (223, "A kiss is not just a kiss is not just a kiss. I thought she knew that 🙈"),
            new (224, "I don’t know if sex without feelings is possible. Maybe it takes a special kind of person for that, but I couldn’t do that. "),
            new (229, "Oooh, it’s happening! I guess I will know soon if my theory is right or not. "),
            new (232, "Okay seems like the birth was all good. Phew. But now I’m clueless again what broke him. I wanna know so bad xD Do I have to read the whole night?"),
            new (235, "Cap is funny. I like Cap. "),
            new (236, "Thats scary. Hope Corbin is fine. "),
            new (243, "It’s quite late now, and I’m very tired. But next chapter is one from the past, they are usually short. I can read one more, and then should go to bed…"),
            new (245, "Circumcision is weird. If there are medical reasons for it okay, but other than that, I don’t think it’s good. "),
            new (248, "Im glad his father is accepting. For some reason I expect all dads to be assholes, just like in the last book xD The next chapter is just 10 pages… that’s not too much, just that one more xD "),
            new (250, "Haha, of course he likes the bikini xD"),
            new (251, "Im remembering Italy now, and the pool, and how much fun it was jumping in it with you"),
            new (257, "*He sees me for exactly who I am. I don’t see him at all.* I think that was a special part. Memorable and very true for her. Sadly. But hey, another chapter in the past. Really the last one now, I gotta sleep xD"),
            new (259, "See, a really short chapter. A nice one tho. Good for his dad that he didn’t cheat on his previous wife. And now I go sleep. "),
            new (263, "It took her a long time to realize that she can’t handle the situation. Miles seems good with it, but she always wanted more. "),
            new (265, "I don’t really feel bad for Miles in this moment, because all Tate said is the truth. Let’s see what happens, maybe an explanation finally. "),
            new (273, "That was… wow. Not quite what I expected (complications during child birth) but it seems like he still lost both of them during it. No wonder he never wants to love again. Can’t imagine the pain and hurt. "),
            new (275, "Uh oh. That’s the wrong name. I had the theory that he doesn’t look in her eyes during sex, because he imagines her to be Rachel instead. "),
            new (278, "That was weird… I don’t know what to say. From crying to horny to devastated in like a minute."),
            new (280, "Miles found some good words. I already thought the *Just finish* from Tate was weird. But yeah, it kinda does sound like a job. Like something to just get over with. Terrible. It’s supposed to be full of love. "),
            new (282, "Poor Miles. I understand what he means with ugly side of love. That’s what hurts so much. When you love someone, open up to them, let them in. They know you deeply. And then it doesn’t work out, and you’re more devastated than if you never loved in the first place. "),
            new (286, "I tell you, he does love her"),
            new (287, "Ian is a good friend. Telling him he’s an idiot xD "),
            new (290, "That was really nice what Ian said"),
            new (302, "So glad that Rachel could help him. I’m just crying a little right now. "),
            new (306, "Do you know how hard it is to read with even more tears in your eyes?"),
            new (308, "I told you that you can’t not love. If you do, you do. Just like it happened with Miles. "),
            new (309, "He flew in love with her. That sounds cute"),
            new (311, "I knew he loved her the entire time!"),
            new (314, "Is he gonna propose to her? Is that’s what is happening? Definitely setting a very high bar for all men xD"),
            new (316, "Oh he got me good with that key first xD"),
            new (318, "The end"),
            new (322, "It’s the beautiful moments like these that make up for the ugly love."),
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