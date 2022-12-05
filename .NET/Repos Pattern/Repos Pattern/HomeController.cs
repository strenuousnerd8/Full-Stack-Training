using Microsoft.AspNetCore.Mvc;

namespace Repos_Pattern
{
    public class HomeController : ControllerBase
    {
        readonly IMockRepo emp;
        public HomeController(IMockRepo employee) {
            emp = new MockRepo();
        }
        public string Index()
        {
            return "From Controller";
        }

        [Route("Home/employee")]
        public string GetEmp()
        {
            return emp.GetEmployee(1).Name;
        }
    }
}
