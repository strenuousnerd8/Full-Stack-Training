var fs = require("fs")
var zlib = require('zlib')

fs.createReadStream('./http/archiving/input.txt.gz')
    .pipe(zlib.createGunzip())
    .pipe(fs.createWriteStream('./http/archiving/input.txt'))

console.log("File Decompressed.")