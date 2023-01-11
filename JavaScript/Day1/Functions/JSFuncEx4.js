// Arrow Functions
x = () => "Hello Team"
console.log(x())

y = (a) => console.log("Hi", a)
y('Faiz')

z = (p, q) => {
    r = p + q
    return r
}

res = z(2, 3)
console.log("Sum\t", res)

// Arrow Functions using rest params
var a = (...rest) => {
    var sum = 0;
    rest.forEach(function(number)
    {
        sum += number;     
    });
    return sum;
}

console.log(
    "Arrow func with rest\n",
    a(1, 2, 3)
)

// Using Arrow function with rest params and default param
var b = (...[rest = [1, 2, 3, 4]]) => {
    var sum = 0;
    rest.forEach(function(number)
    {
        sum += number;     
    });
    return sum;
}

console.log(
    "Arrow func with default\n",
    b()
)