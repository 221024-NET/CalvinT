using System;

namespace PokemonApp{

    class Abilities{

        private string abilityName {get; set;}
        private int damage {get; set;}

        public Abilities(string name, int healthLost){
            this.abilityName = name;
            this.damage = healthLost;
        }
    
        public string getAbilityName(){
            return this.abilityName;
        }

        public int getDamage(){
            return this.damage;
        }

    }
}