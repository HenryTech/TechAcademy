$(document).ready(function() {
// this makes sure nothing will run until the page is finished loading
	$("p").hide();
// hides all paragraph tabs
	$("h1").click(function() {
// this ensures that the next only happens when someone clicks an h1 tag
		$(this).next().slideToggle(300);
// this toggles the visibility of the tag following the h1 tag
	});

});