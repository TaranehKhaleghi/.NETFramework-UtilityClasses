# .NETFramework-UtilityClasses
NumericUtility Class:
A number is defined as one or more digits with an optional leading dash and an optional single decimal place anywhere in the number.
	Two Boolean methods called IsNumeric … one accepts a string parameter and the other accepts an Object parameter.  They both return true   if the parameter contains only a number.
An integer is defined as a number that does not contain a fractional portion (no decimal place).  
	Three Boolean methods called IsInteger … one accepts a string, one a double and one an object.
Users often enter currency symbols, commas, spaces and trailing dashes in numeric field
The string method that returns the string less everything except digits, the decimal place and a dash.  If there was a single dash (leading or trailing), it puts it as the first character.  If the result is numeric, it returns it as a string, else return null.
The void method accepts a KeyPressEventArgument as a parameter.  If the property KeyChar is not a digit, it sets the property Handled to true.
StringUtility Class:
Users expect a little intelligence in apps these days: when typing names, street addresses, city names, etc., they expect the app to correct their typing.
	The static string method accepts a string as a parameter. it drops the whole string to lower case, then capitalize the first letter of       every word. It returns the capitalized string.  If the original string is null, it will return null. 
Sometimes users use strange punctuation for numeric strings like phone numbers, credit card numbers, account numbers, zip codes, etc., which make comparisons difficult.
	The static string method accepts a string parameter and returns a string with just the digits from it.
I like to standardise the format of things when I store them into a database:
	The static string method accepts a string with 7 or 10 digits and reformats it into either the 123-1234 or 123-123-1234 pattern.
	The static string method accepts a string representing a Canadian Postal Code, shifts it to upper case and inserts the space if it is     missing (and the length permits doing so).  If the original string is null, will return null.
	The static string method accepts a string with 5 or 9 digits and reformats it into either the 12345 or 12345-1234 pattern.
Full name is useful for reports, comparisons and so on.
	The string method called FullName that accepts two strings (any case): one the first name, one the last name, and returns the full name,   capitalized, in the form: Turton, David.
	If only one of the names is provided, just return that, with no punctuation.
	If neither name is provided, return null.
	Validation Class:
	The boolean method validates a Canadian Postal Code pattern (A3A 3A3), ensuring the first letter is one of the valid 18 letters, and     the remaining letters are one of the valid 20 letters.  Accept either upper case or lower case and the space is optional.  
	If the string is null or empty, return true.
	The boolean method extracts the digits from a string representing a US Zip Code and confirms that it contains either 5 or 9 digits
	The boolean method extracts the digits from a string representing a phone number and confirms that it contains exactly 10 digits.

	





