using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggingPlatform
{
    public class Blogging
    {
        private List<BlogPost> blogPosts;
        public Blogging()
        {
            blogPosts = new List<BlogPost>();
        }

        public void AddBlogPost(BlogPost post)
        {
            post.Id = blogPosts.Count + 1;
            blogPosts.Add(post);
        }

        public List<BlogPost> GetAllBlogPosts()
        {
            return blogPosts;
        }

        public List<BlogPost> GetBlogPostsByCategory(string category)
        {
            return blogPosts.Where(post => post.Categories.Contains(category)).ToList();
        }

        public List<BlogPost> GetBlogPostsByDateRange(DateTime startDate, DateTime endDate)
        {
            return blogPosts.Where(post => post.Date >= startDate && post.Date <= endDate).ToList();
        }

        public List<BlogPost> GetBlogPostsByPopularity()
        {
            return blogPosts.OrderByDescending(post => post.Comments.Count).ToList();
        }
    }
}
