const req = require("express/lib/request");
var http = require("http");
var http = require('http');

http.createServer(function(req,res){
    res.writeHead(200, {'Context-type':'text/plain'});
    res.end(req.url);
    var burl = require('url').parse(req.url, true).query;
    console.log(burl.a)
}).listen(2000)

function postprocess() {
  var url = require("url");
  var adr = "http://localhost:9000/?a=12331";
  var q = url.parse(adr, true);

  console.log(q.host);
  console.log(q.pathname);
  console.log(q.search);

  var qdata = q.query;
  console.log(qdata);
}

setTimeout(postprocess, 500);
