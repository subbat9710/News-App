using System.Collections.Generic;

namespace NewsApi.Model
{
    public class News
    {
        public int NewsId { get; set; }
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<Article> Articles { get; set; }
    }
}
