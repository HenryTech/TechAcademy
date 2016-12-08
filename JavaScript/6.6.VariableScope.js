var myNum = 32; // Look we just set myNum = 32
var myResult = 'Success!';

function randomizer(limit) {
    var myNum = Math.floor(Math.random() * limit); // And here we are setting myNum to a completely different value, to be determined by a variable entered into this function. Since we're initializing the value fresh within the function, it stays discrete. If we simply removed the "var" from this line, it would change the global variable.

    console.log('myNum is ' + myNum);
    console.log('Global myNum is ' + window.myNum); // window.myNum is the global version of myNum, not the discrete version limited to this randomizer function.

    return myNum;
}

randomizer(10);

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Functions#Function_scope