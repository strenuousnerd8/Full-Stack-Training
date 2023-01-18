function fnTs1(a, b, ...aa) {
    console.log("Inside fnTs", a, b, aa)
}

fnTs1(1, 2, 3, 5, 6, 6, 89, 0, 'a', "aaa", 'bbb', 20, 100)

function fnTs3(a, b, ...aa: number[]) {
    console.log("Inside fnTs", a, b, aa)
    var i 
    for (i = 0; i < aa.length; i++) {
        console.log("Inside loop", i, aa[i])
    }
}

fnTs3(3, 4, 56, 7, 8, 99, 100, 200, 7000)