// iterate over an array
var pageNames = ['Home', 'About Us', 'Contact Us', 'JavaScript Playground', 'News', 'Blog'];
for (var p in pageNames) {
    console.log(p + ' is ' + pageNames[p]);
}
// This is a for/in loop. The way we did this before, we had to intialize the variable, then set the limits (i.e. i < pageName.length), then set the iteration value (i.e. i += 1). With in, we specify an object we want it to step through and it will limit itself to the parts of the object, iterating automatically by 1. The order that the items are pulled out are not guaranteed to be in the proper order, when you use a for/in loop. So this is not a good idea for use with arrays.

// iterate over an object
var pages = {
    'first' : 'Home',
    'second' : 'About Us',
    'third' : 'Contact Us',
    'fourth' : 'JavaScript Playground',
    'fifth' : 'Blog',
};
for (var p in pages) {
    if (pages.hasOwnProperty(p)) { // Does this object have a property I've defined? It's important to include this check.
        console.log(p + ' is ' + pages[p]); // Instead of a number, now, p is equal to the tag in the object, and will jump to the next tag once the loop is done with this iteration and goes back to the top. So, instead of 1, 2, 3, p becomes "first", "second", and "third". The iteration becomes the tags of the object instead of actual numbers, and it limits itself to the size of the object.
    }
}

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Statements/for...in