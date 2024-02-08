function talkLaterOf(sec, phrase) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve(phrase)
        }, sec * 1000)
    })
}

talkLaterOf(2, 'TAKE AWAYYYYY')
    .then(phrase => console.log(phrase))

//TODO exercises