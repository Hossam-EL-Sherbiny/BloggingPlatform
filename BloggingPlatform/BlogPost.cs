using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggingPlatform
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public string? Title { get; set; }
        public DateTime? Date { get; set; }
        public List<string>? Categories { get; set; }
        public List<string>? Tags { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
