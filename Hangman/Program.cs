using System;

namespace hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] possibleWords = { "australia", "russia", "germany", "egypt", "saudi arabia", "united kingdom", "south africa", "brazil", "peru" };
            Random rand = new Random();
            int index = rand.Next(possibleWords.Length);
            string randomWord = $"{possibleWords[index]}";
            char[] charArr = randomWord.ToCharArray();

            Console.WriteLine("Playing hangman, press any key and enter to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine(" " + ChangeUnderscore(index));
            Console.WriteLine("#################################################      Current Topic - Countries");
            string input = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
          
            Console.ReadLine();
            Console.WriteLine($"The answer is {possibleWords[index]}");
            Console.ReadLine();




        }
        static string ChangeUnderscore(int index)
        {
            string aCountry = "";

                switch (index)
                {
                    case 0:
                        aCountry = "_ _ _ _ _ _ _ _ _";
                        break;
                    case 1:
                    aCountry = "_ _ _ _ _ _";
                        break;
                case 2:
                    aCountry = "_ _ _ _ _ _ _";
                    break;
                case 3:
                    aCountry = "_ _ _ _ _";
                    break;
                case 4:
                    aCountry = "_ _ _ _ _   _ _ _ _ _ _";
                    break;
                case 5:
                    aCountry = "_ _ _ _ _ _   _ _ _ _ _ _ _";
                    break;
                case 6:
                    aCountry = "_ _ _ _ _   _ _ _ _ _ _";
                    break;
                case 7:
                    aCountry = "_ _ _ _ _ _";
                        break;
                case 8:
                    aCountry = "_ _ _ _";
                        break;
            }
            return aCountry;
        }
    }
        
}