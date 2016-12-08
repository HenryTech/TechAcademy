$(document).ready(function() {

// This starts out pretty standard, but note that not only is the h1 tag changing color on the click event: We've added all of the p tags to this event as well.
  $("h1").click(function() {
    $(this).add("p").css("background-color", "red");
  });

/* But what if we wanted to remove or reduce our selection? Notice that one of the <p> has a class attribute of "second". By this method, we're removing that 2nd <p> from our selection. It will not turn red like all the rest.

	$("h1").click(function() {
		$("p").not("p.second").css("background-color", "red");
	});
	
The next method will select sibling elements that come after (in this case) the <div> elements. This block of code will make the <h1> that follows the <div> (the next sibling element) change color.
	
	$("h1").click(function() {
		$("div").next().css("background-color", "red");
	});

This version selects sibling elements that come after the <h1> tag that's clicked. This code will make BOTH the <p> directly beneath the top <h1> AND the final <div> that's after the 2nd <h1> turn red. The next method looks for next siblings of all <h1> tags, in this case.

	$("h1").click(function() {
		$("h1").next().css("background-color", "red");
	});
	
If we want to select the next sibling ONLY IF that sibling is a div tag, we simply add the div selector just after the next method. In this case, only the final <div> would change, because it's the only one that comes after and at the same level as an <h1> (making it a sibling).

	$("h1").click(function() {
		$("h1").next("div").css("background-color", "red");
	});
	
We can use "this" as our selector when using the next method, also. It will simply select the next sibling element after whichever <h1> is clicked on.

	$("h1").click(function() {
		$(this).next().css("background-color", "red");
	});
	
We could also specify the sibling element that comes before the element in question. Note that all siblings of <p> will change, so now if we click on that first <h1>, all but the last <p> ("Third line of text") changes color, because all <p>s except for that one are previous siblings.

	$("h1").click(function() {
		$("p").prev().css("background-color", "red");
	});

So far, we've been selecting sibling elements. Is there a way to select a parent element? Would I ask this question if there weren't?

	$("h1").click(function() {
		$(this).parent().css("background-color", "red");
	});

The find method allows us to get the descendants of the current selection. Let's find all the <p> that are descendants of <div>.

	$("h1").click(function() {
		$("div").find("p").css("background-color", "red");
	});
	
The first method selects the first of something. So $("p") selects all of the <p> elements, but putting .first after it specifies ONLY the FIRST <p> element. Similarly, placing .last after it would have chosen the LAST <p> element.

	$("h1").click(function() {
		$("p").first().css("background-color", "red");
	});

If I wanted to select only a specific element, I can use an index number. Eq is the method used for that. I have to include a number as an argument, but note that the number is not in quotes and, of course, the count starts at 0.

	$("h1").click(function() {
		$("p").eq(1).css("background-color", "red");
	});
  
});