using System.Collections.Generic;
using System.Linq;

namespace Repos_Pattern
{
    public class MockRepo : IMockRepo
    {
        private List<Employee> emp;
        public MockRepo() {
            emp = new List<Employee>()
            {
                new Employee() 
                { 
                    Id= 1,
                    Name = "Faizahamed Akkiwat",
                    Description = "Full Stack Engineer"
                },
                new Employee() 
                {
                    Id= 2,
                    Name = "Foo", 
                    Description= "Bar" 
                },
                new Employee() 
                { 
                    Id= 2, 
                    Name = "Choco", 
                    Description= "Bar" 
                },
                new Employee() 
                { 
                    Id= 2, 
                    Name = "Milky", 
                    Description= "Bar" 
                },
            };
        }

        public Employee GetEmployee(int id)
        {
            return this.emp.FirstOrDefault(emp => emp.Id == id);
        }
    }
}