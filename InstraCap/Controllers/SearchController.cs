using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InstraCap.Controllers
{
    public class SearchController : Controller
    {
        public class SearchViewModel
        {
            public SearchViewModel(string code) {
                Code = code;
            }

            public string Code { get; private set; }
        }

        // GET: Search
        public ActionResult Index(string code)
        {
            var model = new SearchViewModel(code);
            return View(model);
        }
    }
}