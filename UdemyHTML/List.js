var todos = [];
var input = prompt("What would you like to do?");



while(input !== "quit") {
	if(input === "list") {
		listTodos();
	} else if(input === "new") {
		addTodo();
	} else if(input === "delete"){
		deleteTodo();
	}
	input = prompt("What would you like to do?");
}
console.log("OK, we're done!");

function listTodos(){
	console.log("***********");
	todos.forEach(function(todo, i){
		console.log(i + ": " + todo);
	});
	console.log("***********");
}

function addTodo(){
	var newTodo = prompt("Enter new to-do item");
	todos.push(newTodo);
	console.log("Added Todo");
}

function deleteTodo(){
	var delIndex = prompt("Enter the index of the item you would like to delete?");
	todos.splice(delIndex, 1);
	console.log("Deleted Todo");
}