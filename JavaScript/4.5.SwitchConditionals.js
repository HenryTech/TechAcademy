var answer = window.prompt('Type YES, NO, or MAYBE.  Then click OK.');

// This accomplishes the same thing as the if/else code block in 4.4.IfConditionals.js. Switch starts the whole thing going, and the computer reads just enough of the case statement to determine if that part is true. If it's not, it moves on to the next case statement. When it hits the break statement, it ends the switch operation. If it finally comes to the default statement, it executes that no matter what, then hits the break statement.
switch (answer) {
    case 'YES' :
        console.log('You said YES!');
        break; // if we took this break out, it would stop looking for case and just cascade down the line until it hits a break.
    case 'MAYBE' :
        console.log("You said maybe. I don't know what to make of that.");
        break;
    case 'NO' :
        console.log('You said no. :(');
        break;
    default :
        console.log('You rebel, you!');
        break;
}

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Statements/switch