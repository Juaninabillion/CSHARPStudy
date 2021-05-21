using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
   public class LeetCodeProblems
    {
        LeetCodeProblems()
        {

        }

        public static void LogestPalindromicSubstring(string s)
        {
            //problem 5.
            //loop to go through string and compare its revese
            Dictionary<string, int> answer_holder = new Dictionary<string, int>();
            string answer = null;
            int placeholder = 0;
            for (var i = 0; i < s.Length; i++)
            {
                
                if (s[i] == s[(s.Length -1)-i])
                {
                    // if its the first time in the loop, set a place holder for where the first palindrone was found.
                    if (placeholder == 0) placeholder = i;
                    answer += s[i];
                }
                if(placeholder > 0)
                {
                    answer_holder.Add(answer, answer.Length);
                    i = placeholder;
                    placeholder = 0;
                }
            }
        }
    }
}
