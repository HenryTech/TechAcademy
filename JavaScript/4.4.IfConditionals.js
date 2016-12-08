// This next bit of code actually pops up a dialog window with OK and Cancel buttons. The variable is set to either true or false based on what the user clicks.
var answer = window.confirm('Click OK, get true.  Click cancel, get false.');
answer;

if (answer === true) {
    console.log('You said true!');
}
// This makes a message display in the console if the user clicked the OK button (making answer = true)

if (answer === true) {
    console.log('You said true!');
} else {
    console.log('You said something else');
}
// The else statement makes the other thing occur if the first condition isn't true. So, if cancel was clicked "You said something else" would be displayed. Note the curly braces surrounding the instructions for if AND the instructions for else.

var answer = window.prompt('Type YES, NO, or MAYBE.  Then click OK.'); // window.prompt makes a popup window with a text field
if (answer === 'YES') {
    console.log('You said YES!');
} else if (answer === 'MAYBE') {
    console.log("You said maybe. I don't know what to make of that."); // note the else if, else if statements linked together to cover multiple possibilities.
} else if (answer === 'NO') {
    console.log('You said no. :(');
} else {
    console.log('You rebel, you!');
}

var answer = window.prompt('Type YES, NO, or MAYBE.  Then click OK.');
if (answer === 'YES' || answer === 'NO') {
    console.log('You said YES!'); // This doesn't make a lot of sense, but is an example of how logical operators can be used
} else if (answer === 'NO') {
    console.log('You said no. :(');
} else {
    console.log('You rebel, you!');
}

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Statements/if...else