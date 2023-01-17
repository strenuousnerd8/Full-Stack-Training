var express = require('express')

var app = express()

app.use('/', function(req, res, next) {
    console.log("Inside the middle ware")
    next()
})

app.get('/', function(req, res) {
    console.log("Coming from handle")
    res.send("This is get handler")
})

app.get('/hello', function(req, res) {
    console.log("Inside Hello")
    res.send("Response from hello")
})

app.get('/hi', function(req, res, next) {
    console.log("Inside Hi")
    res.send("Inside Hi")
    next()
})

app.use(function(req, res) {
    console.log("Last one")
})

app.listen(6500)