﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            //ViewBag.v1 = bm.GetList().Count();
            ViewBag.v1 = c.Blogs.OrderByDescending(x => x.BlogID).Select(x=>x.BlogTitle).Take(1).FirstOrDefault();
            ViewBag.v3 = c.Comments.Count();
            return View();
        }
    }
}
