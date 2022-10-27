using System;

namespace PokemonApp{

    class Pokemon{
        
        //Fields - by default they are Private. 
        public string name {get; set;}
        int DexNumber {get; set;}
        string type {get; set;}
        int health {get; set;}
        Abilities[] moveset = new Abilities [4];

        //Static field - every pokemon shares this field and it's value
        public static string isPokemon = "This is a static field. We've been through this, I'm in fact a pokemon.";
        
        //Constructor - method used for object initialization. We pass it the values we want 
        //to set for the object we are creating.

        public Pokemon(string PokemonName, int PokemonNum, string PokemonType, int PokemonHealth, string PokemonAbility = "default?"){

            this.name = PokemonName;
            this.DexNumber = PokemonNum;
            this.type = PokemonType;
            this.health = PokemonHealth;
            //this.ability = PokemonAbility;
            //lets add a default moveset for now
            this.moveset[0] = new Abilities("bite",20);
            this.moveset[1] = new Abilities("scratch",10);
            this.moveset[2] = new Abilities("flamethrower",50);
            this.moveset[3] = new Abilities("splash",0);
        }


        public Pokemon(){

        }

        public Pokemon(string PokemonName){
            this.name = PokemonName;
            this.DexNumber = 12;
        }

        //Instance method - depends on the state of an instance of that class. Belongs to the object. 
        public void PrintName(){
            Console.WriteLine("My name is " + this.name + "." + " My number is " + this.DexNumber );

        }

        //Static method - belongs to the class itself
        public static void PrintMessage(){
            Console.WriteLine("This is a static method, and I am a pokemon.");
        }

        //Method Overriding - ToString()
        public override string ToString(){
            return this.name + " " + this.type;
        }

        public void printAbilities(){
            for(int i = 0;i < 4 ; i++){
                Console.WriteLine("Ability name is "+ moveset[i].getAbilityName() + " Damage is " + moveset[i].getDamage());
            }
        }
    }


}