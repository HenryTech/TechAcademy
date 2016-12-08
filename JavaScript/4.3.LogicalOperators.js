var animal1 = 'monkey';
var animal2 = 'bear';
var animal3 = 'tiger';

// && is a logical and. Let's ask some questions about those variables we just set.

animal1 === 'monkey' && animal2 === 'bear'; // true (is animal1 "monkey" AND animal2 "bear"?)

animal1 === 'ape' && animal2 === 'bear'; // false (is animal1 "ape" AND animal2 "bear"?)

animal1 === 'ape' && animal2 === 'bear' && animal3 === 'tiger'; // false (is animal1 "ape", animal2 "bear" AND animal3 "tiger"?)

animal1 === 'monkey' && animal2 === 'bear' && animal3 === 'tiger'; // true (I think we understand this now, yes?)

// || is a logical or. We're going to ask some more questions now.

animal1 === 'monkey' || animal2 === 'bear'; // true (is animal1 "monkey" OR is animal2 "bear"?)

animal1 === 'ape' || animal2 === 'bear'; // true (is animal1 "ape" OR is animal2 "bear"?)

animal1 === 'ape' || animal2 === 'ostrich'; // false

// We can nest these logical operators, of course!


animal1 === 'monkey' || animal2 === 'bear' && animal3 === 'tiger'; // true Ands are always evaluated before ors, so this question is actually asking 'Is animal2 "bear" and animal3 "tiger"? OR is animal1 "monkey"?'

animal1 === 'ape' || animal2 === 'bear' && animal3 === 'tiger'; // true Again, the ands come first, so since the AND part of the statement is true, it overrides the OR part of the statement.

(animal1 === 'ape' || animal2 === 'monkey') && animal3 === 'tiger'; // false (is animal1 "ape" OR is animal2 "monkey" AND is animal3 "tiger"?) In this case, both the logic in the parentheses AND the logic after must be true to return a true result. This is a way to make the ors come first!

animal1 === 'monkey' && animal2 === 'bear'; // true

// ! is a logical NOT.

!(animal1 === 'monkey' && animal2 === 'bear'); // false (is animal1 NOT "monkey" AND is animal2 NOT "bear"?) This could be stated as animal1 !== "monkey" && animal2 !== "bear"; The NOT operator completely flips all the operators inside the parentheses.

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Expressions_and_Operators#Logical_operators