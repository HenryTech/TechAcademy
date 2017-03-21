var but = document.querySelector("button");
but.addEventListener("click", colorToggle);
function colorToggle() {	
	document.body.classList.toggle("purple");
}

// I kept having the problem that "but" was null. This is because the script
// was running before the page finished loading. I solved this problem by
// placing the script reference at the bottom of my html body instead of
// inside the head.

// Another solution which does not need a "purple" class.
// var isPurple = false;
// function colorToggle() {
// 	if(isPurple){
// 		document.body.style.background = "white";
// 	} else {
// 		document.body.style.background = "purple";		
// 	}
// 	isPurple = !isPurple;
// }