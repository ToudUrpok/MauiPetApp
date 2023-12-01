using System.Text.Json;

namespace MauiPetApp.Data;

public static class PostsManager
{
    static readonly string BaseAddress = "https://jsonplaceholder.typicode.com";
    static readonly string Url = $"{BaseAddress}/";
    static readonly long UserId = 1;

    static HttpClient client;
    static Dictionary<long, Post> posts = new Dictionary<long, Post>();
    static long postsCounter = 101;

    private static async Task<HttpClient> GetClient()
    {  
        return client ??= new HttpClient();
    }

    public static async Task<IEnumerable<Post>> GetAll()
    { 
        List<Post> postsList = new List<Post>(posts.Values.ToList());

        if (!posts.Any() && Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
        {
            var client = await GetClient();
            var result = await client.GetAsync($"{Url}posts");

            if (result.IsSuccessStatusCode)
            {
                var stream = await result.Content.ReadAsStreamAsync();
                postsList = JsonSerializer.Deserialize<List<Post>>(stream, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                });
                postsList.ForEach(post => posts.Add(post.Id, post));
            }
        }

        return postsList;
    }

    public static async Task<Post> Add(long userId, string title, string body)
    {
        Post newPost = new Post
        {
            Id = postsCounter++,
            UserID = userId,
            Title = title,
            Body = body
        };

        posts.Add(newPost.Id, newPost);

        return newPost;
    }

    public static async Task Update(Post editedPost)
    {
        if (posts.ContainsKey(editedPost.Id))
        {
            posts[editedPost.Id] = editedPost;
        }
    }

    public static async Task Delete(long id)
    {
        posts.Remove(id);                  
    }
}
