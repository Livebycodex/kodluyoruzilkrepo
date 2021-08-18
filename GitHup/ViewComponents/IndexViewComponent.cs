using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GitHup.ViewComponents
{
    public class IndexViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();

        }

    }
}
