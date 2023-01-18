var a 
a = 100
console.log(a)
a = "aaaaa"
console.log(a)

function fn() {
    {
        var aa = 20
        var bb = 300
        console.log(aa)
        console.log(bb)
    }
    console.log(bb)
}
fn()
// console.log(bb)
var zz: any
zz = 500