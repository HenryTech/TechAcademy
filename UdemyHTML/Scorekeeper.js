var p1Button = document.querySelector("#p1");
var p2Button = document.getElementById("p2");
var resetButton = document.getElementById("reset");
var p1Display = document.querySelector("#p1Display");
var p2Display = document.getElementById("p2Display");
var maxDisplay = document.getElementById("maxScore");
var numInput = document.querySelector("input");
var maxScore = 5;
var p1Score = 0;
var p2Score = 0;
var gameOver = false;

p1Button.addEventListener("click", function(){
	if(!gameOver){
		p1Score++;
		p1Display.textContent = p1Score;		
		checkGameOver("Player One");
	};			
})

p2Button.addEventListener("click", function(){
	if(!gameOver){
		p2Score++;
		p2Display.textContent = p2Score;		
		checkGameOver("Player Two");
	};			
})

resetButton.addEventListener("click", function(){
	reset();
})

numInput.addEventListener("change", function(){
	maxScore = parseInt(this.value);
	maxDisplay.textContent = this.value
	reset();
})

function reset() {
	p1Score = 0;
	p2Score = 0;
	p1Display.textContent = p1Score;
	p2Display.textContent = p2Score;	
	gameOver = false;
	p1Display.style.color = "black";
	p2Display.style.color = "black";
}

function checkGameOver(player) {
	if(p1Score === maxScore || p2Score === maxScore) {
		gameOver = true;
		alert("Game Over! " + player + " wins!");
		if(p1Score === maxScore){
			p1Display.style.color = "green";
		} else {
			p2Display.style.color = "green";
		}
	}
}