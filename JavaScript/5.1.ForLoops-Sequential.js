for (var i = 0; i < 10; i += 1) {
    console.log(i);
}
// for comes first, then 3 statements. i is often used in real code, stands for "index". i usually starts at 0, just like array indexes. So the first statement is i = 0. The next statement is a condition, under which we stop looping. Once i hits 9, we won't loop again. The third statement tells us how to increment i. Could also work as i++. In the curly braces, we put the things we want to happen every time the loop runs. Returns 0-9, line by line. We could replace console.log(i) with some real instructions, and once it hits the curly braces it'll go back, increment i and do it all again.

// very common use case: looping over an array. Note that document is a global object in JavaScript. Title is one of its inherent properties, so on a real webpage, document.title would return the title of the page we're on.
var pageNames = ['Home', 'About Us', 'Contact Us', 'JavaScript Playground', 'News', 'Blog'];
for (i = 0; i < pageNames.length; i += 1) {
    if (document.title == pageNames[i]) {
        console.log('We ARE here: ' + pageNames[i]);
    } else {
        console.log('We are not here: ' + pageNames[i]);
    }
}
// So what this does is step one at a time through the pageNames array, checking the document.title against the contents of that position in the array. It keeps outputting "We are not here: " and then the contents of that position in pageNames, then returning to the top of the loop and incrementing i.

// don't repeat yourself:
var pageNames = ['Home', 'About Us', 'Contact Us', 'JavaScript Playground', 'News', 'Blog'];
for (i = 0; i < pageNames.length; i += 1) {
    var currentPageTitle = pageNames[i];
    if (document.title == currentPageTitle) {
        console.log('We ARE here: ' + currentPageTitle);
    } else {
        console.log('We are not here: ' + currentPageTitle);
    }
}
// In this case we've added the variable currentPageTitle and use that throughout the loop instead of pageNames[i], which adds an extra line but makes the code easier for a human to read.

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Statements#for_Statement
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Statements/for