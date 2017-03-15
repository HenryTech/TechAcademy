// function isEven(num) {
// 	if(typeof num !== "number") {
// 		return "That's not a number!";
// 	}
// 	if(num % 2 === 0) {
// 		return true;
// 	}
// 	return false;
// }

function isEven(num) {
	if(typeof num !== "number") {
 		return "That's not a number!";
 	}
	return num % 2 === 0;
}

function factorial(num) {
	if(typeof num !== "number") {
		return "That's not a number!";
	}
	if(num === 0) {
		return 1;
	} else {
		return num * factorial(num-1);
	}
}

function kebabToSnake(str) {
	if(typeof str !== "string") {
		return "That's not a string!";
	}
	var snake = str.replace(/-/g, "_");
	return snake;
}