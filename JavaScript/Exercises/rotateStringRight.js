var string = "w3resource";
var stringArray = new Array(10);
var rotString = ""
var arrayElement = ""
// Set up the array out of the string
for (i=0;i<10;i++) {
	stringArray[i]=(string.substring(i,i+1));
};
// Set up the rotate function
function rotate() {
	arrayElement = stringArray.pop();
	stringArray.unshift(arrayElement);
};

for (x=0;x<10;x++) {
	// Invoke the rotate function
	rotate();
	// Reassemble the modified string
	for (i=0;i<10;i++) {
		rotString = rotString + stringArray[i];
	};
	// Print the result to console
	console.log(rotString);
	// Set rotString back to 0
	rotString = "";
};




