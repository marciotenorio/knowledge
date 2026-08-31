const peso = 1.0
const peso2 = Number('2.2')

console.log(peso, peso2)
console.log(typeof peso, typeof peso2)
console.log(Number.isInteger(peso), Number.isInteger(peso2))

const avaliacao1 = 9.871
const avaliacao2 = 6.871
const total = avaliacao1 * peso + avaliacao2 * peso2
const media = total / (peso + peso2) 

console.log(media.toFixed(2))
console.log(media.toString(2)) //base para binario, default é decimal
console.log(typeof media)
console.log(typeof Number)
