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

        public void setAbilityName(string name){
            this.abilityName = name;
        }

        public int getDamage(){
            return this.damage;
        }

        public void setDamage(int healthLost){
            this.damage = healthLost;
        }

        public int getSpeed(){
            return this.speed;
        }

        public void setSpeed(int num){
            this.speed = num;
        }

        public string printSpecificAbility(){
            return "Abilities name is: " + this.abilityName + " Ability Damage is: " + this.damage + " Ability Speed is: " + this.speed;
        } 

    }
}