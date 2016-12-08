var animal = {
    'genus' : 'bird',
    'species' : 'raven',
    'callType' : 'squawky',
    'quote' : 'Nevermore',
    'maxOffspring' : 5,
    'noisy' : true,
    'deadly' : false
};

animal.quote; // "Nevermore"

animal."quote"; // this does not work

animal["quote"]; // "Nevermore"

animal.color = "black"; // This changes the value assigned to the color tag to "black".

animal;

animal["where it lives"] = "in a tree";
animal.whereItLives = "in a tree"; // These are two ways of changing the value of animal.whereItLives to "in a tree".
animal.whereItLives;
animal['whereItLives']; // These are two ways of displaying the value of animal.whereItLives.

delete animal.color;
animal; // There is now no tag or value for animal.color

var emptyObject = {};
emptyObject.isItReallyEmpty = false; // It was empty, but we just added a tag and a value to it.
emptyObject;

animal;


// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Working_with_Objects
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Global_Objects/Object