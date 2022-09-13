using KyivTimes.Data.Models;

namespace KyivTimes.Data.Repositories
{
    public class ArticleRepo : IArticleRepo
    {
        private KyivTimesDbContext _context;
        public ArticleRepo(KyivTimesDbContext context)
        {
            _context = context;
        }

        public void AddArticle(Article article)
        {
            _context.Articles.Add(article);
            _context.SaveChanges();
        }

        public bool DeleteArticle(int id)
        {
            var article = GetArticle(id);
            if (article != null)
            {
                _context.Articles.Remove(article);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Article> GetAllArticles()
        {
            return _context.Articles.ToList();
        }

        public Article GetArticle(int id)
        {
            return _context.Articles.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Article> GetArticles(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public void UpdateArticle(Article article)
        {
            _context.Articles.Update(article);
            _context.SaveChanges();
        }
    }
}
