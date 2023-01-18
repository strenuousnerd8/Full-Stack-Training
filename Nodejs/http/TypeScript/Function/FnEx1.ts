/*
function hello(x, y) {
    console.log("Hi I am inside hello function ", x, y)
    return x + y
}

hello(19, 20)
*/

function hello(x: number, y: number) {
    console.log("Hi I am inside hello function ", x, y)
    return x + y
}

hello(19, 20)

function fnTs(x: number, y: number, z: number = 200): number {
    console.log("Inside FnTs")
    return x + y + z
}

var t = fnTs(200, 300, 400)
console.log("t =", t)

var t = fnTs(200, 200)
console.log("t =", t)