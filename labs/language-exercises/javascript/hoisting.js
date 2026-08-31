// Hoisting is the default behavior of moving all the declarations at the top of the scope before code execution.
console.log("a=", a)

var a = "Tony"

console.log("a=", a)

console.log('------------------------')

// Same behavior in a function scope
function test(){
    console.log("a=", a)

    var a = "Tony"

    console.log("a=", a)
}

test()

// This behavior don't happen with let variables
