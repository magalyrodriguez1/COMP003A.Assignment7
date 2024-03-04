using System.Reflection.Metadata.Ecma335;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Array - Character Counter");

            Console.WriteLine("Please enter a letter");
            char characterInput = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter a word");
            string word = Convert.ToString(Console.ReadLine());
            CharacterCounter(characterInput, word);

            SectionSeparator("Array - Palindrome");
            Console.WriteLine("Enter a word to check if it is a palindrome");
            string palindrome = Convert.ToString(Console.ReadLine());
            IsPalindrome(palindrome);

            List<string> names = new List<string>();
            names.Add("Magaly");
            names.Add("Rodriguez");
            names.Add("Velazquez");

            char userInput = default;
            do
            {
                Console.WriteLine("Press any key to add more or (e) to exit.");
                userInput = Convert.ToChar(Console.ReadLine);
            }
            while (userInput != 'e');

            TraverseListReverse(names);

            
        }
        
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine($"{section} section");
            Console.WriteLine("".PadRight('*'));
        }
        static int CharacterCounter(char characterInput, string word)
        {
            int count = 0;
            foreach (char c in word)
            {
                characterInput = char.ToLower(characterInput);
                word = word.ToLower();
                count++;
            }
            return count;
            Console.WriteLine($"There are {count} letter {characterInput} in the word {word}");
            
            string list = Convert.ToString(Console.ReadLine());
        }
        
        static bool IsPalindrome(string word)
        {

            char[] wordInput = word.ToCharArray();
            Array.Reverse(wordInput);
            string revWord = new string(wordInput);
            Console.Write($"Is the word {word} a palindrome:");

            return true;
        }
            
        static void TraverseList(List<string>list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i]; 
            }
            Console.WriteLine(list.Count);
        }

        static void TraverseListReverse(List<string>list)
        {
            list.Reverse();
        }
    }
}



