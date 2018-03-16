/*
Author          : Sr Programmer Analyst Oleg Gorlov
Description:	: Assigment 
Copyright       : GMedia-IT-Consulting 
email           : oleg_gorlov@yahoo.com
Date            : 03/15/2018
Release         : 1.0.0
Comment         : 

2) Create your own class or a set of functions that implement a stack. 

   Include the following four methods:a. Push: Adds a data element to the top of the stackb. 
   Pop: Removes a data element from the top of the stack. 
   Size: Returns the total number of elements in the stack. 
   isEmpty: Returns true if the stack is empty.Insert your answer here

   C# Program Implemented Stack with Push and Pop operations.
   Push enters an item on the stack, 
   Pop retrieves an item, moving the rest of the items in the stack up one level.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSystems
{
    public class StringUtils : IStringUtils 
    {

        #region Property
        private string _str_Original;  
        #endregion

        #region Construct
        public StringUtils()
        {

        }
        //public StringUtils(string str_Original) 
        //{
        //    _str_Original = str_Original;
        //}
        #endregion

        /// <summary>
        /// a function IsMirrorSequence() which takes two character string arguments 
        /// </summary>
        /// <returns> boolen  Returns true if string  is  MirrorSequence pattern</returns>
        public bool IsMirrorSequence(String _str_Original) 
        {

            string st_Reverse = Reverse(_str_Original);

            //Console.WriteLine(" st_Original '{0}'.", _str_Original);
            //Console.WriteLine(" st_Reverse '{0}'.", st_Reverse);

            decimal str_Length = _str_Original.Length;
            int str_Length1 = Convert.ToInt32(Math.Floor(str_Length / 2));

            //Console.WriteLine(" str_Length '{0}'.", str_Length);
            //Console.WriteLine(" str_Length1 '{0}'.", str_Length1);

            // Get first three characters.
            string sub1 = _str_Original.Substring(0, str_Length1);
            string sub2 = st_Reverse.Substring(0, str_Length1);


            //Console.WriteLine(" sub1 '{0}'.", sub1);
            //Console.WriteLine(" sub2 '{0}'.", sub2);

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("String.Equals(sub1, sub2)");
            //Console.WriteLine("st_Original '{0}' is MirrorSequence pattern", );

            //--Console.WriteLine("Is sub1 equal to sub2?: {0}", String.Equals(sub1, sub2));


            return String.Equals(sub1, sub2);
        }

        /// <summary>
        /// a function Reverse that reverses the order of a sentence.
        /// </summary>
        /// <param name="str_input">string</param>
        /// <returns> result  returns a string reverses the order of a sentence</returns>
        public string Reverse(String text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
