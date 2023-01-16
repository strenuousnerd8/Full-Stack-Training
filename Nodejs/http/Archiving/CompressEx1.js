var fs = require("fs")
var zlib = require('zlib')

fs.createReadStream('./http/archiving/input.txt')
    .pipe(zlib.createGzip())
    .pipe(fs.createWriteStream('./http/archiving/input.txt.gz'))

console.log("File Compressed.")