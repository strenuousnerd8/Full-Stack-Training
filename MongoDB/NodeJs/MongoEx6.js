var MongoClient = require("mongodb").MongoClient 
//var url = "mongodb://localhost:27017/mydb"
var url = "mongodb://localhost:27017"
MongoClient.connect(url,function(err, db){  
    if(err){    
        console.log("Error",err)  
    } 
    else {   
        var dbo = db.db("mydb")   
        var obj1 = [
            {name:"Rakesh4", address:"Address4"},   
            {name:"Rakesh5", address:"Address5"},   
            {name:"Rakesh6", address:"Address6"},   
            {name:"Rakesh7", address:"Address7"}
        ]   
        dbo.collection("myCol1").insertMany(obj1,function(err, res){    
            if(err){      
                console.log("Error",err)    
            } 
            else {      
                console.log("Document inserted"+res.insertedCount)      
                db.close()    
            }   
        })  
    }
})
