$(document).ready(function() {
	
// This will specify a click event on any of the h1 tags. Everything we want to happen when the click event happens goes between the curly braces. In this case, whichever h1 tag is clicked on (this) will change color to red.

	$("h1").click(function() {
		$(this).css("background-color","red");		
	});
	
/* This will specify a "mouse-down" function, meaning the button is pushed and held down. Once the button is realeased, the event is over. A "mouse-up" event will only fire when the mouse button is released.

	$("h1").mousedown(function() {
		$(this).css("background-color","red");		
	});
	$("h1").mouseup(function() {
		$(this).css("background-color","yellow");		
	});
	
*/

/* "Mouseenter" and "mouseleave" are events that deal with the mouse entering or leaving the specified space. This block of code also includes an unbind command, which makes it so that, once the 2nd event has happened (mouseleave), all events on that particular h1 tag (this) will be removed, and nothing else will happen. If I had used "*" before the unbind, once I've moved my mouse onto and off of whichever first h1 tag I go to first, all of the click events will be removed for all the rest of the h1 tags, and no more color changes will happen.

	$("h1").mouseenter(function() {
		$(this).css("background-color","red");		
	});
	$("h1").mouseleave(function() {
		$(this).css("background-color","yellow");
		$(this).unbind();
	});

*/

/* Let's play around with this some more. Changing the unbind() command can specify exactly which effect I wish to unbind. Now the mouse enter events will be unaffected, but the mouse leave yellow shift will stop happening after the first.

	$("h1").mouseenter(function() {
		$(this).css("background-color","red");		
	});
	$("h1").mouseleave(function() {
		$(this).css("background-color","yellow");
		$(this).unbind("mouseleave");
	});
 
 */




});