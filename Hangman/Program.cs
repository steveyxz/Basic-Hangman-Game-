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
            Console.WriteLine("Hint: " + giveHints(index));
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
        static string giveHints(int index)
        {
            string hint = "";
            switch (index)
            {
                case 0:
                    hint = "This country is from the continent Oceania, and starts with a";
                    break;
                case 1:
                    hint = "This country overlaps into 2 continents.";
                    break;
                case 2:
                    hint = "This country is located in central Europe. They are known for their sausages and beer";
                    break;
                case 3:
                    hint = "This country is filled with pyramids";
                    break;
                case 4:
                    hint = "...holy land of mecca";
                    break;
                case 5:
                    hint = "Known for their double decker red buses";
                    break;
                case 6:
                    hint = "At the bottom of the African continent";
                    break;
                case 7:
                    hint = "Biggest country in South America";
                    break;
                case 8:
                    hint = "Their ancient ancestry was Incan";
                    break;
            }
        return hint;    
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