using System;

namespace PokemonApp{

    class Program{

        static void Main(string[] args)
        {
            Abilities[] movesetA = new Abilities[4]{
            new Abilities("flamethrower",50),
            new Abilities("tackle",20),
            new Abilities("splash",0),
            new Abilities("bite",30),
            };
            Pokemon pikachu = new Pokemon("pikachu",21,"rat",100,movesetA);
            pikachu.printAbilities();
        }
        

    }

}