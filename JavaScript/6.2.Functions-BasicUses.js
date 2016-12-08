fuddify("Be very quiet, I'm hunting rabbits.");
fuddify("You screwy rabbit.");
fuddify("Rabbit tracks!");

function fuddify(speech) {
    // if it's not a string, return an error message
    if (typeof speech !== 'string') return "Nice twy, wabbit!";
    // otherwise, make it sound like Elmer Fudd
    speech = speech.replace(/r/g, 'w'); // The g modifier finds all matches without stopping after the first match. This is called a global match. What this expression says is "when you find a lowercase r, replace it with w"
    speech = speech.replace(/R/g, 'W'); // "When you find an uppercase R, replace it with W."

    return speech; // This prints out the modified version of whatever was input as speech.
}

var utterance = fuddify("You screwy rabbit");
utterance; // We just applied the function to the value of utterance, which changes it to Fuddspeak.

function isOdd(num) {
    if (num % 2 === 0) {
        return false;
    } else {
        return true;
    }
}
// This is a useful little function that will return a boolean based on whether any number or variable is odd or even. If num modulo 2 = 0, then it's not odd. Otherwise, it's odd.

12 % 2;
isOdd(45);

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Functions
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Statements/function