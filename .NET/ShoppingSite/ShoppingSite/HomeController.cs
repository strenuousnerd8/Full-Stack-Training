using Microsoft.AspNetCore.Mvc;

namespace ShoppingSite
{
    public class HomeController : Controller
    {
        public Product prod = new Product();
        public OrderProcessing op = new OrderProcessing();
        public Shipping ship = new Shipping();
        public Billing bill = new Billing();
        public CustomerSupport cs = new CustomerSupport();

        public string Index()
        {
            return "Home Page";
        }
        [Route("Home/product")]
        public string GetProd()
        {
            return prod.productPage();
        }
        [Route("Home/processing")]
        public string GetOP()
        {
            return op.OPGreet();
        }
        [Route("Home/shipping")]
        public string GetShip()
        {
            return ship.shippingGreet();
        }
        [Route("Home/billing")]
        public string GetBill()
        {
            return bill.billingGreet();
        }
        [Route("Home/support")]
        public string GetEmp()
        {
            return cs.CSGreet();
        }
    }
}
