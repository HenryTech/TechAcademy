var myArray = [];
myArray;

var daysOfTheWeek = ['Sunday', 'Monday', 'Tuesday', 'Wednesday'];
daysOfTheWeek;
// Length is 4.

var myArray = [
0, 1, 2,
'string1', 'string2', 'string3',
true, false
];
myArray;
// Length is 8 because there are 8 items in the root array.

var counties = [
    'Belknap',
    'Strafford',
    'Carroll',
    'Rockingham'
];
counties;

var arrayOfStuff = [
    {'name' : 'value'},
    [1, 2, 3],
    true,
    'nifty'
];
arrayOfStuff;
arrayOfStuff.length;
//Length is 4 because there are 4 items in the root array. You could nest until the cows come home, but array.length will only count the number of commas at the root, then add 1.

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Guide/Values%2C_variables%2C_and_literals#Array_literals
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Global_Objects/Array