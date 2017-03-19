function myForEach(arr, func) {
	for(var i = 0; i < arr.length; i++) {
		func(arr[i]);
	}
}

var colors = ["red", "orange", "yellow"];

myForEach(colors, function(color){
	console.log(color);
})

// Let's make an object out of it instead

Array.prototype.myForEach = function(func) {
	for(var i = 0; i < this.length; i++) {
		func(this[i]);
	}
}

colors.myForEach(function(color) {
	console.log(color);
})