#Python3 differences! Print statement requires parentheses.
print("Let's see how long you have lived in days, minutes and seconds.")

#raw_input gets replaced by simply input.
name = input("Name: ")

#I want to convert the input to an integer here, so I used int().
age = int(input("Age: "))

#Now to set some variables
days = age * 365
minutes = age * 525948
seconds = age * 31556926

#Concatenation of a string now uses commas instead of pluses. It even includes
#spaces!
print(name,"has been alive for",days,"days, or",minutes,"minutes, or",seconds,"seconds!")
