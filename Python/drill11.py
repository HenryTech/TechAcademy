# Here I'm assigning an integer to a variable
myInt = 27

# Here I'm assigning a string to a variable
myString = "Hello, world!"

# Here I'm assigning a float to a variable
myFloat = 3.14

# I'm going to use the format() function to print out my variables now
print("My three variables are myInt={}, myString={} and myFloat={}.".format(myInt,myString,myFloat))

# Now I'm going to use all sorts of operators. GET READY!
# Note that = was used above to set variables,
# and += will be used below in loops.
print "3+5="+str(3+5)
print "3-5="+str(3-5)
print "3*5="+str(3*5)
print "3/5="+str(float(3)/float(5))
print "100/15="+str(100/15)+" with remainder "+str(100%15)

# I will now find ways to use and, or and not.
print "The word 'good' is NOT in my string 'Hello, world!', right?"
print ("good" not in myString)
print "Are 28 and 72 both even numbers?"
print (28 % 2 == 0 and 72 % 2 == 0)
print "Out of the numbers 72 and 113, one of them is even, right?"
print (72 % 2 == 0 or 113 % 2 == 0)

# Now it's time to exercise my use of if, elif and else statements!
if "good" not in myString:
    print "The word 'good' is not in the phrase "+myString+"."
elif "good" in myString:
    print "The word 'good' is in the phrase "+myString+"."
else:
    print "We're done doing if/else/elif comparators now!"

# Let's try using a while loop, shall we? I'm going to use the += operator
# at the same time. HERE WE GO!
i = 1
print "I'm going to count to 5! WATCH MEH!"
while i<6:
    print i
    i += 1

# Now I'm going to use a for loop, because why not?
# Actually, first I'm going to create a list so the for loop
# will have something to chew on.
myList = ["apples", "plums", "peaches", "apricots", "nectarines"]
print "\nThese are different types of stonefruit:"
for listItem in myList:
    print listItem

# Time to do the same with a tuple, now.
myTuple = "marion", "blue", "black", "ras", "goose"
i=0
print "\nThese are different types of berry:"
for i in myTuple:
    print i + "berry"

def myFunction(name):
    name = raw_input("What did you say your name was, again? ").capitalize()
    return name

name = ""
name = myFunction(name)
print "Right! "+name+"! I'll try to remember this time!"




    










