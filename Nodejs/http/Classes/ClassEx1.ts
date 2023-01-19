namespace nodejs {
    class B {
        b1: number = 200
        x1: string = "BBB"
        constructor(x: number, y: string) {
            console.log("Inside B's constructor", x, y)
        }

        display(): void {
            console.log("Inside display function, class B")
        }

        fnb() {
            console.log("Inside function fnb, class B")
        }
    }

    class A extends B {
        a1: number
        b2: string
        constructor(x1: number, x2: string) {
            super(x1, x2)
            console.log("Inside A's constructor")
            this.a1 = x1
            this.b2 = x2
        }

        display(): void {
            super.display()
            console.log("Inside display function, class A")
        }

        fn() {
            super.fnb()

            var t = 500
            console.log("Invoking the base class attributes", this.x1, this.b1)
            console.log("Inside fn", this.a1, this.b2, t, this.b1)
        }
    }

    let a3 = new A(20, "AA")
    a3.fn()
}