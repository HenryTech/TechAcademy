var animal = {
    'genus' : 'bird',
    'species' : 'raven',
    'callType' : 'squawky',
    'quote' : 'Nevermore',
    'maxOffspring' : 5,
    'noisy' : true,
    'deadly' : false
};
animal;

var animal2 = animal;
animal2;

animal2.genus = 'bear';
animal2;
animal;
// Once we've assigned a variable to equal an object, all changes made to one will be reflected in the other--it's really just a reference to that location in memory!

var animal2 = {
    'genus' : 'bird',
    'species' : 'raven',
    'callType' : 'squawky',
    'quote' : 'Nevermore',
    'maxOffspring' : 5,
    'noisy' : true,
    'deadly' : false
};

animal2.genus = 'bear';
animal2;
animal;
// Since we set up this variable completely separately from animal, it will not behave like it did before, reflecting all changes. It's its own animal, now!

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Working_with_Objects
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Global_Objects/Object