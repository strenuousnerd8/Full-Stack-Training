var fs = require('fs')
var buf = new Buffer(2000)

fs.open('test.txt', 'r+', function(err, fd) {
    if(err) {
        return console.log(err)
    }
    console.log("File opened")

    fs.read(fd, buf, 0, buf.length, 0, function(err, bytes) {
        if(err) {
            console.log(err)
        }
        if(bytes > 0) {
            console.log(buf.slice(0, bytes).toString())
        }
    })
})