function speakSomething (what) {
    for (var i = 0; i < 10; i += 1) {
        console.log(what);
    }
}
// Simple and straightforward. This takes what and logs it to the console 10 times using a for loop.

var speakSomething = function(what) { // This is setting a variable to an anonymous function
    for (var i = 0; i < 10; i += 1) {
        console.log(what);
    }
}

window.setTimeout(speakSomething, 5000); // window is a global object in JavaScript. One of its built-in functions is setTimeout, which takes 2 arguments: the first is an actual function, the 2nd is a timer that counts down before executing the function that's just been invoked.

var obj = {
    'function' : function() {
                   console.log('Hello');
                 }
};
// Here we set up an object called obj that has only one property. The tag is "function" and the value is an anonymous function that logs "hello" to the console.
// Functions are objects and can be manipulated like any other object and passed around as values, just like any other value.

obj.function(); // Hello

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Functions
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Statements/function