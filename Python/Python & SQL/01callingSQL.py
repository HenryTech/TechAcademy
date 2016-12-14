# SQLite is included in Python, but must be imported.
import sqlite3

# connection is made to the dB, which in this case is created on connection
# A currently existing dB could be connected to in the same way
connection = sqlite3.connect("test_database.db")

# We need a way to perform operations on the dB. A cursor is a control structure
# that allows just that. So we're now creating a cursor object (c) which will
# do just that.
c = connection.cursor()

# Now that we have a cursor object, we can peform regular operations on
# the dB like this:
c.execute("CREATE TABLE People(FirstName TEXT, LastName TEXT, Age INT)")

# Now we have a table, let's put some data in there
c.execute("INSERT INTO People VALUES('Ron', 'Obvious', 42)")

# Now we have to commit the changes to the table, or the changes won't be saved.
connection.commit()

'''
    Python doesn't differentiate between double-quotes and single-quotes, but
    some versions of SQL (SQLite being one) only allow strings to be included
    in single-quotes, so we have to be careful when constructing SQL statements.
'''

# If a one-time dB is needed, just to play around with table structures or to
# test code, we can use the special name :memory: to create a dB in temporary
# RAM storage like this:
connection = sqlite3.connect(':memory:')

# Now let's drop the People table (but we should check to make sure it exists
# first, which is just good practice that will avoid errors)
c.execute("DROP TABLE IF EXISTS People")

# When we're finished with the dB, it's a good idea to close the connection.
# This pushes any changes made to the dB and frees up resources that are no
# longer needed.
connection.close()

# When working with a dB connection, it's also a good idea to use the with
# keyword.
with sqlite3.connect("test_database.db") as connection:
    # perform any SQL operations using connection here
'''
    This simplifies our life by making code more compact, but there is another
    important benefit: no more need to commit() changes made--they're
    automatically saved.
    
    Keep in mind, though, changes will still need to be committed if we want
    to see the results immediately (before closing the connection).
'''


    
