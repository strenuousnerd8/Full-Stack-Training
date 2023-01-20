var events = require("events");

var eventEmiiter = new events.EventEmitter();

var lister1 = function listner1() {
  console.log("Inisde listerner i1");
  eventEmiiter.emit("conn2");
};

var lister2 = function listner2() {
  console.log("Inisde listerner i2");
};

eventEmiiter.on("conn", lister1);
eventEmiiter.on("conn2", lister2);

eventEmiiter.emit("conn");
console.log("at the end");