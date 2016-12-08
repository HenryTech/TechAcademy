$(document).ready(function() {

/* h1 heading click event. On a click on the h1 element, the h2 element will be hidden (which changes the height, width and opacity all at once). The number specifies the speed in ms. */
  
  $("h1").click(function() {
    $("h2").hide(1000);
  });
  
/* If I only wanted the h2 tag to disappear by losing all height (and not width or opacity), I could use the slideUp, like so:

	$("h1").click(function() {
		$("h2").slideUp(1000);
	});
	
Or I could do a fadeOut, which would make h2 disappear by using opacity only:

	$("h1").click(function() {
		$("h2").fadeOut(1000);
	});
	
FadeTo will fade to the opacity we specify. The command takes a 2nd argument, which specifies opacity 0-1.

	$("h1").click(function() {
		$("h2").fadeTo(1000,0.3);
	});
	
Let's get a little more complex. Let's add a second affect to fire right after the hide is finished. We do that by nesting another function, right after the hide. Remember, anything in the curly braces is what will happen, but in this case it will happen right after the hide is finished.

	$("h1").click(function() {
		$("h2").hide(1000, function() {
			$("h3").fadeOut(1000);
		});
	});
*/
  
/* I could make it, instead, a hidden h2 and a click event would show it. To do that, I'd have to place this line directly beneath the first line (the $(document).ready line):

$("h2").hide();

Then I would have to change my code block slightly to make a "show" happen, again in 1000ms, so it looked like this:

	$("h1").click(function() {
		$("h2").show(1000);
	});


I can make the heading disappear and reappear by using a toggle heading. That would change the state of h2 every time I click. It looks like this:

	$("h1").click(function() {
		$("h2").toggle(1000);
	});


I could use a method that makes the h2 heading re-appear by changing its height, like so:

	$("h1").click(function() {
		$("h2").slideDown(1000);
	});
	
And I could even combine this with toggle by doing it this way:

	$("h1").click(function() {
		$("h2").slideToggle(1000);
	});
	
Reverse of fadeOut is fadeIn, which makes it reappear by using opacity.

	$("h1").click(function() {
		$("h2").fadeIn(1000);
	});
	
We can also use the fade effect to toggle that h2 tag in and out every time a click event happens:

	$("h1").click(function() {
		$("h2").fadeToggle(1000);
	});

I can delay the fadeToggle (in ms) by adding a delay like this:

	$("h1").click(function() {
		$("h2").delay(2000).fadeToggle(1000);
	});
	
*/
  
});