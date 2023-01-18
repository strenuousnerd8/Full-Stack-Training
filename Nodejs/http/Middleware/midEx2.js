var express = require('express')

var app = express()

app.use('/', function(req, res, next) {
    console.log('Inside common processing')
    next()
})

app.use('/hello', function(req, res, next) {
    console.log("Inside hello middleware")
    next()
})

app.use('/user', function(req, res, next) {
    console.log("Inside user middleware")
    next()
})

app.get('/user', function(req, res, next) {
    console.log("Inside user handler function")
    next()
})

app.get('/hello', function(req, res, next) {
    console.log("Inside hello handler")
    next()
})

app.use('/user', function(req, res, next) {
    console.log("User post processing middleware")
    next
})

app.use('/hello', function(req, res, next) {
    console.log("Inside hello post processing")
    next()
})

app.use('/', function(req, res) {
    console.log('Inside common post processing')
})

app.listen(6500)