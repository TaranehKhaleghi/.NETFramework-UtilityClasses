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
    public static class TKStringUtilities
    {
       public static string Capitalize(string userInput)     //capitalize user input by convert string to array of character
        {                                                    //and convert them to the string after capitalizing//
            string capitalizedUserInput = "";
            if (userInput != "")
            {
                userInput = userInput.Trim();
                userInput = userInput.ToLower(); 
                char[] arrayUserInput = userInput.ToArray();
                arrayUserInput[0] = char.ToUpper(arrayUserInput[0]);
                
                for (int i = 0; i < arrayUserInput.Length; i++)
                {
                    if (arrayUserInput[i]== ' ')
                    {
                        arrayUserInput[i + 1] = char.ToUpper(arrayUserInput[i + 1]);
                    }
                    capitalizedUserInput += arrayUserInput[i].ToString();                  
                }
                return capitalizedUserInput;
            }
            else
            {
                return null;
            }
        }
        public static string ExtractDigits(string userInput)    //it extracts everything except digits from the user input//
        {
            if (userInput!="")
            {
                userInput = userInput.Trim();
                foreach (char character in userInput)
                {
                    if (char.IsPunctuation(character) || char.IsLetter(character))
                    {
                        userInput = userInput.Remove(userInput.IndexOf(character),1);
                    }
                }                
                return userInput;
            }
            else
            {
                return null;
            }     
        }
        public static string FormatPostal(string userInput)        //it compares user input with the pattern
        {                                                          // and put dash in index 3 or 7 if it's match//
            Regex pattern = new Regex(@"^\d{7}(\d{3})?$");
            if (userInput != "")
            {
                if (pattern.IsMatch(userInput))
                {
                    if (userInput.Length == 7)
                    {
                        userInput = userInput.Insert(3, "-");
                    }
                    else
                    {
                        userInput = userInput.Insert(3, "-");
                        userInput = userInput.Insert(7, "-");
                    }                   
                }
                else
                {
                    userInput = "The format is 7 or 10 digits";
                }
                return userInput;
            }
            else
            {
                return null;
            }                   
        }

        public static string FormatPostalCode(string userInput)        //it compares user input with the regex, and if it's 
        {                                                              //correct, change it to upper case and if it doesn't have space,
                                                                       //it will add space after character 3//
            Regex pattern = new Regex(@"^[A-Z]\d[A-Z]( )?\d[A-Z]\d$", RegexOptions.IgnoreCase);
            if (userInput != "")
            {
                if (pattern.IsMatch(userInput))
                {
                    userInput = userInput.Trim();
                    userInput = userInput.ToUpper();
                    if (!(userInput.Contains(" ")))
                    {
                        userInput = userInput.Insert(3, " ");
                    }
                }
                else
                {
                    userInput = "The format is A1A 1A1";
                }
                return userInput;
            } 
            else
            {
                return null;
            }
        }
        public static string FormatZipCode(string userInput)     //it compares user input with regex, it could be 5 or 9 digits
        {                                                        //if it has 9 digits, it will add dash after position 5//
            Regex pattern = new Regex(@"^\d{5}(-?\d{4})?$");
            if(userInput!="")
            {
                userInput = userInput.Trim();
                if (pattern.IsMatch(userInput))
                {
                    if (!userInput.Contains("-") && userInput.Length==9)
                    {
                        userInput = userInput.Insert(5, "-");
                    }                  
                }
                else
                {
                    userInput = "Only 5 or 9 digits";
                }
                return userInput;
            }
            else
            {
                return null;
            }
        }
        public static string FullName (string firstName, string lastName)  //It takes first name and last name and is user input
        {                                                                   // both, it will return both with comma between them
            string fullName = "";                                           //if not, it will return on of them or null//
            if(firstName!="" || lastName!="")
            {
                
                if (firstName != "" && lastName != "")
                {
                    firstName = Capitalize(firstName);
                    lastName = Capitalize(lastName);
                    fullName = lastName + ", " + firstName ;
                }
                else if (lastName == "")
                {
                    firstName = Capitalize(firstName);
                    fullName = firstName;
                }
                else
                {
                    lastName = Capitalize(lastName);
                    fullName = lastName;
                }
            }            
            else
            {
                fullName = null;
            }
            return fullName;
        }


    }    
}
