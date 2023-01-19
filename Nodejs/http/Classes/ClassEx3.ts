namespace nodejs {
    abstract class A {
        name: string
        abstract aa: string
        constructor(name: string) {
            this.name = name
        }

        display() {
            console.log("Inside display method")
        }

        abstract fn(): void
        abstract fn2(): string
    }

    class B extends A {
        x1: number
        aa: string
        constructor(a1: number, a2: string) {
            super(a2)
            this.x1 = a1
            this.aa = "AAAA"
        }

        fn(): void {
            console.log("Inside fn")
            return
        }

        fn2(): string {
            console.log("Inside fn2")
            return "aa"
        }
    }

    class C extends A {
        aa: string
        constructor(aa: string, ab: string) {
            super(aa)
        }

        fn(): void {
            console.log("Inside C, fn")
        }

        fn2(): string {
            console.log("Inside C, fn2")
            return "CC"
        }
    }

    let b = new B(200, "AA")
    b.fn()
    b.fn2()
}