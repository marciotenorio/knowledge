function someFunction(){
    // for(let i = 0; i < arguments.length; i++){
    //     console.log(arguments[i])
    // }

    // for(let i in arguments){
    //     console.log(arguments[i])
    // }

    let args = Array.prototype.slice.call(arguments);
    // Using an array literal is shorter than above but allocates an empty array
    // var args = [].slice.call(arguments);

    // ES2015
    // let args = Array.from(arguments);
    // or
    // let args = [...arguments];

    args.forEach(function(element){console.log(element)})


}

someFunction("Márcio", "Tenório")

// arguments doesn't have Array's built-in methods