$(document).ready(function() {
// Note that this time, in our html file, we've added a div with a bit of styling (background-color: yellow) to it.

// This first block of code makes it so when you click on the h1 tag, the text changes to "clicked". 
  $("h1").click(function() {
    $(this).text("clicked");
  });
  
/* What if I wanted to change the <p> text when the h1 tag was clicked, instead of the h1 tag text? I could do that simply:

	$("h1").click(function() {
		$("p").text("clicked");
	});
	
What if I wanted to include html coding within the text change? This will actually read the html code and make it happen as coded (but only when the event fires,of course):

	$("h1").click(function() {
		$("p").html("new <b>text</b>");
	});
	
We can even get a little crazy and add styles, or do full-on html coding within the .html(). Note that I had to adjust the quotation marks I was using ('' vs "") to allow for the style specification within the html code.

	$("h1").click(function() {
		$("p").html('new <b style="color: red">text</b>');
	});
  
If I use the <div> instead of <p>, it will replace all content within that div with a single line of text that I specified! Dramatic change to my html on the fly!

	$("h1").click(function() {
		$("div").html("new <b style="color: red">text</b>");
	});
	
I could also just completely nuke everything inside the <div> wrapper when the click event happens (POOF!), like so:

	$("h1").click(function() {
		$("div").empty();
	});
	
Maybe we want to actually append (add) some text on the event. The following will just add "More text" to the <p> content when the h1 tag is clicked.

	$("h1").click(function() {
		$("p").append(" More text");
	});
	
This works with html code, as well. This is interesting. We'll target the div, and add a paragraph to it on the click event. This paragraph is still included inside the div, but it is just after the pre-existing content. NOTE: to have the new text appear at the top, instead of just after, use .prepend instead of .append.

	$("h1").click(function() {
		$("div").append("<p>More text</p>");
	});
	
What if we wanted the new text to appear outside the <div>? The followins makes the new paragraph appear under the div and outside of it. NOTE: if we wanted the text to appear BEFORE the <div> and outside of it, we could use .before instead of .after.

	$("h1").click(function() {
		$("div").after("<p>More text</p>");
	});
	
What if I wanted to actually replace some html code on the click event? The following turns the <p> elements into <h2> elements on a click event.

	$("h1").click(function() {
		$("p").replaceWith("<h2>New text</h2>");
	});
	
How can I change an html attribute, though? For this example, I've changed my target to the 8-ball picture linked in the html file, which has an ID of "picture".  The .attr function takes 2 arguments: the attribute that we want changed, and the replacement for that attribute. In this case, we go from displaying an 8-ball to displaying a floating ball.
	
	$("h1").click(function() {
		$("#picture").attr("src", "floatingball.gif");
	});
*/	
	
	
});