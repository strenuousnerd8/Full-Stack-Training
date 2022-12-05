using Core_6_Sample;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello world! \nThis is my homepage");
app.MapGet("/route", () => "Inside New Route!");
app.MapGet("/internal", (Func<String>)(() => "Inside Internal Function!"));
app.MapGet("/external", externalFunc);

string externalFunc()
{
    return "Inside External Function!";
}

app.MapGet("/employee", (Func<Employee>)(() =>
{
    return new Employee()
    {
        Id = 1,
        Name = "Faizahamed Akkiwat",
        Description = "Full Stack Engineer"
    };
}));

app.MapGet("/employees", (Func<List<Employee>>)(() =>
{
    return new EmployeeCollection().GetEmployees();
}));


app.Run();
