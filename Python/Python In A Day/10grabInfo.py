# Setting up the dictionary
epicProgDict = {
    "tim berners-lee" : ["tbl@gmail.com", 111],
    "guido van rossum" : ["gvr@gmail.com", 222],
    "linus torvalds" : ["lt@gmail.com", 333],
    "larry page" : ["lp@gmail.com", 444],
    "sergey brin" : ["sb@gmail.com", 555]}

def searchProg(progName):

    # Compare input to the dictionary and output that programmer's email.
	# First, try the following lines, and if there are no errors...
    try:    
        progInfo = epicProgDict[progName]
        print "Name: "+progName.title()
        print "Email: "+progInfo[0]
        print "Number: "+str(progInfo[1])
	# If there ARE errors, though, we run THIS line of code:
    except:        
        print "No information found for that name."

""" Let's set up a loop so the user can activate the above function
    as many times as they please! """
userWantsMore = True
while userWantsMore == True:
    # Asks for input
    progName = raw_input("Please enter a programmer's name: ").lower()
    # Run the function using user input
    searchProg(progName)
    # Poll the user to see if they want to do another search
    searchAgain = raw_input("Would you like to search for another (y/n)? ")
    if searchAgain == "y":
        userWantsMore = True
    elif searchAgain == "n":
        userWantsMore = False
    else:
        print "I have no idea what you mean. Quitting."
        userWantsMore = False
    


    
