using System;
using System.Collections.Generic;

namespace Program{
    class WordleGame{
        List<char>correct = new List<char>{};
        List<char>incorrect = new List<char>{};
        List<char>inWord = new List<char>{};
        int guesses;
        string answer;

        public WordleGame(){
           string path = "./wordBank.txt";
           string[]words = File.ReadAllLines(path);
           Random rng  = new Random();
           
           int wordIndex = rng.Next(words.Length);
           this.answer = words[wordIndex];
           Console.WriteLine(this.answer);
        }

        public WordleGame(string word){
            this.answer = word;
        }

        public void play(){
            if(this.answer.Length!=5){
                //if they choose a word with wrong length
                Console.WriteLine("Please choose a word with 5 letters");
            }else{
                //else play the game
                Console.WriteLine("Let the game begin!");
            while(this.correct.Count!=5){
                this.correct.Clear();
                this.incorrect.Clear();
                this.inWord.Clear();
                Console.WriteLine("\n What is your guess?");
                string guess = Console.ReadLine();

                char[] guessArray = guess.ToCharArray();
                for(int i = 0; i < 5 ; i ++){
                    check(i,guessArray[i]);
                }
                Console.WriteLine("These words are in the correct order");
                foreach (char letter in this.correct)
                    Console.Write(letter);
                
            
                Console.WriteLine("\n These Letters are in the word:");
                foreach (char letter in this.inWord)
                    Console.Write(letter);
                Console.WriteLine("\n These letters are not in the word");
                foreach (char letter in this.incorrect)
                    Console.Write(letter);

                this.guesses++;
            }
            Console.WriteLine($"Congratulations you guessed the word, it took you {this.guesses} guesses");
            }
        }

        public bool check(int index,char letter){
            char[]characters = this.answer.ToCharArray();
            if (characters[index]==letter)
                this.correct.Add(letter);
             else if(characters.Contains(letter))
                this.inWord.Add(letter);
            else 
                this.incorrect.Add(letter);
            return true;
        }
    }
}