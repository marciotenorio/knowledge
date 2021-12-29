const escola = 'Cod3r'

console.log(escola.charAt(4))
console.log(escola.charCodeAt(4))
console.log(escola.indexOf('3'))
console.log(escola.substring(1)) //1 ate o final
console.log(escola.substring(1, 4)) //do indice 1 ate o anterior ao 4 (nao inclusivo)
console.log(escola.concat(' apredendo Vue.js '.concat(', Javascript, Webpack, mongo e etc')))
console.log(escola.replace(3, 'e'))
console.log(escola.replace(/\d/, 'e'))
console.log('Marcio, Lorena, Victor, Joelma'.split(',')) //aceita regex




const arr = ['Márcio', 'Lorena', 'Joelma', 'Sonia']

console.log(arr.filter( (name)=> {
        if(name.length == 6)
            return name
    }))