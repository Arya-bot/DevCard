using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace DevCard_MVC.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Models.Project>
            {
                new Models.Project{ Id= 1 ,Name ="تاکسی",Client="رجا" ,Image = "project-1.jpg",Description="این نرم افزار جهت رزور بلیط قطار می باشد و هماکنون در حال سروی دهی است " },
                 new Models.Project{ Id= 2 ,Name ="مراسمات ",Client="زعیم" ,Image = "project-2.jpg",Description="این نرم افزار بومی است و جهت کلیه امور می باشد  " },
                 new Models.Project{ Id= 3 ,Name ="مدارس ",Client="زعیم" ,Image = "project-5.jpg",Description="این نرم افزار StartUp است و جهت کلیه امور می باشد  " },
                 new Models.Project{ Id= 4 ,Name ="باشگاه",Client="زعیم" ,Image = "project-4.jpg",Description="این نرم افزار جدید است و جهت کلیه امور می باشد  " },
            };
            return View("_Projects",projects);
        }
    }
}
