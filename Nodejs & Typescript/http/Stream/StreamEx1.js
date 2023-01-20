var fs = require("fs")
var data = ''

var readerStream = fs.createReadStream('./http/stream/input.txt')

readerStream.setEncoding('UTF8')

readerStream.on('data', function(chunk) {
    data += chunk
    console.log(data)
    console.log("Inside data read")
})

readerStream.on('end', function() {
    console.log("Inside end")
})

readerStream.on('error', function(err) {
    console.log(err.stack)
    console.log("Inside end")
})

console.log("Program Ended")