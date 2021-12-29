let eAtivo = false;

console.log('os verdadeiros')

console.log(!!3)
console.log(!!-1)
console.log(!!' ')
console.log(!![])
console.log(!!{})
console.log(!!Infinity)
console.log(!!(eAtivo = true)) //ele resolve o booleano para o valor que esta sendo atribuido

console.log('os falsos')
console.log(!!0)
console.log(!!'')
console.log(!!null)
console.log(!!NaN)
console.log(!!undefined)
console.log(!!(eAtivo = false)) 

console.log('para finalizar')
console.log(('' || null || undefined || 'relou' || 'mens')) //retorna o primeiro true

let nome = 'Lucas'

console.log(nome || 'Desconhecido')