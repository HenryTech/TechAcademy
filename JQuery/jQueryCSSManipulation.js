$(document).ready(function() {
// Note that, in jQueryCSSManipulation.html, 2 styles are specified: shrink and emphasis.

/* This initial code makes it so that, on a mouseenter event on any h1, a css style is activated (that particular h1 element has 50px added to left margin). In this particular case, the margin is incremented, so that every time the mouseenter event happens, 50px is added to the left margin. */

  $("h1").mouseenter(function() {
    $(this).css("margin-left", "+=50px");
  });
  
/* It's easy to add multiple css properties, but we have to change the syntax of the original arguments slightly. This will increment the left margin by 50px but will also change the background color to red.

	$("h1").mouseenter(function() {
		$(this).css({
			"margin-left": "+=50px",
			"background-color": "red"
		});
	});
*/

/* Let's add a class to the h1 element on mouseenter event. We can use the classes we've already set up in our html file (referenced above). Emphasis makes the text turn red and get underlined (defined in the html). Shrink makes the text smaller. I can do this with as few or as many classes as I care to, simply by adding them to the same line.

	$("h1").mouseenter(function() {
		$(this).addClass("emphasis shrink");
	});
*/

/* I've added .shrink and .emphasis to the first h1 in my html file so that we can see how to remove those css classes on a specified event. With this code, when the mouse is moved over any h1 element, all classes affecting it will be removed.

	$("h1").mouseenter(function() {
		$(this).removeClass();
	});

I could just remove one class by specifying it, or I could remove multiple classes by specifying them exactly in the same way that multiple classes can be added:

	$("h1").mouseenter(function() {
		$(this).removeClass("emphasis");
	});
	
We can combine both add and remove class methods together. The following will remove the .emphasis and add the .shrink any time the mouse is moved over a h1 tag.

	$("h1").mouseenter(function() {
		$(this).removeClass("emphasis").addClass("shrink");
	});

ToggleClass allows us to add and remove a class every time the event happens, toggling back and forth. Of course it can work with a single or multiple classes, as needed, in the same fashion as seen above with addClass (just throw in a space and the name of any other classes you want, separated by spaces within the original quotation marks.) If I used just toggleClass(), any class specified for the element in question will simply be toggled on and off.

	$("h1").mouseenter(function() {
		$(this).toggleClass("emphasis");
	});
*/
  
});