using System.Collections.Generic;

namespace NewsApi.Model
{
    public class GetNews
    {
        public List<Article> Articles { get; set; }
        public string Status { get; set; }
        public int TotalResults { get; set; }
    }
}
