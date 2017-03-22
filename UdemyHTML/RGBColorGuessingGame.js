// var colors = [
// 	"rgb(255, 0, 0)",
// 	"rgb(0, 255, 0)",
// 	"rgb(0, 0, 255)",
// 	"rgb(255, 255, 0)",
// 	"rgb(255, 0, 255)",
// 	"rgb(0, 255, 255)"			
// ];
// var pickedColor = colors[3];

// var squares = document.querySelectorAll(".square");
// document.getElementById("targetColor").textContent = pickedColor.toUpperCase();
// for(var i = 0; i < squares.length; i++) {
// 	// add initial colors to squares
// 	squares[i].style.backgroundColor = colors[i];
// 	// add click listeners to squares
// 	squares[i].addEventListener("click", function(){
// 		// grab color of picked square
// 		var clickedColor = this.style.backgroundColor;
// 		// compare color to pickedColor
// 		if(clickedColor === pickedColor){
// 			alert("Correct");
// 		} else {
// 			alert("Incorrect");
// 		}
// 	})
// }


boardSetUp();

function boardSetUp() {
	var messageDisplay = document.getElementById("message");
	// set up random color array	
	var easyMode = false;
	if(easyMode){
		var length = 3;
	} else {
		var length = 6;
	};	
	var colors = colorSelector(length);
	// randomly select one color from array to be picked color and put the RGB value
	// in the h1
	var pickedColor = colors[getRandom(0, colors.length - 1)];	
	document.getElementById("targetColor").textContent = pickedColor.toUpperCase();
	// select squares and fill them in with randomly selected colors from the color
	// array, then activate event listener and handle click event
	var squares = document.querySelectorAll(".square");
	for(var i = 0; i < squares.length; i++) {
		// add initial colors to squares
		squares[i].style.backgroundColor = colors[i];
		// add click listeners to squares
		squares[i].addEventListener("click", function(){
			// grab color of picked square
			var clickedColor = this.style.backgroundColor;
			// compare color to pickedColor
			if(clickedColor === pickedColor){				
				success(pickedColor, squares, messageDisplay);
			} else {				
				this.classList.add("not-visible");
				messageDisplay.textContent = "Try Again";
			}
		})
	}
}

// generate random number in range given, inclusive of max
function getRandom(min, max) {
	min = Math.ceil(min);
	max = Math.floor(max);
	return Math.floor(Math.random() * max - min + 1) + min;
}

// fill color array with randomly selected colors
function colorSelector(length) {
	var colors = [];
	var r = 0,
		g = 0,
		b = 0;
	for(var i = 0; i < length; i++){
		r = getRandom(0, 255), g = getRandom(0, 255), b = getRandom(0, 255);
		colors[i] = "rgb(" + r + ", " + g + ", " + b + ")";		
	}		
	return colors;
}

// on success, make all squares visible and change all squares to winning color
function success(pickedColor, squares, message) {
	message.textContent = "Correct!";
	document.querySelector("h1").style.backgroundColor = pickedColor;
	for(var i = 0; i < squares.length; i++){
		squares[i].classList.remove("not-visible");
		squares[i].style.backgroundColor = pickedColor;
	}
}