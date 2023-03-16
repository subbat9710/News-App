using NewsApi.Model;
using RestSharp;

namespace NewsApi.Service
{
    public class NewsApiService : IGetNews
    {
        private static readonly string api_Url = "https://newsapi.org/v2/everything?q=tesla&from=2023-03-14&sortBy=publishedAt&apiKey=";
        private static readonly string api_Key = "56670fd5a9684ac4926eeb4b0d288374";
        private readonly RestClient client = new RestClient();

        public News GetNews()
        {
            RestRequest request = new RestRequest(api_Url + api_Key);
            IRestResponse<GetNews> response = client.Get<GetNews>(request);

            News news = new News()
            {
                Status = response.Data.Status,
                TotalResults = response.Data.TotalResults,
                Articles = response.Data.Articles
            };

            return news;
        }
    }
}
