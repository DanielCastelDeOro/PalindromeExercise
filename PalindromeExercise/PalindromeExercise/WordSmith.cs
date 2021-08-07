using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
   public class WordSmith
    {
        public bool isAPalidrome(string word)
        {
            var rev = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                rev += word[i];
            }
            if (rev == word)
            {
                return true;
            }
            else
            {
                return false; 
            }
            
           // return word.EndsWith(word); word.StartsWith(word);
        }
    }
}
