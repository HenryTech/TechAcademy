// This is a transcript of the lines of code from the lesson.
// You can copy and paste each line into a JavaScript console to execute it and see the result.

"This is a string";
"12";
12;

'This is also a string';
'This is a string"; // mismatched quotes - this will not execute

'<a href="">'; // You can use either ' or ", whichever isn't going to fuck you up.
'<a href="http://www.example.com">';

"This is Joe's favorite string"; // Using " since ' would screw us up due to the ' in Joe's.
"This is Joe's \"favorite\" string"; // Backslash is an escape, so if you have to screw around with quotes, escape them out.
"This is Joe's "favorite" string"; // this line will not work since the "" aren't escaped out. We could have used ' instead, but then we would have had to escape out the ' in Joe's.

var myString = "This is my string. Leave it alone";
myString;
myString.length; // Returns the length, in characters, of myString
myString.toUpperCase(); // Converts the entire string to upper case.

"This is my string".length; // Also returns the length of the string preceding it.

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Values,_variables,_and_literals
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Global_Objects/String