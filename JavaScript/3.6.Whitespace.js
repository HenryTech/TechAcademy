var year=2012,month='October',day=31,holiday='Halloween';
// Bad, hard to read. Works, though!

var year   = 2012,       month    =    'October', day =          31,          holiday='Halloween';
// Works just as well, but also not that easy to read.

var year = 2012,
    month = 'October',
    day = 31,
    holiday = 'Halloween';
// Works equally well as the previous two examples, but this one is WAY easier to read. Goooo whitespace!

var year    = 2012,
    month   = 'October',
    day     = 31,
    holiday = 'Halloween';
// Look at THAT! The extra tabs make it look all nice and pretty and, to the human eye, this is the easiest to read. Works just the same as all the other examples.

var tinyAlmanac={'year':2012,'month':'October','day':31,'holiday':'Halloween'};
// Works, but icky to try and read.

var tinyAlmanac = {
    'year' : 2012,
    'month' : 'October',
    'day' : 31,
    'holiday' : 'Halloween'
};
// Works exactly the same, but way easier to read.

// More info:
// These are not specifications on whitespace, but the Mozilla recommended coding style concerning whitespace.
// https://developer.mozilla.org/en-US/docs/Developer_Guide/Coding_Style#Whitespace