interface I1 {
  x1: string
  x2: number
}

let i1: I1 = {
  x1: "AA",
  x2: 66
}

let i2: I1 = {
  x1: "SSSs",
  x2: 400
}

console.log(i1)
console.log(i2)
console.log(i1.x1, i2.x1)

interface I2 {
  (a: number, b: number): number
}

const add: I2 = (a, b) => {
  return a + b
}
console.log(add(100, 200))

const sub: I2 = (a, b) => {
  return a - b
}
console.log(sub(200, 100))

const mul: I2 = (a, b) => {
  return a * b
}
console.log(mul(200, 100))

const div: I2 = (a, b) => {
  return a / b
}
console.log(div(200, 100))