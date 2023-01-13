const { required } = require("nodemon/lib/config");

var http = require("http");

http
  .createServer(function (req, res) {
    res.writeHead(200, { "Content-type": "text/html" });
    res.end("Hi Team");
  })
  .listen(8000);
