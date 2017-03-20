var movies = [
	{
		title: "Brazil",
		hasWatched: true,
		rating: 4.5
	},
	{
		title: "Frozen",
		hasWatched: false,
		rating: 4.5
	},
	{
		title: "Mad Max Fury Road",
		hasWatched: true,
		rating: 4
	},
	{
		title: "Shaun Of The Dead",
		hasWatched: true,
		rating: 5
	}
];

// for(var i = 0; i < movies.length; i++){
// 	if(movies[i].hasWatched === true){
// 		console.log("You have watched " + movies[i].title + " - " + movies[i].rating + " stars");
// 	} else {
// 		console.log("You have not seen " + movies[i].title + " - " + movies[i].rating + " stars");
// 	}
// }
movies.forEach(function(movie){
	console.log(buildString(movie));
});

function buildString(movie) {
	var result = "You have ";
	if(movie.hasWatched === true){
		result += "seen ";
	} else {
		result += "not seen ";
	}
	result += "\"" + movie.title + "\" - " + movie.rating + " stars";
	return result;
}