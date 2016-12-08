$(document).ready(function() {
	
// $() specifies a selector. For an ID, we also need #. This refers to a click event specifically for the #testbutton.
	$("#testbutton").click(function() {
	  
/* What if I wanted to ensure that the color changed to red if the user clicked on any of the strong tags as well? Easy enough to do:

	$("#testbutton, strong").click(function() {
		
If I were using this line and I only wanted the element that the user clicked on (out of #testbutton and <strong>) to turn red, I could use the "this" keyword. Since it's a keyword, it doesn't need to be enclosed in quotation marks. The 2nd line would then become:

	$(this).css("background-color","red");	
*/	
	  
// This specifies all div elements. Changes the css background color to red for all the div elements. Because this is enclosed in a click event, it only happens when the user clicks on the testbutton.

    $("div").css("background-color","red");	

/* If I wanted all the paragraph tags to change color to red when I clicked on the #testbutton, I would use this line instead:

	$("p").css("background-color","red"); 
*/

/* I could also play around by making the div, the strong elements and the #testbutton turn red on a click event by doing this instead (note the values separated by commas):

	$("div, strong, #testbutton").css("background-color","red"); 
*/
	
/* I could specify all elements by using a wildcard instead, like this:

	$("*").css("background-color","red"); 
*/

/* There is a way to select child elements, as well. Maybe I only want the <p> to change color, but only the ones wrapped in a <div> (which is the first 2 paragraphs in selectors.html). I would use this method to do that:

	$("div > p").css("background-color","red"); 
*/

/* If I only wanted the first paragraph wrapped in the div to change color, I could specify that like so:

	$("div > p:first-child").css("background-color","red"); 
*/

/* What if I wanted to only change the 2nd <p> in the <div>? I could do that like so:

	$("div > p:last-child").css("background-color","red"); 
*/
	
/* The 2 <strong> within the <div> are called descendants of the <div> I can make only those turn red on a click event by using this syntax:

	$("div strong").css("background-color","red"); 
*/

/* I could select all of the even or odd <p> elements by using this syntax (I'm selecting even here, obviously): 

	$("p:even").css("background-color","red"); 
	
NOTE: the first of any element is numbered 0, so selecting "even" will make the first and third paragraphs (<p>:0 and <p>:2) turn red on a click event. If I replaced "even" with "odd", lines 2 and 4 would turn red.
*/

/* I can get really specific by setting up an ID for one of the <p> tags (which I've already done), and just get that paragraph to turn red by calling it out by its ID:

	$("#third").css("background-color","red"); 
*/

/* I have 2 elements with the multiple class in my selectors.html. I can make only those elements turn red on a click event by doing this:

	$(".multiple").css("background-color","red"); 
*/

/* How about if I only wanted to target the <strong> that has .multiple? I could do that by using this line:

	$("strong.multiple").css("background-color","red"); 

Note that if there were any other strong tags that also shared the .multiple, they would also get targeted.
*/

/* There are lots more selectors, and they can be found at http://www.w3schools.com/jquery/jquery_ref_selectors.asp */



  });
  
});