function fn() {
  x = document.getElementById("button").innerHTML;
  if (x == "Great") {
    document.getElementById("button").innerHTML = "Yes";
  } 
  else if (x == "Yes") {
    document.getElementById("button").innerHTML = "I'm Feeling Lucky";
  } 
  else {
    document.getElementById("button").innerHTML = "Great";
  }
}
