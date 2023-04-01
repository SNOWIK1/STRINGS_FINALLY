using System;

namespace StringsTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            /////////////////////////  TASK    17   ////////////////////////////////////////
            Console.WriteLine("\nTASK 17. Eter any words in brackets or without it: ");
            string text = Console.ReadLine();
            int count = 0;
            bool inBrackets = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    inBrackets = true;
                }
                else if (text[i] == ')')
                {
                    inBrackets = false;
                }
                else if (inBrackets && text[i] != ' ')
                {
                    count++;

                    while (i < text.Length - 1 && text[i + 1] != ' ')
                    {
                        i++;
                    }
                }
            }

            Console.WriteLine("Количество слов в скобках: " + count);
            ///////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////  TASK   18     ///////////////////////////////////////////////////////
            Console.WriteLine("\nTASK 18. Enter any words: ");
            string words = Console.ReadLine();
            int amount = 0;
            string[] wordsArr = words.Split(' ');
            foreach (string word in wordsArr)
            {
                if (word.StartsWith('A'))
                {
                    amount++;
                }
            }

            Console.WriteLine(amount);
            ///////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////   TASK   19       //////////////////////////////////////////////////
            Console.WriteLine("\n\nTASK 19. Enter any words: ");
            string string19 = Console.ReadLine();
            string output = "";
            string[] words19 = string19.Split(' ');
            int quantity = 0;
            foreach (string word in words19)
            {
                if (word[0] == word[word.Length - 1])
                {
                    quantity++;
                    output += word + " ";
                }
            }
            Console.WriteLine($"Quantity of words with same first and last letter: {quantity}" +
            $"\nThe words: {output}");
            /////////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////  TASK   20    ///////////////////////////////////////////////////////
            bool isNotPassed = false;
            do
            {
                Console.WriteLine("\nTASK 20. Enter three or more words: ");
                string string20 = Console.ReadLine();
                if (string20.Length >= 3)
                {
                    string[] words20 = string20.Split(' ');

                    Console.WriteLine($"The first letter of the third word is {words20[2][0]}");
                    isNotPassed = false;
        
                }
                else
                {
                    Console.WriteLine("Not enough words, try again...");
                    isNotPassed = true;
                }
            } while (isNotPassed);

            /////////////////////////////////////////////////////////////////////////////////////////////////////


            ///////////////////////////////// TASK   21   ////////////////////////////////////////////////////////////////////
            Console.WriteLine("\nTASK 21. Enter any words: ");
            string string21 = Console.ReadLine();
            Console.WriteLine("\nEnter ONE character with which the word should have started: ");
            string character = Console.ReadLine();
            int count21 = 0;

            string[] words21 = string21.Split(' ');
            foreach (string word in words21)
            {
                if (word.Length%2==0 && word.StartsWith(character))
                {
                    Console.WriteLine($"The word(-s) with even length and which starts with entered character is {word}");
                    count21++;
                } else if (count21 == 0)
                {
                    Console.WriteLine("No such word found...");
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////



            ///////////////////////////////// TASK   22   ////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nTASK 22. Enter any words: ");
            string string22 = Console.ReadLine();
            string[] arr = string22.Split(' ');
            string shortest = "";

            foreach (string word in arr)
            {
                int min = arr[0].Length;
                 if (word.Length < min)
                {
                    min = word.Length;
                    shortest = word;
                }
            }

            Console.WriteLine($"\nThe shortest word in the string is {shortest}");



            ////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

    }
}
