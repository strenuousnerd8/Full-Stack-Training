var fs = require("fs")
var data = ''

var readerStream = fs.createReadStream('./http/stream/input.txt')
var writerStream = fs.createWriteStream('./http/stream/output.txt')

readerStream.pipe(writerStream)

console.log("Program Ended")