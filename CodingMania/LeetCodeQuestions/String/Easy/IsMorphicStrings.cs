using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     
     Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.

 

Example 1:

Input: s = "egg", t = "add"

Output: true

Explanation:

The strings s and t can be made identical by:

Mapping 'e' to 'a'.
Mapping 'g' to 'd'.
Example 2:

Input: s = "foo", t = "bar"

Output: false

Explanation:

The strings s and t can not be made identical as 'o' needs to be mapped to both 'a' and 'r'.

Example 3:

Input: s = "paper", t = "title"

Output: true

 

Constraints:

1 <= s.length <= 5 * 104
t.length == s.length
s and t consist of any valid ascii character.
     */
    class IsMorphicStrings
    {
        /*
         You're given two strings, s and t. You need to determine whether they are isomorphic.

Two strings are isomorphic if you can consistently map characters from s to characters in t, such that:

Every character in s maps to one and only one character in t.

The character order must be preserved.

No two different characters in s can map to the same character in t.

A character can map to itself.
        <e, a>
        <g, d>
        <g, d>
        s = "egg"
        t = "add"


        <f, b>
        <o, a>
        <o, r>
        s = "foo"
        t = "bar"
         'f' → 'b'

      o' → 'a' (first time)

        'o' → 'r' (second time) ❌ Invalid — 'o' tried to map to both 'a' and 'r'.

     ❌ Inconsistent mapping → Not isomorphic.

      Output: false

        <p, t>
        <a, i>
        <p, t>
        <e, l>
        <r, e>

         s = "paper"
         t = "title"

          'p' → 't'

        'a' → 'i'
       'p' → 't' ✅ again same mapping
       'e' → 'l'
        'r' → 'e'
    ✅ Valid. All mappings are consistent and unique.
    Output: true
         */

        public bool IsIsomorphic(string s, string t)
        {

            //  If lenght differs they can not be Ismorphic
            if (s.Length != t.Length)
                return false;

            //Recall Dictionary Stores data in Key value Pair
            //Go from s and T
            Dictionary<char, char> mapST = new();  //Tracks mapping from s → t

            //Track characters in t that are already Mapped
            HashSet<char> mappedChars = new();// Tracks characters in t that are already mapped Ensures no two characters in s map to the same character in t.


            //Loop through S
            for (int i = 0; i < s.Length; i++)
            {
                //Since they have of the Same Legnth
                //We save both in variable
                char charS = s[i];
                char charT = t[i];

                /*
                 If charS was already mapped before, it must map to the same charT.

                 If not, return false because mapping changed.

                So if the Dictionary Contains Chars
                //that charS must be mapped to the Corresponding CharT


                Note you are Using charS as the Key
                so if mapSt Contains that Key
                we check if it is for the Corresponding
                charT
                Since you are Mapping from s  To T
                 */
                if (mapST.ContainsKey(charS))
                {
                    if (mapST[charS] != charT)
                        return false; // existing mapping doesn't match current t character
                }

                //Meaning it is the FirstTime we are Seeing CharS, 
                //So we check if charT is already mapped to another charS (which would break the rules).
                //f safe, record the mapping and proceed.

                //Since it is not in the Dictionary
                //So we enter the Else block

                else
                {
                    //Since we use the T to track Unique Case
                    //We check if is insided to HashSet and retuen
                    //the Corresponding badRequest
                   
                    if (mappedChars.Contains(charT))
                        return false;

                    //Save the Record in thw Dictionary and Dictionary
                    mapST[charS] = charT;
                    mappedChars.Add(charT);
                }
            }
            // If we finish the loop without conflicts, the strings are isomorphic.

            return true;
        }
    }
}

/*
 * Why is if else and Inner if's in the Particular order above
 
 Great question! Let's break down why the if-else and the inner ifs are structured in that specific order in this isomorphic string problem.

Here's the relevant logic again for reference:

if (mapST.ContainsKey(charS))
This checks: "Have we already mapped this character from string s?"

If yes, then we must make sure that it maps to the same character in t every time.

So inside it, we do:


— this ensures that the mapping is consistent.
If it's inconsistent, we immediately return false.

Why else follows?
If charS hasn't been mapped yet, we need to create a new mapping. But before we do that, we must make sure that no other character from s has already mapped to the same charT.

This avoids two different s characters mapping to the same t character, which would violate isomorphism.

Then, if that check passes, we safely add the mapping:
 */
