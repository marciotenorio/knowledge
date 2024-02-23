/**
 *  {@link https://javascript.info/rest-parameters-spread#rest-parameters}
 */
//The rest parameters must be at the end
//The rest parameters gather all remaining arguments, so the following does not make sense and causes an error:
//function f(arg1, ...rest, arg2) { // arg2 after ...rest ?!
  // error
//}
//The ...rest must always be last.

// Old times use arguments, when rest don't exists
// But the downside is that although arguments is both array-like and iterable, it’s not an array. 
// It does not support array methods, so we can’t call arguments.map(...) for example.the are not 
// Also, it always contains all arguments. We can’t capture them partially, like we did with rest parameters.
// function showName() {
//   alert( arguments.length );
//   alert( arguments[0] );
//   alert( arguments[1] );

//   // it's iterable
//   // for(let arg of arguments) alert(arg);
// }

// shows: 2, Julius, Caesar
// showName("Julius", "Caesar");

// shows: 1, Ilya, undefined (no second argument)
// showName("Ilya");

const camposAuxiliares = [ {labelCampo: 'Márcio', obrigatorio: true, tamanhoCampo: 10}, {labelCampo: 'Márcio 2', obrigatorio: true, tamanhoCampo: 10}];
const obj = {};
const result = camposAuxiliares.reduce((prev, curr) => {
    const {labelCampo, obrigatorio, tamanhoCampo} = curr;
        return {
            ...prev,
            [labelCampo]: [
                labelCampo, 
                obrigatorio, 
                tamanhoCampo
            ]
        }
    }, {});

console.log(result);