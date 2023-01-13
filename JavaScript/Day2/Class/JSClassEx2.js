// Inheritance
class D {
    a = 10
    b = 20
    constructor() {
        console.log("Inside D's constructor")
    }

    fn2() {
        console.log("Inside D's function 2")
    }

    fn3() {
        console.log("Inside D's function 3")
    }
}

class E extends D {
    c = 100
    d = 200
    constructor() {
        super()
        console.log("Inside E's constructor", this.c, this.d)
    }

    fn() {
        console.log("Inside E's function", this.a, this.b)
    }

    fn2() {
        console.log("Inside E's function 2")
    }
    
    fn3() {
        console.log("Inside E's function 3")
        super.fn3()
    }
}

// var d = new D()
var e = new E()
e.fn()
e.fn2()

console.log(e.a)

e.fn3();

