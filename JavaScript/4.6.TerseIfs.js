var cherub = 'Cupid';
// cherub = 'Some Other Guy';

if (cherub === 'Cupid') console.log("Ouch, an arrow!  Ooo, I'm in love!"); // if cherub is set to "some other guy", nothing happens.


if (cherub === 'Cupid')
    console.log("Ouch, an arrow!  Ooo, I'm in love!");
else
    console.log("I feel nothing!");
// No curly braces! But this means that only ONE action will execute. If you want multiple actions to execute under "if" or "else", then you need to wrap them all in curly braces. Might be better to get into the habit of using the curly braces so that extra instructions can be added without too much trouble. Verbosity is a good thing, sometimes.

var wantForChristmas = 'puppy',
    gotForChristmas = 'puppy',
    cryAboutIt = false;

if (wantForChristmas === gotForChristmas) {
    console.log('Yay! The little children are so pleased!');
    cryAboutIt = false;
} else {
    console.log('Oh no! Sad Christmas!');
    cryAboutIt = true;
}
// With curly braces, we can include multiple instructions to be executed if the initial statement is true, or in the else section. We can put as much as we want between those curly braces, and it's easy to add more if we've included the proper whitespace and the curly braces.

if (cryAboutIt) {
    console.log('Child says: WAAAAAAAAAAAAAAAAAAAAAAAAA!');
}
// Because cryAboutIt is set to a boolean (true or false), and an if statement literally checks the expression in parentheses for a true or false state, a variable set to a boolean can be used all by itself. The above code would look to see if cryAboutIt is true.
if (!cryAboutIt) {
    console.log('Yay! The little children are so pleased!');
}
// Notice the ! in front of cryAboutIt. This reverses the state, and asks "is cryAboutIt false?"

var animal = 'cat';
// animal = 'dog';

animal === 'cat' ? console.log('You will be a cat herder.') : console.log('You will be a dog catcher.'); // ? is called the ternary operator. This is another if/then variation. What this is saying is "if animal = 'cat', then print 'You will be a cat herder', otherwise print 'You will be a dog catcher.'" The "if" is implied, then "then" is replaced by ? and the else is truncated to :

var job = (animal === 'cat' ? 'cat herder' : 'dog catcher'); // We can set up a variable using the ternary operator. Handy! So with this line, we check the value of animal and if it's cat, job is set to one thing but if it's anything else, job is set to dog catcher.

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Statements#if...else_Statement
//
// Truthy and falsy values are discussed here:
// https://developer.mozilla.org/en-US/docs/JavaScript/A_re-introduction_to_JavaScript#Other_types
//
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Operators/Conditional_Operator