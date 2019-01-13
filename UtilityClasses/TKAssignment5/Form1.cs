using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Taraneh Khaleghi
/// #7725062
/// Assignment#5
/// August 7, 2018
/// </summary>

namespace TKAssignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean result = false;             // variable for the methods that return Boolean//
        string returnedInput = "";          // variable for the methodsthat return string//
        string myInput = "";

        private void onlyDigitsTextBox_KeyPress(object sender, KeyPressEventArgs e) 
        {
            TKUtilityClasses.TKNumericUtilities.OnlyInputDigits(e);   // keypress event doesn't allow user enter anything except number//
            if (e==null)
            {
                onlyDigitsLabel.Text = "no digit entered";
            }
        }

        private void submitButton_Click(object sender, EventArgs e) //by clicking the submit button all the inputs will be 
                                                                     //checked by calling their methods in their classes//
        {
            //call IsNumeric-string method//
            try
            {
                result = TKUtilityClasses.TKNumericUtilities.IsNumeric(isNumTextBox.Text);
                if (result)
                {
                    isNumLabel.Text = "Correct format ";
                }
                else
                {
                    isNumLabel.Text = "Just decimal or integer number";
                }
            }
            catch(Exception error)
            {
                isNumLabel.Text = error.Message;
            }

            //call IsNumeric-double method//
            try { 
                string myInput = isNumObjTextBox.Text;
                Object myNumObj = new Object();
                myNumObj = myInput;
                result = TKUtilityClasses.TKNumericUtilities.IsNumeric(myNumObj);
                if (result)
                {
                    isNumObjLabel.Text = "Correct format(object)";
                }
                else
                {
                    isNumObjLabel.Text = "Just decimal or integer number";
                }
            }
            catch (Exception error)
            {
                isNumLabel.Text = error.Message;
            }

            //call IsInteger-string method//
            try
            {
                result = TKUtilityClasses.TKNumericUtilities.IsInteger(isIntTextBox.Text);
                if (result)
                {
                    isIntLabel.Text = "Correct format";
                }
                else
                {
                    isIntLabel.Text = "Just integer";
                }
            }
            catch(Exception error)
            {
                isIntLabel.Text = error.Message;
            }

                //call IsInterger-object method//
                try { 
                myInput = isIntObjTextBox.Text;
                Object myIntObj = new Object();
                myIntObj = myInput;
                result = TKUtilityClasses.TKNumericUtilities.IsInteger(myIntObj);
                if (result)
                {
                    isIntObjLabel.Text = "Correct format(object)";
                }
                else
                {
                    isIntObjLabel.Text = "Just integer number";
                }
                    }
                catch(Exception error)
                {
                    isIntObjLabel.Text = error.Message;
                }

            //call IsInteger-double method//
            try
            {
                myInput = isIntDbTextBox.Text;
                double myDbInput = Convert.ToDouble(myInput);
                result = TKUtilityClasses.TKNumericUtilities.IsInteger(myInput);
                if (result==true)
                {
                    isIntDbLabel.Text = "Correct format(Int)";
                }
                else
                {
                    isIntDbLabel.Text = "It is not an integer number";
                }
            }
            catch(Exception error)
            {
                isIntDbLabel.Text = error.Message;
            }

                      //call ExtractNumeric method//
            
            returnedInput = TKUtilityClasses.TKNumericUtilities.ExtractNumeric(extractNumTextBox.Text);
            if (returnedInput == null)
            {
                extractNumLabel.Text = "Not a number entered";
            }
            else
            {
                extractNumLabel.Text = returnedInput;
            }

                     //call Capitalize method//

            returnedInput = TKUtilityClasses.TKStringUtilities.Capitalize(capitalizeTextBox.Text);
            if (returnedInput==null)
            {
                capitalizeLabel.Text = " There is no input";
            }
            else
            {
                capitalizeLabel.Text = returnedInput;
            }

                     //call ExtarctDigits method//

            returnedInput = TKUtilityClasses.TKStringUtilities.ExtractDigits(extractDigitsTextBox.Text);
            if (returnedInput==null)
            {
                extractDigitsLabel.Text = "Not a digit entered";
            }
            else
            {
                extractDigitsLabel.Text = returnedInput;
            }

                       //call FormatPostal method//

            returnedInput = TKUtilityClasses.TKStringUtilities.FormatPostal(formatPostalTextBox.Text);
            if (returnedInput==null)
            {
                formatPostalLabel.Text = "Not a digit entered";
            }
            else
            {
                formatPostalLabel.Text = returnedInput;
            }

                      //call FormatPostalCode method//

            returnedInput = TKUtilityClasses.TKStringUtilities.FormatPostalCode(formatPostalCodeTextBox.Text);
            if (returnedInput==null)
            {
                formatPostalCodeLabel.Text = "Not a postal code entered";
            }
            else
            {
                formatPostalCodeLabel.Text = returnedInput;
            }

                     //call FormatZipCode method//

            returnedInput = TKUtilityClasses.TKStringUtilities.FormatZipCode(formatZipCodeTextBox.Text);
            if (returnedInput==null)
            {
                formatZipCodeLabel.Text = "Not a postal code entered"; 
            }
            else
            {
                formatZipCodeLabel.Text = returnedInput;
            }

                       //call FullName method//

            returnedInput = TKUtilityClasses.TKStringUtilities.FullName(firstNameTextBox.Text, lastNameTextBox.Text);
            if (returnedInput==null)
            {
                fullNameLabel.Text = "NOt a name entered";
            }
            else
            {
                fullNameLabel.Text = returnedInput;
            }

            //call ValidatePostalCode method //
            try
            {
                result = TKUtilityClasses.TKValidation.ValidatePostalCode(validatePostalTextBox.Text);
                if (result == false)
                {
                    validatePostalLabel.Text = "Not valid";
                }
                else
                {
                    if (validatePostalTextBox.Text == "")
                    {
                        validatePostalLabel.Text = "It is empty";
                    }
                    else
                    {
                        validatePostalLabel.Text = "Valid postal code";
                    }
                }
            }
            catch(Exception error)
            {
                validatePostalLabel.Text = error.Message;
            }

            //call ValidateZipCode method//

            try
            {
                result = TKUtilityClasses.TKValidation.ValidateZipCode(validateZipTextBox.Text);
                if (result)
                {
                    validateZipLabel.Text = "It contains 5 or 9 digits";
                }
                else
                {
                    validateZipLabel.Text = "It doesn't contain 5 or 9 digits";
                }

                //call ValidatePhoneNumber method//

                result = TKUtilityClasses.TKValidation.ValidatePhoneNumber(validatePhoneTextBox.Text);
                if (result)
                {
                    validatePhoneLabel.Text = "It contains 10 digits";
                }
                else
                {
                    validatePhoneLabel.Text = "It doesn't contain 10 digits";
                }
            }
            catch (Exception error)
            {
                validatePhoneLabel.Text = error.Message;
            }

        }
    }
}
