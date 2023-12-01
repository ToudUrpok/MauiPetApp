namespace MauiPetApp.Data;

[Serializable]
public class Post
{
    public long Id { get; set; }

    public long UserID { get; set; }

    public string Title { get; set; }

    public string Body { get; set; }
}
