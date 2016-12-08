// This will make sure that jQuery loads properly first.
$(function() {
/* This next bit is specifically used in 9.1.JS-Carousel.html.

By default, the carousel cycles every 5 seconds and pauses when the mouse is hovered. Also, when it reaches the end it cycles back to the beginning and can be navigated with the keyboard. We can change any of these defaults, however, by passing objects to the carousel function.

Below, we've set the interval to 2000ms (default is 5000ms), disabled the default pause function, disabled the wrap that occurs when the user reaches the end and disabled keyboard navigation. */
// Specifying the .carousel class and calling the carousel function	
	$(".carousel").carousel({
		interval: 2000,
		pause: false,
		wrap: false,
		keyboard: false
	});	

/* The following is for 9.5.JS-Tooltips.html. We could deal with each tooltip individually, or activate them all at once (which is quicker). All we're doing here is asking jQuery to look for any elements that have a data-toggle attribute of tooltip. */
	$('[data-tottle="tooltip"]').tooltip();
	
/* The following is for 9.6.JS-Popovers.html. I'm going to turn on the popover I just created inside a button. */
	$("[data-toggle='popover']").popover();
});