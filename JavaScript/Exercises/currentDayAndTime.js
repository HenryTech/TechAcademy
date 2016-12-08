// Set up today variable, which is the entire date
var today = new Date();
// Set up day variable, which is just the day number, then convert to actual weekday name.
var day = today.getDay();
var daysWeek = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
day = daysWeek[day];
// Set up hours, minutes and seconds
var hour = today.getHours();
var minutes = today.getMinutes();
var seconds = today.getSeconds();
// Figure out am or pm
if (hour < 12) {
	var ampm = "AM";
} else {
	var ampm = "PM";
};
// Adjust for 0 = midnight
if (hour === 0) {
	hour = 12;
};
// Adjust military time to 12-hour clock
if (hour > 12) {
	hour = hour - 12;
};
// Add a 0 to low minutes counts
if (minutes < 10) {
	minutes = "0" + minutes;
};
// Add a 0 to low seconds counts
if (seconds < 10) {
	seconds = "0" + minutes;
};
console.log("Today is : " + day);
console.log("Current time is : " + hour + ampm + " : " + minutes + " : " + seconds);



	
	
	
	
	
	
	
