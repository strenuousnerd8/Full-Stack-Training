/*
function hello(x, y) {
    console.log("Hi I am inside hello function ", x, y)
    return x + y
}

hello(19, 20)
*/

function hellow(x: number, y: number) {
    console.log("Hi I am inside hello function ", x, y)
    return x + y
}

hellow(19, 20)

function fnTs2(x: number, y: number, z: number = 200): number {
    console.log("Inside FnTs")
    return x + y + z
}

var t = fnTs2(200, 300, 400)
console.log("t =", t)

var t = fnTs2(200, 200)
console.log("t =", t)