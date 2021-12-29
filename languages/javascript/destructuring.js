// Object examples
const pessoa = {
    name: "Márcio Tenório",
    age: 25,
    publicPlace: {
        address: "Rua Augusto Severo",
        number: 169
    }
}
// Destructuring with the same name
const { name, age } = pessoa
console.log(name, age)

// Destructuring with another name
const {name: anotherName, age: anotherAge} = pessoa
console.log(anotherName, anotherAge)

// Destructuring nested structures
const { publicPlace: { address: anotherAddress } } = pessoa
console.log(anotherAddress)

// Associate default value to parameters when can assume undefined
const { gender = 'Feminino' } = pessoa
const { publicPlace: { address: someAddress = "Sem Localizacao" } } = pessoa
console.log(gender, someAddress)


// Destructuring a undefined variable going crash the program, the law of js: you never access, manipulate, etc a 
// variable from a undefined variable/reference. Your father don't can be undefined =)


//Array examples
const [n1, , n3, , n5, n6 = 0] = [10, 7, 9, 8]
console.log(n1, n3, n5, n6)

const [, [, nota]] = [[, 8, 8], [9, 6, 8]]
console.log(nota)

//Receiving in a function an object e already destructuring it
function rand({ min = 0, max = 100 }){
    const valor = Math.random() * (max - min) + min;
    return Math.floor(valor);    
}

const obj = {min: 50, max: 500}
console.log(rand(obj))

//Receiving in a function an object e already destructuring it
function rand2([ min = 0, max = 100 ]){
    if(min > max) [min, max] = [max, min]

    const valor = Math.random() * (max - min) + min;
    return Math.floor(valor);    
}

console.log(rand2([50, 40]))
console.log(rand2([50]))
console.log(rand2([, 50]))
