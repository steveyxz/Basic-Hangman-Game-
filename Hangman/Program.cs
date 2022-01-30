using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Hangman
{
    class Program
    {

        static void Main(string[] args)
        {
            startGame(10);
            while (true)
            {
                Console.Write("Do you want to play again? (y/n) ");
                string inp = Console.ReadLine();
                if (inp == "n" || inp == "no")
                {
                    Console.WriteLine("Thanks for playing! ");
                    break;
                }
                else
                {
                    startGame(10);
                }
            }
        }


        private static void startGame(int guesses)
        {
            Random r = new Random();
            //Read the words
            string[] words = Properties.Resources.words.Split("\n");
            //Word format is [word clue] where word will have _ instead of spaces
            string line = words[r.Next(words.Length)];
            String[] split = line.Split(" ");
            string word = split[0].Replace('_', ' ');
            string clue = "";
            int count = 0;
            foreach (string s in split)
            {
                if (count != 0)
                {
                    clue += s;
                    clue += " ";
                }
                count++;
            }
            string currentGuess = "";
            foreach (char c in word)
            {
                if (c == ' ')
                {
                    currentGuess += ' ';
                }
                else if (char.IsLetter(c))
                {
                    currentGuess += '_';
                }
            }
            int guessesRemaining = guesses;
            StringBuilder guessed = new StringBuilder();
            Console.WriteLine("Hangman started! " + currentGuess);
            while (guessesRemaining > 0)
            {
                Console.Write("Enter a word or a letter: ");
                string guess = Console.ReadLine();
                if (guess.Length == 1)
                {
                    //Guessed a character
                    if (char.IsLetter(guess[0]))
                    {
                        if (guessed.ToString().IndexOf(guess[0]) != -1)
                        {
                            Console.WriteLine("You have already guess that character!");
                            continue;
                        }
                        if (word.Contains(guess[0]))
                        {
                            guessed.Append(guess[0]);
                            count = 0;
                            StringBuilder sb = new StringBuilder(currentGuess);
                            foreach (char c in word)
                            {
                                if (c == guess[0])
                                {
                                    sb[count] = guess[0];
                                }
                                count++;
                            }
                            currentGuess = sb.ToString();
                            if (currentGuess != word)
                            {
                                Console.WriteLine("Correct guess! " + currentGuess);
                                continue;
                            }
                            else
                            {
                                win(guessesRemaining, word);
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Letter is not in the word! " + currentGuess);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid character provided!");
                        continue;
                    }
                }
                else
                {
                    if (guess.Length < 1)
                    {
                        Console.WriteLine("Input cannot be empty!");
                        continue;
                    }
                    if (guess == word)
                    {
                        win(guessesRemaining, word);
                        return;
                    }
                    Console.WriteLine("Incorrect guess! " + currentGuess);
                }
                guessesRemaining--;
                if (guessesRemaining == Math.Floor(guesses / 2d))
                {
                    Console.WriteLine("Here's a clue! " + clue);
                }
            }
            Console.WriteLine("You lose! The correct word was " + word);
        }
        private static void win(int remainingGuesses, string word)
        {
            Console.WriteLine("You win with " + remainingGuesses + " remaining guesses! The word is " + word);
        }



    }
}
