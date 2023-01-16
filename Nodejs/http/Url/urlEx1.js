var url = require('url')

var adr = 'http://localhost:9000/default.htm?year=2023&month=january'

var q = url.parse(adr, true)

console.log(q.host)
console.log(q.pathname)
console.log(q.search)

var qdata = q.query
console.log(qdata)