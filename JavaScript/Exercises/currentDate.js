var today = new Date();
var day = today.getDate();
var month = today.getMonth();
var year = today.getYear();
year = year + 1900

month = month + 1;
if (month < 10) {
	month = "0" + month;
};

if (day < 10) {
	day = "0" + day;
};
today = month + "-" + day + "-" + year;
console.log(today);
today = month + "/" + day + "/" + year;
console.log(today);
today = day + "-" + month + "-" + year;
console.log(today);
today = day + "/" + month + "/" + year;
console.log(today);


