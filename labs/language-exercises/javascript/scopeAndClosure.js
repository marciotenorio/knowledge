/** 
 * The Lexical Environment object consists of two parts:
 * 1. Environment Record – an object that stores all local variables as 
 * its properties (and some other information like the value of this).
 * 2. A reference to the outer lexical environment, the one associated with the outer code.
 * 
 * When scripts start existis the "uninitialized" state to variables. 
 * Function are ready-to-use unlike variable, that is unusable untill the declaration
 * but only in function declaration not function expressions.
 * 
 * If a code want to access a variable that don't exists in anywhere in strict mode an error
 * are throw and in non-strict-mode creates a global variable to compartibility with old code. 
 * 
 * All functions remember the Lexical Environment in which they were made.
 */


function makeCounter() {
    let count = 0;
  
    return function() {
      return ++count;
    };
}
  
let counter = makeCounter();

function crazy() {
    let count = 10;
    return counter;
}

// 1
console.log(counter())

let crazyCounter = crazy();

/**
 * A variable is updated in the Lexical Environment where it lives.
 * 
 * A closure is a function that remembers its outer variables and can access them.
 * In JavaScript, all functions are naturally closures (there is only one exception,
 *  to be covered in The "new Function" syntax).
 * That is: they automatically remember where they were created using a hidden 
 * [[Environment]] property, and then their code can access outer variables.
 * 
 * Result are 2 because the lexical environtment already existis and the count = 0
 * are increase by one in line 34
 */
console.log(crazyCounter())

function f() {
    let value = 10;
  
    return function() { return ++value; };
  }
  
  // 3 functions in array, every one of them links to own Lexical Environment
  // from the corresponding f() run
  let arr = [f(), f(), f()];
  arr.forEach(_ => console.log(_()))