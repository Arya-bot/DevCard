using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace DevCard_MVC.ViewComponents
{
    public class ArticleViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Models.Article>() {
                new Models.Article { Id=1,Title="تحقیقات علمی",    Image="blog-post-thumb-1.jpg", Description="جهت دسترسی به مقالات علمی در نشریه ها"},
                new Models.Article { Id=2,Title=" دنیای پزشکی",    Image="blog-post-thumb-2.jpg", Description="جهت دسترسی به مقالات علمی در نشریه ها"},
                new Models.Article { Id=3,Title=" جانداران علمی " ,Image="blog-post-thumb-3.jpg", Description="جهت دسترسی به مقالات علمی در نشریه ها"},
                new Models.Article { Id=4,Title=" انرژی های فسیلی",Image="blog-post-thumb-4.jpg", Description="جهت دسترسی به مقالات علمی در نشریه ها"},


            };
            return View("_Articles",articles);
        }
    }
}
