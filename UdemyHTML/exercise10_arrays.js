// Write a function printReverse() that takes an array as
// an argument and prints out the elements in the array in
// reverse order.
function printReverse(array) {
	for(var i = array.length - 1; i >= 0; i--) {
		console.log(array[i]);
	}
}


// Write a function isUniform() which takes an array as an 
// argument and returns true if all elements in the array
// are identical.
function isUniform(array) {
	var firstElement = array[0];
	for(var i = 1; i < array.length; i++) {
		if(array[i] !== firstElement) {
			return false;
		}
	}
	return true;
}


// Write a function sumArray() that accepts an array of numbers
// and returns the sum of all the numbers in the array.
function sumArray(array) {
	var sum = 0;
	array.forEach(function(item) {
		sum += item;
	});
	return sum;
}


// Write a function max() that accepts an array of numbers and
// returns the maximum value in the array.
function max(array) {
	var maxValue = array[0];
	for(var i = 1; i < array.length; i++) {
		if(array[i] > maxValue) {
			maxValue = array[i];
		}
	}
	return maxValue;
}