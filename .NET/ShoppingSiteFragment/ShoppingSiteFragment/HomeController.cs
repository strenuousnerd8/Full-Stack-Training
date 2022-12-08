using Microsoft.AspNetCore.Mvc;
using ShoppingSite;

namespace ShoppingSiteFragment
{
    public class HomeController : Controller
    {
        public Inventory invent = new Inventory();
        public string Index()
        {
            return "Separate Project for Shopping Site";
        }
        [Route("Home/inventory")]
        public string GetInvent()
        {
            return invent.inventoryGreet();
        }
    }
}
