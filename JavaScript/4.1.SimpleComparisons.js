/* 	===:strict equal
	==:equal
	!==:strict not-equal
	!=:not-equal
There is an actual difference between these two functions, but until we get into advanced learning, it's best to stick with === and !==.
*/
	

1 === 1;  // true
1 !== 1;  // false
1 !== 2;  // true
1 === 2;  // false
// === tests if the object on the left is identical to the object on the right. !== tests if the object on the left is NOT identical to the object on the right.

1 == 1; // true
1 == '1'; // true (?!)
1 === '1'; // false
1 != '1'; // false
// == tests if the object on the left is similar to the object on the right.

1 < 2; // true

1 > 2; // false

1 <= 2; // true

1 <= 1; // true

1 >= 2; // false

10 >= 2; // true

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Expressions_and_Operators#Comparison_operators