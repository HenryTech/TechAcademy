var string1 = 'This is the longest string ever.';
var string2 = 'This is the shortest string ever.';
var string3 = 'Is this the thing called Mount Everest?';
var string4 = 'This is the Sherman on the Mount.';

var regex = /this/;
// Note that the variable could be anything you desire. Regex is not a command. We could have just as easily used textSearch for this variable name.


// console.log makes the results print out in the javascript console in your browser. If you're typing these directly into the console anyway, it's redundant but important to know how to use this when writing code. If typing directly into the console you could type, e.g., regex.test(string1);
console.log( regex.test(string1) );
// This returns false, as the closest string1 comes to our search string is "This" which is not an exact match.
console.log( regex.test(string2) );
// Also false, because "This" begins with a capital T.
console.log( regex.test(string3) );
// Finally, a true! Because "this" is an exact match with no capitals.
console.log( regex.test(string4) );
// False again, due to the capital T.

// Note that regular expressions are case sensitive!

regex = /this/i;
// i is a flag, and stands for insensitive, meaning case-insensitive. If we run the same tests as above, all come back as true, since the word "this" appears in each string without regards to case.

regex = /^this/i;
// This time we've added a carat, which indicates that we're only interested if the pattern appears at the beginning of the string that we're searching.

regex = /this$/i;
// This time we've added a $. This checks to see if the pattern appears at the end of a string.

regex = /ever.$/i;
// Now we're checking for "ever" at the end of a string. In this context, though, a "." is a wildcard that stands for any character. If we're actually looking for a real ".", we need to escape it out by using a backslash.

regex = /ever\.$/i;
// We've escaped out the "." with a backslash, so now it's literally looking for a case-insensitive version of "ever." at the end of a string.

regex = /Moun.$/i;
// This will give us a false on all strings because although the "." is acting as a wildcard, the $ is asking for a match at the very end of the string and string4 ends with "Mount." We'd have to get rid of the $ to get a true for string4. String3 has "Mount" in it, which would also give us a true except that it's not at the end of its string, either.

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Regular_Expressions
// http://www.regular-expressions.info