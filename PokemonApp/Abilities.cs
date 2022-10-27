using System;

namespace PokemonApp{

    class Abilities{

        private string abilityName {get; set;}
        private int damage {get; set;}
        private int speed;

        public Abilities(string name, int healthLost,int speed){
            this.abilityName = name;
            this.damage = healthLost;
            this.speed = speed;
        }
    
        public string getAbilityName(){
            return this.abilityName;
        }

        public int getDamage(){
            return this.damage;
        }

        public int getSpeed(){
            return this.speed;
        }

    }
}