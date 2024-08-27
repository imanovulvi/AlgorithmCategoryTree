using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Category
    {
        public int Id { get; set; }
        public int PaternId { get; set; } // Parent Id
        public string CategoryName { get; set; }
    }
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            string jsonData = "[{\"id\":1,\"paternId\":0,\"categoryname\":\"a\"}, {\"id\":2,\"paternId\":0,\"categoryname\":\"b\"}, {\"id\":3,\"paternId\":0,\"categoryname\":\"c\"}, {\"id\":4,\"paternId\":1,\"categoryname\":\"d\"}, {\"id\":5,\"paternId\":2,\"categoryname\":\"e\"}, {\"id\":6,\"paternId\":5,\"categoryname\":\"g\"}]";
            var categories = JsonConvert.DeserializeObject<List<Category>>(jsonData);

            return View(categories);
        }

       
    }
}
