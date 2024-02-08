# JavaScript 

# Summary

- [. . /Languages](../languages.md)
- [Promise](#promise)

## Callbacks


Problem: run things asyncronously. Like:

```js
function loadScript('myScript.js')
someFunctionInMyScript();
```

Will have issue, because the load takes more time than next statement line.
How to fix this? Callback to run when myScript loads, like:

```js
function loadScript(src, callback){
  let script = document.createElement('script');
  script.src = src;

  script.onload = () => callback(script);

  document.head.append(script);
}
```

This approach are called 'callback-based'.

How to handling erros, if our script fails to load? We can use:

```js
function loadScript(src, callback) {
  let script = document.createElement('script');
  script.src = src;

  script.onload = () => callback(null, script);
  script.onerror = () => callback(new Error(`Script load error for ${src}`));

  document.head.append(script);
}
```

so

```js
loadScript('/my/script.js', function(error, script) {
  if (error) {
    // handle error
  } else {
    // script loaded successfully
  }
});
```

Called 'error-first callback style'. The problem is if we have more than two nested calls it will
turn in a 'callback-hell'.

```js
// sem promise...
const http = require('http')

const getTurma = (letra, callback) => {
    const url = `http://files.cod3r.com.br/curso-js/turma${letra}.json`
    http.get(url, res => {
        let resultado = ''

        res.on('data', dados => {
            resultado += dados
        })

        res.on('end', () => {
            callback(JSON.parse(resultado))
        })
    })
}

let nomes = []
getTurma('A', alunos => {
    nomes = nomes.concat(alunos.map(a => `A: ${a.nome}`))
    getTurma('B', alunos => {
        nomes = nomes.concat(alunos.map(a => `B: ${a.nome}`))
        getTurma('C', alunos => {
            nomes = nomes.concat(alunos.map(a => `C: ${a.nome}`))
            console.log(nomes)
        })
    })
})
```


## Promise

[Code Ref.](./promise.js)

At first glance, ``Promise`` is like a way to put together producers and consumers.
Something takes time, interested people 'subscribe' to have it once it's available.

Constructor syntax:
```js
let promise = new Promise((resolve, reject) => {
  // executor (the producing code)
});
```

So to summarize: the executor runs automatically and attempts to perform a job. When it is finished with the attempt, it calls resolve if it was successful or reject if there was an error.

The promise object returned by the new ``Promise constructor has these internal properties:

- state — initially "pending", then changes to either "fulfilled" when resolve is called or "rejected" when reject is called.
- result — initially undefined, then changes to value when ``resolve(value)`` is called or error when ``reject(error)`` is called.

Resume:

![https://javascript.info/promise-basics](../../img/promise-state.jpg)

Example:

```js
function talkLaterOf(segundos, frase) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve(frase)
        }, segundos * 1000)
    })
}

// or 

function talkLaterOf(secs, phrase) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            reject(new Error('Sh***!' + phrase))
        }, secs * 1000)
    })
}
```

The executor will define resolve or reject to change the promise state. If either resolve or reject
the promise is called 'settled', instead of initial state 'pending'.
It will call only one time resolve or reject, the state change are final. Futher calls are ignored.

The state and result are internal the properties state and result of the ``Promise`` object are internal. We can’t directly access them. We can use the methods .then/.catch/.finally for that. They are described below.

Consumers: ``then`` and ``catch``

``then``
```js
takeLaterOf()
    .then(
        result => console.log(result), //can call only then if you only interested in this one
        error => console.log(error) 
    )
```

 ``catch``
  
If you are only interesting in errors.
If we’re interested only in errors, then we can use null as the first argument: .then(null, errorHandlingFunction). Or we can use .catch(errorHandlingFunction), which is exactly the same:

```js
takeLaterOf()
    //catch(f) is the same as then(null, f). Catch is a shorthand
    .catch(alert)
```

Cleanup ``finally``

The call ``.finally(f)`` is similar to ``.then(f, f)`` in the sense that ``f`` runs always, when the promise is settled: be it resolve or reject.

```js
takeLaterOf()
    .finally(() => console.log('close connections'))
    .then(result => console.log('result'), error => console.log(error))
```
The call ``.finally(f)`` is similar to ``.then(f, f)`` in the sense that ``f`` runs always, when the promise is settled: be it resolve or reject. 

Please note that ``finally(f)`` isn’t exactly an alias of ``then(f,f)`` though. Like:
1. A finally handler has no arguments. In finally we don’t know whether the promise is successful or not. That’s all right, as our task is usually to perform “general” finalizing procedures.

Please take a look at the example above: as you can see, the finally handler has no arguments, and the promise outcome is handled by the next handler.

2. A finally handler “passes through” the result or error to the next suitable handler.

3. A finally handler also shouldn’t return anything. If it does, the returned value is silently ignored.
 
The only exception to this rule is when a finally handler throws an error. Then this error goes to the next handler, instead of any previous outcome.

To summarize:

A finally handler doesn’t get the outcome of the previous handler (it has no arguments). This outcome is passed through instead, to the next suitable handler.
If a finally handler returns something, it’s ignored.
When finally throws an error, then the execution goes to the nearest error handler.

```js
new Promise((resolve, reject) => {
  setTimeout(() => resolve("value"), 2000);
})
  .finally(() => alert("Promise ready")) // triggers first
  .then(result => alert(result)); // <-- .then shows "value"
```
Note:
Promises are more flexible. We can add handlers any time: if the result is already there, they just execute.
Instead subscriptions, if the subscription are late the result are no longer available because the event
aren't stored, like promises.

