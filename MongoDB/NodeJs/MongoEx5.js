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
        // dbo.collection("myCol1").findOne({},function(err, res){   
        // dbo.collection("myCol1").find({}).toArray(function(err, res){   
        // dbo.collection("myCol1").find({},{name:"Rakesh1"}).toArray(function(err, res){     
        var query = { name:"Rakesh3"}    
        dbo.collection("myCol1").find(query).toArray(function(err, result) {     
            if(err){      
                console.log("Error",err)    
            } 
            else {      
                console.log(result)      
                db.close()    
            }   
        })  
    }
})