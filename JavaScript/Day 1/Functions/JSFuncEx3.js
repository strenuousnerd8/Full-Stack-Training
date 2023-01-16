// Function constructor
var x = Function("a","b","return a + b")

// Anonymous function
res = x(20, 30)
console.log(res)

var y = function() {
    return "hello"
}

x = y()
console.log(x)

var z = function(x, y) {
    console.log("Inside anonymous function")
    return x + y
}

console.log(z(10, 10))

// Using anonymous function with rest params
var a = function(...rest) {
    var sum = 0;
    rest.forEach(function(number)
    {
        sum += number;     
    });
    return sum;
}

console.log(
    "Anonymous func with rest\n",
    a(1, 2, 3)
)

// Using anonymous function with rest params and default param
var b = function(...[rest = [1, 2, 3, 4]]) {
    var sum = 0;
    rest.forEach(function(number)
    {
        sum += number;     
    });
    return sum;
}

console.log(
    "Anonymous func with default\n",
    b()
)

// Function constructor using rest params
var p = Function("a","...rest","return a * rest")

console.log(
    "Function cons with rest\n",
    p(1, 2)
)

// Function consructor using default param
var q = Function("a","b = 5","return a + b")

console.log(
    "Function cons with default\n",
    q(10)
)