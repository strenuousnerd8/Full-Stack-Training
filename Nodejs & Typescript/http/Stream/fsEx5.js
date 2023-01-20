var fs = require("fs")

var data = fs.readFileSync('./http/stream/test.txt')

console.log(data.toString())
console.log('Program Ended')