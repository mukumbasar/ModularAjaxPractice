using Microsoft.AspNetCore.Mvc;
using ModularAjaxPractice.Models;
using System.Diagnostics;

namespace ModularAjaxPractice.Controllers
{
    public class HomeController : Controller
    {
        private List<Data> datas = new List<Data>();

        public HomeController(ILogger<HomeController> logger)
        {
            if (!datas.Any())
            {
                datas.Add(new Data(){ Id = 1, Context = "Context 1" });
                datas.Add(new Data(){ Id = 2, Context = "Context 2" });
                datas.Add(new Data(){ Id = 3, Context = "Context 3" });
                datas.Add(new Data(){ Id = 4, Context = "Context 4" });
                datas.Add(new Data(){ Id = 5, Context = "Context 5" });
                datas.Add(new Data(){ Id = 6, Context = "Context 6" });
                datas.Add(new Data(){ Id = 7, Context = "Context 7" });
                datas.Add(new Data(){ Id = 8, Context = "Context 8" });
                datas.Add(new Data(){ Id = 9, Context = "Context 9" });
            }
        }

        public IActionResult Index()
        {
            return View(datas);
        }

        public IActionResult GetData(int id)
        {
            var data = datas.Find(x => x.Id == id);

            return PartialView("_DataPartialView", data);
        }
    }
}