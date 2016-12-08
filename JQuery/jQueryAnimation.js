$(document).ready(function() {

/* Check this out--we have the h2 growing in size over 1000ms, animated! The first argument in the animate command controls the style of the animation, the 2nd (outside the curly braces) controls the duration. */
  $("h1").click(function() {
    $("h2").animate({
      "font-size": "3em"
    }, 1000);
  });
  
/* We can make multiple animations happen at the same time. We just need to add them to the space within the animate curly braces. DON'T FORGET THE COMMA! In this case, the font size still changes but also the width chages to half normal.

	$("h1").click(function() {
    $("h2").animate({
      "font-size": "3em",
	  "width": "50%"
    }, 1000);
  });
  
Let's add a left property to the animation as well. After this code, the font size will get larger, the width will get smaller, and the entire line will move 100px to the left. In order for "left" to work (this is straight out of CSS), the h2 has to be already set to either relative, fixed or absolute. Notice in the corresponding html file, the h2 element is set to position: relative.

	$("h1").click(function() {
    $("h2").animate({
      "font-size": "3em",
	  "width": "50%",
	  "left": "100px"
    }, 1000);
  });
  
I can make multiple clicks move the h2 to the left each time (by 100px increments), by adding just a tiny bit of code to that left animation element:

	$("h1").click(function() {
		$("h2").animate({
		  "font-size": "3em",
		  "width": "50%",
		  "left": "+=100px"
		}, 1000);
	});
	
I could use CSS properties with font-size, instead of specifying an actual size. I can make the h2 element disappear with that first click, like so:

	$("h1").click(function() {
		$("h2").animate({
		  "font-size": "hide",
		  "width": "50%",
		  "left": "100px"
		}, 1000);
	 });
	 
But it's more interesting to make it toggle between hidden and shown:

	$("h1").click(function() {
		$("h2").animate({
		  "font-size": "toggle",
		  "width": "50%",
		  "left": "100px"
		}, 1000);
	 });
	 
What if I wanted another animation to happen, but not until this one is complete? How about a h3 fadeOut that takes 1000ms? We do this by using a callback function, like so:

	$("h1").click(function() {
		$("h2").animate({
		  "font-size": "hide",
		  "width": "50%",
		  "left": "100px"
		}, 1000, function() {
			$("h3").fadeOut(1000);
		});
	 });
  
  
});