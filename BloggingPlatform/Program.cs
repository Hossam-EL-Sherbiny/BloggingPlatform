// Create an instance of the blogging platform
using BloggingPlatform;

Blogging bloggingPlatform = new Blogging();

    // Create and add sample blog posts
    BlogPost post1 = new BlogPost
    {
        Title = "First Post",
        Content = "This is the content of the first post.",
        Date = new DateTime(2023, 5, 1),
        Categories = new List<string> { "Technology", "Programming" },
        Tags = new List<string> { "C#", "LINQ" },
        Comments = new List<Comment>()
    };
    bloggingPlatform.AddBlogPost(post1);

    BlogPost post2 = new BlogPost
    {
        Title = "Second Post",
        Content = "This is the content of the second post.",
        Date = new DateTime(2023, 5, 2),
        Categories = new List<string> { "Technology", "AI" },
        Tags = new List<string> { "Machine Learning", "Deep Learning" },
        Comments = new List<Comment>()
    };
    bloggingPlatform.AddBlogPost(post2);

    // Get all blog posts
    Console.WriteLine("All Blog Posts:");
    List<BlogPost> allPosts = bloggingPlatform.GetAllBlogPosts();
    PrintBlogPosts(allPosts);

    // Get blog posts by category
    Console.WriteLine("\nBlog Posts in the 'Technology' Category:");
    List<BlogPost> techPosts = bloggingPlatform.GetBlogPostsByCategory("Technology");
    PrintBlogPosts(techPosts);

    // Get blog posts by date range
    Console.WriteLine("\nBlog Posts between May 1 and May 3, 2023:");
    DateTime startDate = new DateTime(2023, 5, 1);
    DateTime endDate = new DateTime(2023, 5, 3);
    List<BlogPost> dateRangePosts = bloggingPlatform.GetBlogPostsByDateRange(startDate, endDate);
    PrintBlogPosts(dateRangePosts);

    // Add comments to a blog post
    Comment comment1 = new Comment
    {
        Author = "John",
        Content = "Great post!",
        Date = DateTime.Now
    };
    post1.Comments.Add(comment1);

    Comment comment2 = new Comment
    {
        Author = "Jane",
        Content = "Well written.",
        Date = DateTime.Now
    };
    post1.Comments.Add(comment2);

    // Get blog posts by popularity (number of comments)
    Console.WriteLine("\nBlog Posts by Popularity:");
    List<BlogPost> popularPosts = bloggingPlatform.GetBlogPostsByPopularity();
    PrintBlogPosts(popularPosts);

    static void PrintBlogPosts(List<BlogPost> posts)
    {
        foreach (var post in posts)
        {
            Console.WriteLine($"Title: {post.Title}");
            Console.WriteLine($"Content: {post.Content}");
            Console.WriteLine($"Date: {post.Date}");
            Console.WriteLine($"Categories: {string.Join(", ", post.Categories)}");
            Console.WriteLine($"Tags: {string.Join(", ", post.Tags)}");
            Console.WriteLine($"Number of Comments: {post.Comments.Count}");
            Console.WriteLine();
        }
    }



