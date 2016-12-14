import sqlite3

# Get person data from user. Note that we have to specify int for age input.
firstName = raw_input("Enter your first name: ")
lastName = raw_input("Enter your last name: ")
age = int(raw_input("Enter your age: "))

'''
 Execute insert statement for supplied person data. Notice how far we have to
 bend over backwards to get that "line" string to work as a command, including
 changing age back into a string temporarily.

 What if a user's name included an apostrophe? It would break the code, because
 the single quotes get all mixed up. The next file (04usingUserInputParam) will
 show how to do this without those risks.
'''
with sqlite3.connect("test_database.db") as connection:
    c=connection.cursor()
    line = "INSERT INTO people VALUES('"+firstName+"','"+lastName+"',"+str(age)+")"
    c.execute(line)
c.close()
connection.close()
