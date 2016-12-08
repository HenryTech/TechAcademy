$(document).ready(function() {
// Here's us initializing and using a variable to replace some text. A few other variables have been initialzed for use later in the exercise (see below). Var2 makes more sense given the hText value down in the commented section.

	var hText = "This is just some text.";
	var text1 = "The heading text is ";
	var text2 = text1 + hText
	
	$("h1").click(function() {
		$("p").text(hText);
	});
	
/* Note in our html file, we have a couple of IDs specified, one of which is the first heading, #head1. In the first line below, we're setting hText to be the contents of #head1. By following it with .text and empty (), we're specifying that it should read the contents of that element, and make the variable equal to those. Remember our other variables, initialized above? Let's use those...

	var hText = $("#head1").text();
	
	$("h1").click(function() {
		$("p").text(text2);
	});
	
The easier way to do this would have been (note that this makes text1 and text2 obsolete):

	var hText = "The heading text is " + $("#head1").text();
	
	$("h1").click(function() {
		$("p").text(hText);
	});
	
Let's start over and create a different variable to work with, now. Now lineNum determines which <p> turns red.

	var lineNum = 0;
	
	$("h1").click(function() {
		$("p").eq(lineNum).css("background-color", "red");
	});
	
Let's get some incrementing going on--I want the <p>s to switch color from yellow to red, then back to yellow once they've been passed. The if statement included loops it back around so it starts back at the beginning.

	$("h1").click(function() {
		$("p").css("background-color", "yellow");
		$("p").eq(lineNum).css("background-color", "red");
		lineNum++;
		if (lineNum > 2) {lineNum = 0};
	});
	
Let's start from scratch again. New variable! We'll use this for the next several examples.

	var imageName = ["floatingball.gif", "redball.gif", "eightball.gif"]
	var indexNum = 0
	
With this variable and a loop (formed using a click event), we can cycle pictures on the html. In this block of code, we've changed where the click event occurs (#picture) and we've changed the attribute based on the position in the array, determined by indexNum.

	$("#picture").click(function() {
		$(#picture).attr("src", imageName[indexNum]);
		indexNum++;
		if (indexNum > 2) {indexNum = 0;}		
	});
	
This is cool, but it's not very pretty. Let's get a nice fade-in effect for those images as they change. This is a bit more complex, but here's what is happening: first, the current image is faded out over 300ms. Then, the img attribute is changed based on what indexNum currently is, then indexNum is incremented, then indexNum is checked for being out of range, then the new picture, with the new img attribute, is faded in over the course of 500ms.

	$("#picture").click(function() {
		$("#picture").fadeOut(300, function() {
			$(#picture).attr("src", imageName[indexNum]);
			indexNum++;
			if (indexNum > 2) {indexNum = 0;}
			$("#picture").fadeIn(500);
		});			
	});
	
	
	
	
	
});