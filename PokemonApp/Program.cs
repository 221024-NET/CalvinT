using System;

namespace PokemonApp{

    class Program{

        public void battle(Pokemon player, Pokemon computer){
            
        }

        static void Main(string[] args)
        {
            Abilities[] movesetA = new Abilities[4]{
                new Abilities("flamethrower",50,20),
                new Abilities("tackle",20,30),
                new Abilities("splash",0,10),
                new Abilities("bite",30,50),
            };
            Pokemon pikachu = new Pokemon("pikachu",21,"rat",100,movesetA);
            Abilities[] movesetB = new Abilities[4]{
                new Abilities("flamethrower",50,20),
                new Abilities("tackle",20,30),
                new Abilities("splash",0,10),
                new Abilities("bite",30,50),
            };
            Pokemon magikarp = new Pokemon("magikarp",22,"fish",200,movesetB);
            pikachu.printAbilities();
            Console.WriteLine(pikachu.getMoveset(2).getDamage());
        }
        

    }

}