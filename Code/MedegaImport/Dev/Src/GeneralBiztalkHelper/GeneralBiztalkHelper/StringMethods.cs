using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralBiztalkHelper
{
    public class StringMethods
    {
        /// <summary>
        /// Replace Method to reuse in BizTalk
        /// </summary>
        /// <param name="text">string</param>
        /// <param name="replaceText">string: character/text to replace</param>
        /// <param name="replaceWith">string: character/text to replace with</param>
        /// <returns>string: replaced text</returns>
        public static string Replace(string text, string replaceText, string replaceWith)
        {
            return text.Replace(replaceText, replaceWith);
        }
    }
}
