import sqlite3


peopleValues = (
    ("Ron", "Obvious", 42),
    ("Luigi","Vercotti",43),
    ("Arthur","Belling",28))

# I'm using the same method as last time but this time I have more than one
# value to enter, so I'm using the executemany method instead. Also I'm going
# to clear the table first, to make this simpler.
with sqlite3.connect("test_database.db") as conn:
    c=conn.cursor()
    c.execute("DROP TABLE IF EXISTS People")
    c.execute("CREATE TABLE People(FirstName TEXT, LastName TEXT, Age INT)")
    c.executemany("INSERT INTO People VALUES(?,?,?)",peopleValues)
# Now I'm going to select all first & last names from people over age 30
    c.execute("SELECT FirstName, LastName FROM People WHERE Age > 30")
# A for loop makes an easy way to print out our results, but it could be done
# with a while loop too, in case we wanted to loop over our result rows one at
# a time instead of fetching them all at once. The "None" keyword is what Python
# uses instead of "NULL".
##    for row in c.fetchall():
##        print row
    while True:
        row = c.fetchone()
        if row is None:
            break
        print row
'''
If we were comparing a string to a missing value, we would use empty quote to
check that the string object had no information inside it: stringName == ""

If we wanted to cmpare other objects to missing values to see if those objects
hold any information, we compare them to none, like this: objectName is None

This boolean comparison will return True if objectName exists but is empty and
False if objectName holds any value.
'''

c.close()
conn.close()
