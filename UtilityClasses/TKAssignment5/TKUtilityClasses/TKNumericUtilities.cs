using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Taraneh Khaleghi
/// #7725062
/// Assignment#5
/// August 7, 2018
/// </summary>

namespace TKAssignment5.TKUtilityClasses
{
    public static class TKNumericUtilities
    {
        public static Boolean IsNumeric(string param)    // 1-a check if a string contains a number and receive a string//
        {
            Regex pattern = new Regex(@"^\-?\.?\d+\.?\d+$");
            if (pattern.IsMatch(param))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean IsNumeric(Object param)     // 1-a receive an object,and convert it to string and send it to 
        {                                                 //last method to check if it is number//
            string newParam = param.ToString();
            Boolean result = IsNumeric(newParam);
            return result;
        }

        public static Boolean IsInteger(string param)     // 2-a check if a string contains an integer and receive a string//
        {
            Regex pattern = new Regex(@"^\d+$");
            if (pattern.IsMatch(param))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean IsInteger(double param)   //2-a receive a double and check it if it is integer//
        {           
            string newParam = param.ToString();
            Boolean result = IsInteger(newParam);
            return result;
        }
        public static Boolean IsInteger(Object param)   //2-receive object ,and check if the user inpput contains integer
        {                                              //by calling first integer method to check the format//
            string newParam = param.ToString();
            Boolean result = IsInteger(newParam);
            return result;
        }

        public static string ExtractNumeric(string userInput)    //if the user enter $,space, comma, and more than one dash, 
        {                                                        //it will be removed//                                                                   
            Boolean result = IsNumeric(userInput);
            int countDash = 0;
            int countDecimal = 0;
            if (result==false)
            {                
                foreach (char character in userInput)
                {
                    int currencyIndex = userInput.IndexOf("$");
                    if (currencyIndex != -1)
                    {
                        userInput = userInput.Remove(currencyIndex, 1);
                    }
                    if (char.IsLetter(character))
                    {
                        userInput = userInput.Remove(userInput.IndexOf(character), 1);
                    }
                    if (character =='-')                         // it counts the number of dash//
                    {
                        countDash++;
                    }
                           
                    int spaceIndex = userInput.IndexOf(" ");
                    if (spaceIndex != -1)
                    {
                        userInput = userInput.Remove(spaceIndex, 1);
                    }
                    int commasIndex = userInput.IndexOf(",");
                    if (commasIndex != -1)
                    {
                        userInput = userInput.Remove(commasIndex, 1);
                    }                   
                    if (character == '.')
                    {
                        countDecimal++;                             // It counts decimals//
                    }
                }
                foreach(char cahracter in userInput)               // if there are more thn one decimla, it removes from last
                {                                                  //one until it contains one decimal//
                   if (countDecimal != 1 && countDecimal!=0)
                   {
                        userInput = userInput.Remove(userInput.LastIndexOf("."), 1);
                        countDecimal--;
                   }
                }
                
                if (countDash==1)                                 // if there is a single dash, and it isn't at the first, it checks, if it is at the end, it will                                                                    //
                {                                                //be removed, and put it as the first character//
                    if (userInput.IndexOf("-")!=0)
                    {
                        if (userInput.IndexOf("-") == userInput.Length - 1)
                        {
                            userInput = userInput.Remove(userInput.IndexOf("-"), 1);
                            userInput = userInput.Insert(0, "-");
                        }
                        else
                        {
                            userInput = userInput.Remove(userInput.IndexOf("-"), 1);  //if a single dash is in the middle, it will be removed//
                        }

                    }
                }
                else                                           // if there are more than one dash, it will reomove all of them//
                {
                    foreach (char character in userInput)
                    {
                        if (userInput.IndexOf("-")!=-1)
                        {
                            userInput = userInput.Remove(userInput.IndexOf("-"), 1);
                        } 
                    }
                }
            }
            result = IsNumeric(userInput);
            if (result)
            {
                return userInput;
            }
            else
            {
                return null;
            }           
        }

        public static void OnlyInputDigits(KeyPressEventArgs e)      //check user input during typing,     
        {                                                            //user can't enter anything except digits//
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }   
    }
}

