using NewsApi.Model;

namespace NewsApi.Service
{
    public interface IGetNews
    {
        News GetNews();
        public News GetNewsByAuthor(string author = null); 

    }
}
