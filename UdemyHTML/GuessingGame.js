//create secretNumber
var secretNumber = 4;

//ask user for guess
var guess = prompt("Guess a number");


//check if guess is correct
if(Number(guess) === secretNumber) {
	alert("You got it right!");
} else {
	alert("WRONG!");
}