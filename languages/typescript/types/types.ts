// Inferidos na atribuição
// Da para passar flag para não gerar o arquivo js se tiver erro
let nome = "Márcio Tenório Júnior"
console.log(nome)
// nome = 28


// numbers
let idade = 27
// idade = 'Tony'
idade = 27.5
console.log(idade)


// boolean
let tsELegal = true
// tsELegal = 1
console.log(tsELegal)


// tipos explicitos
let minhaIdade
minhaIdade = 27
console.log(typeof minhaIdade)
minhaIdade = 'Idade é 26'
console.log(typeof minhaIdade)
// Isso acontece por que o ts nao conseguiu inferir o tipo na declaração
// já que não foi atribuido nenhum tipo, ele vira any e pode ser qualquer coisa 
// sem o o compiler reclamar 
// Amarrando para um tipo definido
let some: string;
// some = 22
some = 'Tenoriozera'
console.log(some)


// array
// ele infere o tipo do array
let hobbies = ["Cozinhar", "Jogar"]
console.log(hobbies[0])
console.log(typeof hobbies)


// hobbies = [100], ou
let hobbies2: any[] = ["Cozinhar", 22, {}]
let hobbies3: string[] = ["Tony", "Victor", "Joelma"]


// tuplas
let endereco: [string, number, string] = ["Av. Princial", 99, ""]
console.log(endereco)

endereco = ["Nuplam", 8989, "UFRN Campus"]
console.log(endereco)


// enum
enum Cor {
    Cinza, //0
    Amarelo, //1
    Preto, //2
    Verde = 100,
    Azul,  //101
    Marrom, //102
    Vermelho = 3,
    Rosa, //4
    VerdeClaro = 100 //posso repetir valores
}

let minhaCor: Cor = Cor.Azul;
console.log(Cor.Rosa, Cor.Verde, Cor.VerdeClaro)


// any
let carro: any = 'BWM'
console.log(carro)

carro = {name: 'BWM', 'year': 2021}
console.log(carro)


// js gerado da pra ver como o typescript converte pra js


// função
function returnMyName(): string { // definindo o tipo de retorno
    return nome;
}
console.log(returnMyName())


function digaOi(): void {
    console.log("Hello =)")
}
digaOi()

// definindo os tipos dos parâmetros
function mult(numA: number, numB: number): number {
    return numA * numB;
}
console.log(mult(2.2, 3).toFixed(2))

// tipo função]

// let calculo = digaOi não posso fazer isso pois ele vai inferir o tipo
// pra definir o tipo: (params:type, ...) => retorno 
let calculo: (numeroA: number, numeroB: number) => number
// NOSONAR
// calculo = digaOi
// calculo()

calculo = mult
console.log(calculo(2, 3.4))


// objetos
let usuario = {
    name: "Tony",
    age: 26
}

// perdeu os atributos com os tipos definidos
// usuario = {}

// usuario = {
//     name: "Victor",
//     idade: 17
// }

usuario = {
    name: "Victor",
    age: 17,
}

// definindo objeto
let usuarioDefinido: {name: string, age: number}
usuarioDefinido = usuario


// Criando um tipo, um alias
type Funcionario = {
    supervisores: string[],
    baterPonto: (horas: number) => string
}


// union types
let nota: number | string = 10
console.log(`Minha nota é ${nota}!`)
nota = '10'
console.log(`Minha nota é ${nota}!`)


// chegando tipos runtime
let valor = 30

// o ts faz isso automático, não preciso fazer isso
// se mudar 30 para true ele vai reclamar e dependendo de como o compiler
// ta configurado ele nem gera o js
if(typeof valor === "number")
    console.log('igual')
else 
    console.log(typeof valor)


// tipo never pra especificar que a função vai ter erro ou nunca retorna nada
function falha(msg: string): never {
    throw new Error(msg)
}

falha('relou');