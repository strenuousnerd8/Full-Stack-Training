namespace nodejs {
    interface I1 {
        x1: string
        x2: number
    }

    let i1: I1 = {
        x1: "AA1",
        x2: 200
    }
    console.log(i1)

    interface I2 extends I1 {
        x3: string
        x4: number
    }

    let i2: I2 = {
        x1: "AA2",
        x2: 3000,
        x3: "BB2",
        x4: 400
    }

    console.log(i2)

    interface I3 extends I2 {
        x5: string
        x6: number
    }

    let i3: I3 = {
        x1: "AA3",
        x2: 4000,
        x3: "BB3",
        x4: 4000,
        x5: "CC1",
        x6: 900
    }

    console.log(i3)
}