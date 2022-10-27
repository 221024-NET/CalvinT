using System;

namespace PokemonApp{

    class Program{

        static void Main(string[] args)
        {
            Abilities[] movesetA = new Abilities[4]{
                new Abilities("flamethrower",50,20),
                new Abilities("tackle",20,30),
                new Abilities("splash",0,10),
                new Abilities("bite",30,50),
            };
            Pokemon pikachu = new Pokemon("pikachu",21,"rat",100,movesetA);
            pikachu.printAbilities();
        }
        

    }

}