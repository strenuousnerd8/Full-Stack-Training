var http = require('http')

var fs = require('fs')

http.createServer(function(req, res) {
    fs.readFile('test.txt', function(err, data) {
        res.writeHead(200, {
            'content-type': 'text/plain'
        })
        res.write(data)
        console.log(data)
        return res.end()
    })
}).listen(7000)