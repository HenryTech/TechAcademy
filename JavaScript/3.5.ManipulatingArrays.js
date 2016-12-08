var counties = [
    'Belknap', // Position 0
    'Strafford', // Position 1
    'Carroll', // Position 2
    'Rockingham' // Position 3
];

counties[0];
counties[2];
// Displays the county in that position of the array

counties[2] = 'Cheshire';
counties;
// Just changed the value of the county in position 2.

counties[4] = 'Carroll';
counties;
// Since we already knew the length of counties, we just tacked a new one onto the end. This is usually pretty useless in a real-world coding environment, because how can you be sure exactly how long the array is at any given moment?

counties[counties.length] = 'Merrimack';
counties;
// Without knowing the length of counties, we still just tacked one onto the end. Much more useful in a coding environment.

counties.push('Coos');
counties;
// Another way to tack another value onto the end of the array. Push goes with pop, as they both work on the tail end of an array. Also takes less typing.

counties.pop();
// This just returned the tail end of the array, as well as completely removing that position in the array.
//Note that shift and unshift work the same way as push and pop, but they affect the front end of the array instead.

delete counties[2];
counties;
// Takes the value out of position 2 in the array, but leaves an undefined there--it does not get rid of the position itself, only the value. The length of the array stays the same.

counties.splice(2, 1);
counties;
counties.length;
// Splice uses 2 arguments: the first one tells it what position to get rid of, the 2nd tells it how many positions to eliminate. So this command goes to position 2 and removes only that 1 position--which we left undefined. Now the length of the array is changed, because the position itself is removed, not just the data in it.

// More info:
// https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Global_Objects/Array