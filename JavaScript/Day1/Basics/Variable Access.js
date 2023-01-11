let y = 300;
console.log("y =", y);

const z = 100;
console.log("z ", z);

let z1;
var y1;
var y1;

/* cannot redeclare block scoped variables(let,const) */
//let z1;
//let z1;
//const z;

{
    var x2;
    x2 = 300;
    console.log("x2 inside the block ", x2);

    let y1 = 400;
    console.log("inside the block y1 ", y1);

    const z1 = 200;
    console.log("z1, inside the block ", z1);
}

console.log("x2 outside the block ", x2);

x2 = 400;

console.log("outside block x2 ", x2);

console.log("outside block y1 ", y1);

console.log("z1 ,outside the block ", z1);