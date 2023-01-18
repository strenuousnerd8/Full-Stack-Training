function fnTs1(a, b) {
    var aa = [];
    for (var _i = 2; _i < arguments.length; _i++) {
        aa[_i - 2] = arguments[_i];
    }
    console.log("Inside fnTs", a, b, aa);
}
fnTs1(1, 2, 3, 5, 6, 6, 89, 0, 'a', "aaa", 'bbb', 20, 100);
function fnTs(a, b) {
    var aa = [];
    for (var _i = 2; _i < arguments.length; _i++) {
        aa[_i - 2] = arguments[_i];
    }
    console.log("Inside fnTs", a, b, aa);
    var i;
    for (i = 0; i < aa.length; i++) {
        console.log("Inside loop", i, aa[i]);
    }
}
fnTs(3, 4, 56, 7, 8, 99, 100, 200, 7000);
