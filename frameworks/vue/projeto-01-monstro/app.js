new Vue({
    el: '#app',
    data: {
        playerLife: 100,
        monsterLife: 100,
        playing: false,
        logs: []
    }, 
    computed: {
        playerWon() {
            return this.monsterLife == 0;
        },
        endOfGame() {
            return this.playerLife == 0 || this.monsterLife == 0;
        },
        showLogs() {
            return this.logs.length;
        }
    },
    methods: {
        startGame() {
            this.playerLife = 100,
            this.monsterLife = 100,
            this.logs = [],
            this.playing = true;
        },
        surrender() {
            this.playing = false;
            this.playerLife = 0;
        },
        attack() {
            let playerAttack = Math.floor( (Math.random() * 10));
            let monsterAttack = Math.floor( (Math.random() * 10) + 3);

            if(this.playerLife - monsterAttack < 0){
                this.playerLife = 0
            }
            else{
                this.playerLife -= monsterAttack;
            }
                        
            if(this.monsterLife - playerAttack < 0){
                this.monsterLife = 0   
            }
            else{
                this.monsterLife -= playerAttack;
            }

            this.logs.push(`Attack: Monster = -${playerAttack} and Player = -${monsterAttack}`);
        },
        specialAttack () {
            let playerDamageTaken = Math.floor( (Math.random() * 10) + 2 );
            let monsterDamageTaken = Math.floor( (Math.random() * 10) + 6);

            if(this.playerLife - playerDamageTaken < 0)
                this.playerLife = 0
            else
                this.playerLife -= playerDamageTaken

            if(this.monsterLife - monsterDamageTaken < 0)
                this.monsterLife = 0
            else
                this.monsterLife -= monsterDamageTaken;
            
            this.logs.push(`Special Attack: Player = -${monsterDamageTaken} and Monster = -${playerDamageTaken}`);
        },
        heal() {
            let playerHeal = Math.floor( (Math.random() * 10) + 2);
            let playerDamageTaken = Math.floor( (Math.random() * 10) + 6);
            
            if(this.playerLife + playerHeal > 100)
                this.playerLife = 100
            else
                this.playerLife += playerHeal

            if(this.playerLife - playerDamageTaken < 0)
                this.playerLife = 0
            else
                this.playerLife -= playerDamageTaken;

            this.logs.push(`Heal: Player = +${playerHeal} and Player = -${playerDamageTaken}`);
        }
    },
    watch: {
        playerLife() {
            if(this.playerLife == 0)
                this.surrender()
        },
        monsterLife() {
            if(this.monsterLife == 0)
                this.surrender()
        },
        
    }
})