var MongoClient = require("mongodb").MongoClient
var url = "mongodb://localhost:27017/mydb" 
MongoClient.connect(url, function (err, db) { 
    if (err) { 
        console.log("Error", err) 
    } 
    else { 
        console.log("Database created") 
        db.close() 
    } 
})