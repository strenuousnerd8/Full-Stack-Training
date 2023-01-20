var express = require('express')

var app = express()

app.get('/', function(req, res) {
    res.send("Hi Team, this is express library")
})

app.get('/hello', function(req, res) {
    res.send("Hey, this is response for hello")
})

app.get('/hello1', function(req, res) {
    res.send("Hey, this is response for hello1")
})

app.get('/hello/hi', function(req, res) {
    res.send("This is hello hi response")
})

app.get('/hello/:id', function(req, res) {
    res.send("This is variable parameter:\t" + req.params.id)
})

app.get('/abc/:id1/:id2', function(req, res) {
    res.send("This is variable parameter 1:\t" + req.params.id1 + 
    " and parameter 2:\t" + req.params.id2)
})

app.get('/ab*cd', function(req, res) {
    res.send("This is a pattern")
})

app.listen(5100)