var fs = require("fs")
var data = 'I have appended some data'

var writerStream = fs.createWriteStream('./http/stream/output.txt')

writerStream.write(data, 'UTF8')

writerStream.end()

writerStream.on('finish', function() {
    console.log("Write Complete")
})

writerStream.on('error', function(err) {
    console.log(err.stack)
})

console.log("Program Ended")