using System;
using System.Collections.Generic;
using System.Text;
using PalindromeExercise;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word.ToLower()[i];
            }
            if(reversed == word.ToLower())
            {
                throw new NotImplementedException();
                //return true;
            }
            else
            {
                throw new NotImplementedException();
                //return false;
            }
            

        }
    }
}
