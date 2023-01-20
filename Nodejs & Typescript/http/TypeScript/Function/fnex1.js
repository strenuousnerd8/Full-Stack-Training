/*
function hello(x, y) {
    console.log("Hi I am inside hello function ", x, y)
    return x + y
}

hello(19, 20)
*/
function hello(x, y) {
    console.log("Hi I am inside hello function ", x, y);
    return x + y;
}
hello(19, 20);
function fnTs(x, y, z) {
    if (z === void 0) { z = 200; }
    console.log("Inside FnTs");
    return x + y + z;
}
var t = fnTs(200, 300, 400);
console.log("t =", t);
var t = fnTs(200, 200);
console.log("t =", t);
