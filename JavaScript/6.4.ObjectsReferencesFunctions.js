// This section could be called "How to reference an object or array with a function without changing the original object or array."
var calvin = {
    'name' : 'Calvin',
    'bestFriend' : 'Hobbes',
    'form' : 'human boy',
};

// you can also pass an object to a function
// because objects are passed by reference, the argument will be modified
function transmogrifier(calvin) {
    if (typeof calvin !== 'object') {
        console.log('argument is of the wrong type'); // makes sure the argument is an object. It's best to do error checking like this with any function that might take in input from a user.
        return;
    }

    // generate a random number between 1 and 5. math.floor returns the largest integer less than or equal to a given number. In this case, Math.random()*5 is the given number.
    var randomNumber = Math.floor(Math.random() * 5) + 1;

    switch(randomNumber) {
        case 1 :
            calvin.form = 'tyrannosaurus';
            break;
        case 2 :
            calvin.form = 'grey wolf';
            break;
        case 3 :
            calvin.form = 'bengal tiger';
            break;
        case 4 :
            calvin.form = 'grizzly bear';
            break;
        case 5 :
            calvin.form = 'canary';
            break;
        default :
            // do nothing - he stays human
            break;
    }
}

// this version of the transmogifier does return a copy, leaving the original alone
function transmogrifyCopy(calvin) {
    if (typeof calvin !== 'object') {
        console.log('argument is of the wrong type');
        return;
    }

    // generate a random number between 1 and 5
    var randomNumber = Math.floor(Math.random() * 5) + 1;
    var newForm = calvin.form; // by default, do not change

    switch(randomNumber) {
        case 1 :
            newForm = 'tyrannosaurus';
            break;
        case 2 :
            newForm = 'grey wolf';
            break;
        case 3 :
            newForm = 'bengal tiger';
            break;
        case 4 :
            newForm = 'grizzly bear';
            break;
        case 5 :
            newForm = 'canary';
            break;
        default :
            // do nothing - he stays human, or whatever calvin.form was before we started
            break;
    }

    // return a new object that's just like calvin,
    // but transmogrified!
    return {
        'name' : calvin.name,
        'bestFriend' : calvin.bestFriend,
        'form' : newForm
    };
}
// So the way this function is used is by typing var newCalvin = transmogrifyCopy(calvin). It leaves calvin unchanged, but createse a new object (called newCalvin or whatever you want) that has a changed form.

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Functions
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Statements/function