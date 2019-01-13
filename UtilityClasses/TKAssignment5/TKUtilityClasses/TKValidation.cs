using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/// <summary>
/// Taraneh Khaleghi
/// #7725062
/// Assignment#5
/// August 7, 2018
/// </summary>

namespace TKAssignment5.TKUtilityClasses
{
    public static class TKValidation
    {
        public static Boolean ValidatePostalCode(string userInput)      //It compares user input with the valid Canadian Postal Code//
        {
            Regex pattern = new Regex(@"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$"
                            ,RegexOptions.IgnoreCase);
            if (pattern.IsMatch(userInput) || userInput=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
        public static Boolean ValidateZipCode(string userInput)         //It extract every punctuation and letter from user input//
        {
            int count = 0;
            if (userInput!="")
            {
                foreach (char  character in userInput)
                {
                    if (char.IsPunctuation(character) || char.IsLetter(character))
                    {
                        userInput = userInput.Remove(userInput.IndexOf(character), 1);
                    }
                }
                foreach (char character in userInput)
                {
                    if (char.IsDigit(character))
                    {
                        count++;
                    }
                }
            }
            if (count == 5 || count == 9)                     //After extarction if it has 5 or 9 digits, it returns true//
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean ValidatePhoneNumber(string userInput)  //It extract every punctuation and letter from user input//
        {
            int count = 0;
            if (userInput != "")
            {
                foreach (char character in userInput)
                {
                    if (char.IsPunctuation(character) || char.IsLetter(character))
                    {
                        userInput = userInput.Remove(userInput.IndexOf(character), 1);
                    }
                }
                foreach (char character in userInput)
                {
                    if (char.IsDigit(character))
                    {
                        count++;
                    }
                }
            }
            if (count == 10)                                           //if it contains 10 digits, it returns true//
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
