namespace nodejs {
    interface I2 {
        (x1: number, x2: number): number
    }

    function fn1(x1: number, x2: number): number {
        let x3: number = x1 + x2
        console.log("Inside fn1", x1, x2, x3)
        return x3
    }

    function fn2(x1: number, x2: number): number {
        let x3 = x1 + 3000
        console.log("Inside fn3", x1, x2, x3)
        return 200
    }

    let i3: I2 = fn1
    i3(3000, 4000)
    i3 = fn2
    i3(60000, 40000)
}