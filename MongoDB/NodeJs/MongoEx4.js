var MongoClient = require("mongodb").MongoClient 
//var url = "mongodb://localhost:27017/mydb"
var url = "mongodb://localhost:27017"
MongoClient.connect(url,function(err, db){  
    if(err){    
        console.log("Error",err)  
    } 
    else {   
        var dbo = db.db("mydb")   
        var obj1 = {name:"Rakesh3", address:"Address3"}   
        dbo.collection("myCol1").insertOne(obj1,function(err, res){    
            if(err){      
                console.log("Error",err)    
            } 
            else {      
                console.log("Document inserted")      
                db.close()    
            }   
        })  
    }
})
