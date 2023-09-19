new Vue({
    el: '#desafio',
    data: {
        name: 'Márcio Tenório',
        age: 25,
        linkCats: 'https://i.ytimg.com/vi/g0_oSny-BX4/maxresdefault.jpg'
    },
    methods: {
        ageTimesThree(){
            return this.age * 3;
        },
        randomNumber(){
            return Math.random();
        }
    }
})