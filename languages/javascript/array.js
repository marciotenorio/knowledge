const valores = [5,3,7,8,9,0]

valores[10] = 11

console.log(valores)

valores.push({id: 3}, 99, 'Márcio', null, undefined)

console.log(valores)

console.log(valores.pop(),'\n', valores)

delete valores[0]

console.log(valores)
console.log(typeof valores)