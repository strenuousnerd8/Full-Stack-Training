// Rest Parameter function
function show(x1, x2, ...x3) {
  console.log("Inside show function ", x1, x2, x3);
}

show(100, 200, 20, 30, "AAA", 3000, "$$$$$");

function disp(...thisx) {
  console.log(thisx)
}

disp(20, 30, "hello", true)

// Using recursion and default parameter
function countDown(n) {
    if (n == 0)
        return
    console.log(n)
    countDown(n - 1)
}


countDown(3)

arr = [10, 20, 30, 40]

function sumArr(arr, sum = 0) {
    if (arr.length < 1)
        return sum
    else
        sum += arr.pop()
        return sumArr(arr, sum)
}

console.log(
    sumArr(arr)
)

function fact(n) {
    if (n == 0)
        return 1
    else
        return n * fact(n - 1)
}

console.log(
    fact(4)
)