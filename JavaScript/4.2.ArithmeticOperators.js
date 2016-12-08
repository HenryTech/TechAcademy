2 + 5; // returns 7. This + operator can also work on strings to concatenate them together.
4 - 3; // returns 1
5 - 9; // returns -4
3 * 5; // returns 15
36 / 6; // returns 6
36 / 5; // returns 7.2

// Modulo operator takes the first operator, divides by 2nd and returns the remainder. Very useful in determining whether a number is even or odd!
20 % 2; // returns 0
19 % 2; // returns 1

var counter = 0;
counter = counter + 1;
counter; // counter started as 0, but now it's 1. This is a verbose way of doing this.

counter += 1; // This expresses counter = counter + 1, but in a more terse way. You can increment by any arbitrary number this way, even a negative number. Counter -= 1 would decrement by 1, and you could decrement by any number using this method. Counter *= 2 would double the variable, counter /= 2 would halve it.
counter++; // This expresses counter = counter + 1, but can ONLY be used to increment by 1. Counter-- would decrement by 1.
++counter; // This would increment the variable first. Important if you're setting another variable to the first variable.

/* 	var num1 = 5;
	var total = num1++;
For the first iteration, total is 5. Not until the 2nd and subsequent iterations is total going to get incremented. To get it to happen right away, use ++num1 instead. If I asked right now for the value of num1, it would be 6. But the value of total would only be 5. If I had used var total = ++num1, the value of total would immediately be 6. */

counter += 5; // Counter is raised by 5
counter += -4; // Counter is lowered by 4 (plus a negative number).

counter -= 1; // Counter is lowered by 1
counter--; // Another way to lower counter by 1.
counter;

counter *= 2; // Doubles counter.

"cat" + "dog"; // "catdog"
"cat " + "dog"; // "cat dog"
"cat" + " and " + "dog"; // "cat and dog"

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Expressions_and_Operators#Arithmetic_operators
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Expressions_and_Operators#String_operators