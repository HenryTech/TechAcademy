var obj = {
	name: "Chuck",
	age: 46,
	isCool: true,
	friends: ["Bob", "Tina"],
	add: function(x,y){
		return x + y;
	}
}
console.log(obj.add(4,5)); // 9

// Namespacing using dogs and cats, making a speak() method

var dogSpace = {};
dogSpace.speak = function() {
	console.log("WOOF!");
}
var catSpace = {};
catSpace.speak = function() {
	console.log("MEOW!");
}

dogSpace.speak(); // "WOOF!"
catSpace.speak(); // "MEOW!"

// Keyword "this" refers to the object that the method is defined in
var comments = {};
comments.data = ["Good job!", "Bye", "Lame..."];
comments.print = function(){
	this.data.forEach(function(element){
		console.log(element);
	})
}
comments.print();
