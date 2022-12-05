namespace Core_6_Sample
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
    public class EmployeeCollection
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Id = 2,
                    Name = "Foo",
                    Description = "Bar",
                },

                new Employee()
                {
                    Id = 3,
                    Name = "Bar",
                    Description= "Foo",
                },

                new Employee()
                {
                    Id = 4,
                    Name = "Choco",
                    Description = "Bar",
                },

                new Employee()
                {
                    Id = 5,
                    Name = "Milky",
                    Description = "Bar",
                }
            };
        }
    }
}
