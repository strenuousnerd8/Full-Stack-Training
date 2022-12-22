using WebApplication4;
namespace WebApplicationNet6DB
{
    public class DataRepository : IDataRepository
    {
        private readonly EmployeeDbContext db;
        public DataRepository(EmployeeDbContext db)
        {
            this.db = db;
        }



        public List<Employee> GetEmployees() => db.Employee.ToList();
        public Employee PutEmployee(Employee employee)
        {
            db.Employee.Update(employee);
            db.SaveChanges();
            return db.Employee.Where(x => x.EmployeeId == employee.EmployeeId).FirstOrDefault();
        }
        public List<Employee> AddEmployee(Employee employee)
        {
            db.Employee.Add(employee);
            db.SaveChanges();
            return db.Employee.ToList();
        }



    }
}