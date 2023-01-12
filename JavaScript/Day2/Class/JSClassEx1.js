class A {
    constructor() {
        console.log("Inside A's constructor")
    }
}

var a = new A()
var b = new A()

class B {
    fn() {
        console.log("Inside class B function")
    }
}

var b = new B()
b.fn()

class C {
    constructor(x, y) {
        this.x = x
        this.y = y
        console.log("Inside C's constructor", x, y)
    }

    fn() {
        console.log("Inside C's fn", this.x, this.y)
    }

    static fn() {
        console.log("Inside C's static method")
    }
}

C.fn()
var c = new C(2, 300)
c.fn()