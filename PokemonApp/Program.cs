using System;

namespace PokemonApp{

    class Program{

        public static void battle(Pokemon player, Pokemon computer){

            Console.WriteLine("Begin Pokemon Battle!");
            Random computerRolls = new Random();


                Console.WriteLine("Choose an attack: 1-4");
                Console.WriteLine("1. "+ player.getMoveset(0).getAbilityName()
                 + " 2. " + player.getMoveset(1).getAbilityName()
                 + " 3. " + player.getMoveset(2).getAbilityName()
                 + " 4. " + player.getMoveset(3).getAbilityName());

                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your Damage dealt: "+player.attack(input-1));
 
                int computersInput = computerRolls.Next(1,5);
                Console.WriteLine(computersInput);

                Console.WriteLine("Computer's damage dealt: " + computer.attack(computersInput-1));

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

            Console.WriteLine(magikarp.getHealth());
            magikarp.setHealth(20);
            Console.WriteLine(magikarp.getHealth());

            Program.battle(magikarp,pikachu);
        }
        

    }

}