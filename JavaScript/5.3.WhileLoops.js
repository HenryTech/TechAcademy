// for loop
for (var i = 0; i < 10; i++) {
    console.log(i);
}

// same thing as a while loop, only with a different syntax. Note that once the expression turns false (i<10), the loop ends. i actually makes it to 10, but then it kills the while loop. So "10" is returned on the last line, but none of the rest of the text.
var i = 1;
while (i < 10) {
    console.log(i + '... This will go until we hit 10');
    i += 1;
}



var myArray = [true, true, true, false, true, true];

var myItem = null;
while (myItem !== false) {
    console.log('myArray has ' + myArray.length + ' items now. This loop will go until we pop a false.');
    myItem = myArray.pop();
}
// Using a conditional to set the length of our loop. Once the conditional turns to false, the loop ends. We have NO IDEA how big the array is, or how long it will take to end the loop, which is why we use a while loop. With a for loop, we'd just keep looping until we exhausted the entire array. However, we DO have a condition that we know will happen, which will break the loop: we know there's a false in there somewhere.


var counter = 1;
while(true) {
    console.log(counter);
    counter++;
    break; // comment out this break statement to make this loop go forever and potentially lock up your web browser. Break can be used to break out of any block.
}
// The danger of while loops: it's possible to create an infinite loop if the condition you set is never met. Infinite loops are bad.

var myArray = [true, true, true, false, true, true];

var myItem = false;
while (myItem !== false) {
    console.log('myArray has ' + myArray.length + ' items now. This loop will go until we pop a false.');
    myItem = myArray.pop();
}
// In this case, myItem is set to false right from the get-go, so when the browser hits the while loop, it won't even execute a single iteration of it since the condition has already been met. We can work around that (see below)!


var myArray = [true, true, true, false, true, true];

var myItem = false;
do {
    console.log('myArray has ' + myArray.length + ' items now. This loop will go until we pop a false.');
    myItem = myArray.pop();
} while (myItem !== false);
// This ensures that the code will be executed at least once before the browser checks the while condition. This is called a do/while loop. Once that code is executed (in this case), myItem changes and can then be properly evaluated in the while conditional.


// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Statements/while
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Statements/do...while