function handleError(error){
        // throw new Error("Some message!!!");
        // throw 10;
        // throw true;
        throw {
            nome: error.name,
            data: new Date,
            mensagem: error.message
        }

}



function showScreamingMessage(obj){
    try{
        console.log(obj.name.toUpperCase());
    }
    catch(error){
        handleError(error)
    }
}

const obj = {nome: "Márcio Tenório"}

showScreamingMessage(obj)