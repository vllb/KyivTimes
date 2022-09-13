using KyivTimes.Data.Models;

namespace KyivTimes.Data.Repositories
{
    public interface IArticleRepo
    {
        void AddArticle(Article article);
        void UpdateArticle(Article article);
        bool DeleteArticle(int id);
        IEnumerable<Article> GetAllArticles(); 
        IEnumerable<Article> GetArticles(int pageIndex, int pageSize);
        Article GetArticle(int id);

    }
}
