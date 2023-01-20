namespace nodejs {
    const xx: {x1: number, x2: string, x3: number} = {
        x1: 100,
        x2: "aaa",
        x3: 3000
    }

    console.log(xx)
    console.log(xx.x1)
    console.log(xx.x2)
    console.log(xx.x3)

    const yy = {
        xx1: 1000,
        xx3: "qqqqq"
    }

    console.log("YYY", yy)

    yy.xx1 = 3000
    yy.xx3 = "BBBBBB"

    console.log(yy)

    var xx2: {aa1: number, aa2?: string} = {
        aa1: 100
    }
    xx2.aa2 = "fffffffff"

    console.log(xx2)

    const cc: {[index: string]: number} = {}

    cc.aa1 = 200
    cc.aa2 = 300

    console.log(cc)

    var obj = {
        xx1: "Val1",
        xx2: "Val2",
        xx3: "Val3",
        xx4: function() {},
        xx5: [1, 2, 3]
    }

    obj.xx4 = function() {
        console.log("Value of object function", obj.xx1, obj.xx2)
    }

    obj.xx4();

    console.log(obj.xx1)
    console.log(obj.xx2)
}