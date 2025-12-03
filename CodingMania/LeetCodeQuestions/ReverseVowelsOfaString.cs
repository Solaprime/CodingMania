using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions
{
    internal class ReverseVowelsOfaString
    {
        public class ReverseVowelsofaString(string s)
        {
            //Create a data source to Find or LOOKUP THE vOWELS
            //ITERATE THE sTRING 
            //AND chECK WHERE THE vOWELS ARE 
            //lOCATE THE pOINT WJERE THE    OWEL ARE IN A ARARYA
            //STRING.REVERSE
            //ITERATE FROM LAST AND REPLACE THE vOWEL

            //My Solution Wrong 
            public string ReversevOWELS( string s)
            {
                string reversedString = "";
                var charArray = new Char[] {'a', 'e', 'i', 'o', 'u' };
                
                //I need the indext
                List<int> index = new List<int>();
                for (int i = 0;  i < s.Length; i++)
                {
                    charArray.Contains(s[i]);
                    index.Add(i);
                }
               //  s.Replace()
               var result = s.ToCharArray();
                for (int i = 0; i < result.Length; i++)
                { 
                
                
                }
                return reversedString;
            }

            ///ChatGpt Solution
            public string ReverseVowels(string s)
            {
                // Convert the string into a character array for easy manipulation
                char[] chars = s.ToCharArray();

                // Define the set of vowels (both upper and lower case)
                HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

                // Initialize two pointers
                int left = 0;
                int right = s.Length - 1;

                // Perform a two-pointer approach
                while (left < right)
                {
                    // Move the left pointer until it points to a vowel
                    while (left < right && !vowels.Contains(chars[left]))
                    {
                        left++;
                    }

                    // Move the right pointer until it points to a vowel
                    while (left < right && !vowels.Contains(chars[right]))
                    {
                        right--;
                    }

                    // Swap the vowels
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;

                    // Move the pointers inward
                    left++;
                    right--;
                }

                // Convert the modified character array back to a string and return
                return new string(chars);
            }
        }
    }
}
