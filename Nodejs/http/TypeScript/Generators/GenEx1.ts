function* gen() {
    yield 1000
    console.log("1111")
    yield 200
    console.log("2222")
    yield 400
    console.log("3333")
    yield 800
    console.log("4444")
    yield 700
    console.log("5555")
}

var myGen = gen()

console.log(myGen.next().value)
console.log(myGen.next().value)
console.log(myGen.next().value)
console.log(myGen.next().value)
console.log(myGen.next().value)