/*
You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.
Return the merged string.

Example 1:
Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1: a b c
word2: p q r
merged: a p b q c r

Example 2:
Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1: a b
word2: p q r s
merged: a p b q r s
*/

using System.Runtime.ExceptionServices;

namespace Assignment_7._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string word1 = "abc";
            //string word2 = "pqr";

            string word1 = "ab";
            string word2 = "pqrs";

            CombineStrings combineStrings = new CombineStrings();

            char[] result = combineStrings.Combined(word1, word2);

           combineStrings.Print(result);


        }

        public class CombineStrings
        {
            public char[] Combined(string word1, string word2)// returns char
            {
                int word1Length = word1.Length; // store the lengths of word1 and word2
                int word2Length = word2.Length;
                int maxWordCombined = word1Length + word2Length; // calculates total lenght to iterate through considering lenght and also is the input for char[] result array.
                
                char[] result = new char [maxWordCombined]; // create a char array to hold all the characters in the combined string
                int index = 0; // use an index to track the current index in the result array and incremented in the if statement to correspond to each word value.
                
                for (int i = 0; i < maxWordCombined; i++)
                {
                    if (i < word1Length) // will execute if i less than word1Length. This is reference to i in the for loop. It will iterate through 0 and 1 then will not pass again through this condition.
                    {
                        result[index++] += word1[i]; //Assigns word1 value to the current result index ie. 1st iteration result array index 0 gets 'a'. 2nd iteration result array index 2 gets 'b'.
                        
                    }
                    if (i < word2Length)// will execute if i less than word2Length. This is reference to i in the for loop
                    {
                        result[index++] += word2[i]; //Assigns word2 value to the current result index. 1st iteration result array index 1 gets 'p'. 2nd iteration result array index 3 gets 'q'.
                        
                    }
                   
                }
                return result; // returns char[]

            }

            public void Print(char[] result) //recieves and prints char array result
            {
                foreach (char c in result)
                {
                    Console.Write(c + " ");
                }
            }
        }
    }
}
