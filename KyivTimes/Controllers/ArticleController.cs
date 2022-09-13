using KyivTimes.Data.Models;
using KyivTimes.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KyivTimes.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : Controller
    {
        private IArticleRepo _articleRepo;
        public ArticleController(IArticleRepo articleRepo)
        {
            _articleRepo = articleRepo;
        }
        [HttpGet]

        public OkObjectResult GetOk()
        {
            return Ok("ok");
        }
        [HttpGet("{id}")]
        [AllowAnonymous]
        public ActionResult<Article> GetArticle(int id) 
        {
            return _articleRepo.GetArticle(id);
        }
        //[HttpPut("{id}")]
        [HttpGet("all")]
        [AllowAnonymous]
        public ActionResult<List<Article>> GetAllArticles()
        {
            return Ok(_articleRepo.GetAllArticles());
        }
        [HttpPut]
        public OkObjectResult ArticleUpdate(Article article)
        {
            //var article1 = _articleRepo.GetArticle(id);
            //article1 = article;
            _articleRepo.UpdateArticle(article);
            return Ok("ok");
        }
        [HttpPost]
        public ActionResult<Article> CreateArticle(Article article)
        {
            if (article == null)
            {
                return BadRequest();
            }
            _articleRepo.AddArticle(article);
            return Ok(article);
        }

        [HttpDelete("{id}")]
        public OkObjectResult DeleteArticle(int id)
        {
            var deleted = _articleRepo.DeleteArticle(id);
            if (deleted)
            {
                return Ok("deleted");
            }
            return Ok("not deleted");
        }

    }
}
