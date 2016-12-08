var thing = 12;
thing = 'twelve';
typeof thing; // "string"

thing = 12;
typeof thing; // "number"

thing = false;
typeof thing; // "boolean"

thing = {};
typeof thing; // "object"

thing = [];
typeof thing; // "object" ... WOOPS! Because js thinks that arrays are objects.
typeof thing === 'object' && thing.hasOwnProperty('length'); // true
// This is a way to check if thing is an array. What we're saying is "if thing is an object, and thing has the property 'length'". We get back a simple true/false, but this true/false tells us if thing is an array or not. Note the hasOwnProperty method--this checks whether something has a given property, which is passed as a string in parentheses after the method. Arrays have several properties unique to them, but one of them is length, which objects do not have.

thing = {};
typeof thing === 'object' && thing.hasOwnProperty('length'); // false
// Objects do not have lengths, so this line returns false, which if we're paying attention, would determine whether thing is an object or an array.

NaN;
typeof NaN; // Weirdly, js tells us that the typeof NaN is "number". Maybe not a useful thing to use in your code.

typeof null; // "object" HUH?
thing === null; // Currently, this is false. This is a good way to check if a variable is null.
thing = null;
thing; // null
thing === null; // true

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Operators/typeof