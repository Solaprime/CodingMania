using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.InterviewQuestions
{
    public class ChunkQuestion
    {
        ////aNDELA BABE MESSAGE ME lINKDIN
        ///tJ dO AM
        //Beans 
        //MY sOLUTION, i NO sABIU AM
        public string[] GetArrayChunksMine(string s, int chunks)
        {
            
            //Check if chunk and String Lenth is not Zero
            if (s.Length == 0   ||  chunks == 0)
            {
                return new string[] { };
            }
            
            //Get   LengthOF array 
            //var lengthOfArry = Math.Ceiling(s.Length / chunks); 
            var lengthOfArry = s.Length / chunks; 

           
            //Chuynk with the Method 
           var chunkArray =  s.Chunk(chunks);

            //New Array of Length 
            var result = new string[] { };

            return null;
        }

        //My UgradeD Solution
        //Wont WOrk
        public string[] GetArrayChunksMine2(string s, int chunks)
        {

            //Check if chunk and String Lenth is not Zero
            if (s.Length == 0 || chunks == 0)
            {
                return new string[] { };
            }

            //Get   LengthOF array 
            //var lengthOfArry = Math.Ceiling(s.Length / chunks); 
            double resultOfDivision = s.Length / chunks;
            var lengthOfChunk = (int)Math.Ceiling(resultOfDivision);


            //Chuynk with the Method 
            // 5 and 2
            // 7 and 2 
            var chunkArray = s.Chunk(lengthOfChunk);

            //New Array of Length 
            var result = new string[] { };

            return null;

        }

        //cHATGPT sOLUTIOON, 2 mETHODS, GetEnumerable and GetArrayChunks
        // Method that returns an IEnumerable<string>
        public static IEnumerable<string> GetEnumerable(string s, int chunks)
        {
            if (chunks <= 0) throw new ArgumentException("Chunks must be greater than zero.");

            //For the Iteration you are iterating by Chunks
            for (int i = 0; i < s.Length; i += chunks)
            {
                //Returns the Smaller Number out of the TWO NUMBER BY cOMPARTING  Math.Min()
                yield return s.Substring(i, Math.Min(chunks, s.Length - i));
               // return s.Substring(i, Math.Min(chunks, s.Length - i));
            }
        }


        // Method that returns an array of strings
        public static string[] GetArrayChunks(string s, int chunks)
        {
            return GetEnumerable(s, chunks).ToArray();
        }


        //Deepseek Solution

        public IEnumerable<string> GetEnumerable2(string s, int chunks)
        {
            if (chunks <= 0)
            {
                yield break;
            }

            if (string.IsNullOrEmpty(s))
            {
                yield return s;
                yield break;
            }

            int length = s.Length;
            int chunkSize = (int)Math.Ceiling((double)length / chunks);

            for (int i = 0; i < length; i += chunkSize)
            {
                int remaining = length - i;
                int currentChunkSize = Math.Min(chunkSize, remaining);
                yield return s.Substring(i, currentChunkSize);
            }
        }
        public string[] GetArrayChunks2(string s, int chunks)
        {
            return GetEnumerable2(s, chunks).ToArray();
        }
    }
}

//Create a solution in C# to chuck string eg 
//string s = "abcde"  int chunks = 2 Result = [ "abc" , "de"]

//string s = "abcdefgh" int chunks =2  Result = ["abc", "def", "gh" ]

//public IEnumerable<string> GetEnumerable (string s , int chunks){}

//public string[] GetArrayChunks(string s , int chunks){}Create a solution in C# to chuck string eg 
//string s = "abcde"  int chunks = 2 Result = [ "abc" , "de"]

//string s = "abcdefgh" int chunks =2  Result = ["abc", "def", "gh" ]

//public IEnumerable<string> GetEnumerable (string s , int chunks){}

//public string[] GetArrayChunks(string s , int chunks){}
