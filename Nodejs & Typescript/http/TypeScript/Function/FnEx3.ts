var hello2 = function(a, b) {
    console.log("Inside Hello 2", a, b)
    return a + b
}
hello2(10, 20)

var hello3 = (a: number, b: number): number => {
    console.log("Inside Hello 3")
    return a + b
}

var xx = hello3(10, 20)
console.log(xx)

var hello4 = (a, b, c) => {
    console.log("a=, b=, c=", a, b, c)
}

hello4(300, 500, 600)

var hello5 = x => {
    console.log("Hello5", x)
}

hello5(55)

var abc = x => x/5
console.log(abc(7000) * 40)

var show3 = new Function("a", "b", "return a + b")
var tt = show3(10, 20)
console.log(tt)