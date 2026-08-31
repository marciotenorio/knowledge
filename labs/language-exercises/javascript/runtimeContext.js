// The global object in browser runtime is window
// this === window
// In this context some global variables are append in window
// Constans and variables declared with let keyword don't are append in window in browser context
// The "windows" in Node runtime are global
// Node runtime this === module.exports

// This variable created without keyword are append in global object
abc = 3
console.log(global.abc)