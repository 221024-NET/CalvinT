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

        public Pokemon(string PokemonName, int PokemonNum, string PokemonType, int PokemonHealth, Abilities[] PokemonAbility){

            this.name = PokemonName;
            this.DexNumber = PokemonNum;
            this.type = PokemonType;
            this.health = PokemonHealth;
            this.moveset=PokemonAbility;
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
                Console.WriteLine("Ability name is "+ moveset[i].getAbilityName() 
                + " Damage is " + moveset[i].getDamage() 
                + " Speed is "+ moveset[i].getSpeed());
            }
        }

        public void setMoveSet(Abilities ability,int index){
            this.moveset[index] = ability;
        }

        public Abilities getMoveset(int index){
            return this.moveset[index];
        }

        public void setHealth(int num){
            this.health = num;
        }

        public int getHealth(){
            return this.health;
        }

        public int attack(int num){
            return this.moveset[num].getDamage();
        }
    }


}