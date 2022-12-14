function greet(name) {
    console.log('Hello ', name + "!")
}

greet('Faiz')
greet(3)
greet()

function fn(x) {
    console.log("Inside a function")
    return 700 * x
}

x = fn(2)
console.log(x)

// Default Parameters
function anotherfn(x1, x2, x3 = 200) {
    console.log("Inside another function ", x1, x2, x3)
}

anotherfn(2, 3, 4)
anotherfn(3, 4)

// JavaScript Hoisting
hello()
function hello() {
    console.log('Hola')
}

var x
x = 10
console.log(x)

// Self-Invoking Function
(function() {
    console.log('Inside IIEF');
})()

function lastfn() {
    console.log('How\'s this!')
}

lastfn()