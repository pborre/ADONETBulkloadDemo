using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralBiztalkHelper
{
    [Serializable]
    public class SplitString
    {
        #region Fields
        private string _OriginalString;
        private char _Seperator;
        private string[] _Elements;
        #endregion

        #region Properties
        /// <summary>
        /// Get or set the OriginalString
        /// </summary>
        public string OriginalString
        {
            get { return _OriginalString; }
            set { _OriginalString = value; }
        }

        /// <summary>
        /// Get or set the Seperator
        /// </summary>
        public char Seperator
        {
            get { return _Seperator; }
            set { _Seperator = value; }
        }

        /// <summary>
        /// Get or set the Elements of the string
        /// </summary>
        public string[] Elements
        {
            get { return _Elements; }
            set { _Elements = value; }
        }

        /// <summary>
        /// Gets a 32-bit integer that represents the total number of elements of the Element Array
        /// </summary>
        public int Length
        {
            get { return this.Elements.Length; }
        }
        #endregion

        #region Constructors
        public SplitString() { }

        /// <summary>
        /// Constructor: Splits the originalstring, using the seperator info
        /// </summary>
        /// <param name="originalString">string</param>
        /// <param name="seperator">char</param>
        public SplitString(string originalString, char seperator)
        {
            SplitNow(originalString, seperator);
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Splits the originalstring, using the seperator info
        /// </summary>
        /// <param name="originalString">string</param>
        /// <param name="seperator">char</param>
        private void SplitNow(string originalString, char seperator)
        {
            if (originalString.Length != 0 && seperator.ToString().Length!=0)
            {
                this.OriginalString = originalString;
                this.Seperator = seperator;
                this.Elements = originalString.Split(new char[] { seperator });
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Splits the originalstring, using the seperator info
        /// </summary>
        /// <param name="originalString">string</param>
        /// <param name="seperator">char</param>
        public void Split(string originalString, char seperator)
        {
            SplitNow(originalString, seperator);
        }

        /// <summary>
        /// Returns the first X elements, seperated by the seprator char.
        /// </summary>
        /// <param name="numberOfParts">int : number of elements to return</param>
        /// <returns>string</returns>
        public string ConcatenateFirstXElements(int numberOfParts)
        {
            StringBuilder returnValue = new StringBuilder("");
            if (numberOfParts <= this.Elements.Length)
            {
                for(int i=0;i<numberOfParts;i++)
                {
                    returnValue.Append(this.Elements[i]);
                    if(i!=numberOfParts-1)
                        returnValue.Append(Seperator);
                }
                
            }
            return returnValue.ToString();
        }
        #endregion

    }
}
