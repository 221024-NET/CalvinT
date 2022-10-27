using System;

namespace PokemonApp{

    class Program{

        public static void battle(Pokemon player, Pokemon computer){

            Console.WriteLine("Begin Pokemon Battle!");
            Random computerRolls = new Random();

                //Players turn
                Console.WriteLine("Player has " + player.getHealth() );
                Console.WriteLine("Choose an attack: 1-4");
                Console.WriteLine("1. "+ player.getMoveset(0).getAbilityName()
                 + " 2. " + player.getMoveset(1).getAbilityName()
                 + " 3. " + player.getMoveset(2).getAbilityName()
                 + " 4. " + player.getMoveset(3).getAbilityName());
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your Damage dealt: "+player.attack(input-1));
                computer.setHealth(computer.getHealth()-player.attack(input-1));
                Console.WriteLine("Computer has " + computer.getHealth()+ " left");

                //Computers turn
                int computersInput = computerRolls.Next(0,4);
                Console.WriteLine(computersInput);
                Console.WriteLine("Computer used "+computer.getMoveset(computersInput).getAbilityName() + "! " +" Computer's damage dealt: " + computer.attack(computersInput));
                player.setHealth(player.getHealth()-computer.attack(computersInput));
                Console.WriteLine("Player has " + player.getHealth() + " left");

        }

        static void Main(string[] args)
        {
            Abilities[] movesetA = new Abilities[4]{
                new Abilities("flamethrower",50,20),
                new Abilities("tackle",20,30),
                new Abilities("fly",20,10),
                new Abilities("bite",30,50),
            };
            Pokemon pikachu = new Pokemon("pikachu",21,"rat",100,movesetA);
            Abilities[] movesetB = new Abilities[4]{
                new Abilities("flamethrower",50,20),
                new Abilities("tackle",20,30),
                new Abilities("surf",30,10),
                new Abilities("bite",30,50),
            };
            Pokemon magikarp = new Pokemon("magikarp",22,"fish",200,movesetB);
            pikachu.printAbilities();
            Console.WriteLine(pikachu.getMoveset(2).getDamage());


            Program.battle(magikarp,pikachu);
        }
        

    }

}