using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Model;
using NewsApi.Service;
using System.Collections.Generic;
using System.Linq;

namespace NewsApi.Controllers
{
    [Route("api/news")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private IGetNews getNews;

        public NewsController(IGetNews getNews)
        {
            this.getNews = getNews;
        }
        [HttpGet]
        public ActionResult<News> GetNews()
        {
            News news = getNews.GetNews();

            List<Article> articles = new List<Article>();
            foreach (Article article in news.Articles)
            {
                Article newArticle = new Article();
                newArticle.Source = article.Source;
                newArticle.Author = article.Author;
                newArticle.Title = article.Title;
                newArticle.Description = article.Description;
                newArticle.Url = article.Url;
                newArticle.UrlToImage = article.UrlToImage;
                newArticle.PublishedAt = article.PublishedAt;
                newArticle.Content = article.Content;

                articles.Add(newArticle);
            }

            News newNews = new News();
            newNews.Status = news.Status;
            newNews.TotalResults = news.TotalResults;
            newNews.Articles = articles;

            return newNews;
        }
    }
}
