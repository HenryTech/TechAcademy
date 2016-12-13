# Python:   2.7.11
#
# Author:   Daniel A. Christie
#
# Purpose:  The Tech Academy - Python Course, Step 35 of 68
#           Demonstrating how to pass variables from function to function
#           while producing a working game.
#
#           Remember, function_name(variable) means that we pass in the variable.
#           return variable means that we are returning that variable
#           to the calling function.

def start(nice=0, mean=0, name=""): # these variable assignments only fire off if the variables have yet to be assigned
        # get user's name
        name = describe_game(name)
        nice, mean, name = nice_mean(nice,mean,name)

def describe_game(name):
    """
    Check if this is a new game or not.
    If it is new, get the user's name.
    If it is not new, thank the player for
    playing again and continue with the game.
    """
    if name != "": # Meaning if we already have this user's name
        print("\nThank you for playing again, {}!".format(name))
    else:
        stop = True
        while stop:
            if name == "":
                name = raw_input("\nPleae enter your name: ").capitalize()
                if name != "":
                    print("\nWelcome, {}!".format(name))
                    print("\nIn this game, you will be greeted by several different people. \nYou can be nice or mean.")
                    print("At the end of the game your fate will be determined by your actions.")
                    stop = False
    return name


def nice_mean(nice, mean, name):
    stop = True
    while stop:
        show_score(nice, mean, name)
        pick = raw_input("\nA stranger approaches you for a conversation.\nWill you be nice or mean (n or m)? ").lower()
        if pick == "n":
            print("They smile, wave and walk away.")
            nice = (nice + 1)
            stop = False
        if pick == "m":
            print("\nThe stranger glares at you menacingly and abruptly storms off!")
            mean = (mean + 1)
            stop = False
    score(nice,mean,name) # pass the 3 variables to the score()


def show_score(nice,mean,name):
    print("\n{}, you currently have been nice to {} strangers and mean to {} strangers.".format(name,nice,mean))
        
def score(nice,mean,name):
    # score function is being passed the values stored w/in the 3 variables
    if nice > 5:    # if condition valid, call win function passing in variables
        win(nice,mean,name)
    if mean > 5:    # if condition valid, call lose function passing in variables
        lose(nice,mean,name)
    else:           # else, call nice_mean function and pass in variables
        nice_mean(nice,mean,name)


def win(nice,mean,name):
    print("\nNice job {}, you win! \nEveryone loves you and you now live in a palace!".format(name))
    again(nice,mean,name) # call again function and pass in variables



def lose(nice,mean,name):
    print("\nToo bad, game over! \n{}, you live in a van down by the river, wretched and alone!".format(name))
    again(nice,mean,name)

def again(nice,mean,name):
    stop = True
    while stop:
        choice = raw_input("\nDo you want to play again (y/n)? ").lower()
        if choice == "y":
            stop = False
            reset(nice,mean,name)
        if choice == "n":
            print("\nSee you later, alligator!")
            stop = False
            exit() # Python built-in function
        else:
            print("\nPlease enter 'y' for YES, 'n' for NO... ")

def reset(nice,mean,name):
    nice = 0
    mean = 0
    # Notice the name variable is not reset, as this is the "play again" option!
    start(nice,mean,name)





















if __name__=="__main__":
    start()
