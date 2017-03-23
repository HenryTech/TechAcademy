var h1 = document.querySelector("h1");
var reset = document.getElementById("reset");
var message = document.getElementById("message");
var easy = document.getElementById("easy");
var hard = document.getElementById("hard");
var squares = document.querySelectorAll(".square");
var selected = document.querySelector(".selected");
var easyMode = false;

boardSetUp(easyMode);

// event listeners for clicks on reset, easy and hard buttons. Easy
// and hard buttons change the state of easyMode and also change highlighting
// depending on which one is currently active.
reset.addEventListener("click", function(){
	boardSetUp(easyMode);
});

easy.addEventListener("click", function(){
		this.classList.add("selected");
		hard.classList.remove("selected");
		easyMode = true;		
		boardSetUp(easyMode);
});

hard.addEventListener("click", function(){
		this.classList.add("selected");
		easy.classList.remove("selected");
		easyMode = false;
		boardSetUp(easyMode);
});	

// This is the main game engine which ensures that all squares in play are full
// of randomly selected colors, picks the winning color and then listens for the user
// to click on a color, making it disappear if it's wrong, or running the success()
// function if they pick correctly.
function boardSetUp(easyMode) {	
	h1.style.backgroundColor = "steelblue";	
	reset.textContent = "NEW COLORS";
	message.textContent = "";
	// set up random color array with varying length depending on difficulty setting	
	if(easyMode){
		var length = 3;		
	} else {
		var length = 6;		
	};	
	var colors = colorSelector(length);
	// randomly select one color from array to be picked color and put the RGB value
	// in the h1
	var pickedColor = colors[getRandom(0, colors.length - 1)];	
	document.getElementById("targetColor").textContent = pickedColor;
	// fill squares in with randomly selected colors from the color
	// array, then activate event listener and handle click event	
	for(var i = 0; i < colors.length; i++) {
		// add initial colors to squares
		squares[i].style.backgroundColor = colors[i];
		// add click listeners to squares
		squares[i].addEventListener("click", function(){
			// grab color of picked square
			var clickedColor = this.style.backgroundColor;
			// compare color to pickedColor
			if(clickedColor === pickedColor){				
				success(pickedColor, length);
			} else {				
				this.classList.add("not-visible");
				message.textContent = "Try Again";
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

// fill color array with randomly selected colors taking length as an argument
// length is set in boardSetUp based on difficulty setting
function colorSelector(length) {
	var colors = [];
	var r = 0,
		g = 0,
		b = 0;
	if(length === 3) {
		for(var i = 3; i < 6; i++) {
			squares[i].classList.add("not-visible");
		}
	} else {
		for(var i = 3; i < 6; i++) {
			squares[i].classList.remove("not-visible");
		}
	}
	for(var i = 0; i < length; i++){
		r = getRandom(0, 255), g = getRandom(0, 255), b = getRandom(0, 255);
		colors[i] = "rgb(" + r + ", " + g + ", " + b + ")";		
	}		

	return colors;
}

// on success, make all squares visible and change all squares to winning color
function success(pickedColor, length) {
	message.textContent = "Correct!";
	h1.style.backgroundColor = pickedColor;	
	for(var i = 0; i < length; i++){
		squares[i].classList.remove("not-visible");
		squares[i].style.backgroundColor = pickedColor;
	}
	reset.textContent = "Play Again?";	
}