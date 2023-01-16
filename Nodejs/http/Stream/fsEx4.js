var fs = require("fs")

console.log("Going to write into existing file")
fs.writeFile('./http/stream/test.txt', 'hi team, this is nodejs session!', function(err) {
    if(err) {
        return console.error(err)
    }

    console.log("Data written successfully")
    console.log("Let's read newly written data")

    fs.readFile('./http/stream/test.txt', function(err, data) {
        if(err) {
            return console.error(err)
        }
        console.log("Asynchronous read: " + data.toString())
    })
})