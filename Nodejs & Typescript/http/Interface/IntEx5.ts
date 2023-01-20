namespace nodejs {
    interface A1 {
        x1: string
        x2: number
    }

    interface A2 {
        x3: string
        x4: string
    }

    interface A extends A1, A2 {
        
    }

    let a: A = {
        x1: "AA1",
        x2: 2000,
        x3: "BB",
        x4: "CC"
    }

    console.log(a)
}