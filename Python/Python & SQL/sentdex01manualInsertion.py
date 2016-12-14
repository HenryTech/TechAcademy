# Gotta import it first, to use it
import sqlite3

# Now we need to establish a connection to a dB. This particular one doesn't
# exist at the moment, but will be created.
conn = sqlite3.connect('tutorial.db')

# Next step is creating the cursor, or we won't be able to interact with
# the dB.
c = conn.cursor()

# Now we need to create a table. Or a function that will create a table.
# For reference: REAL is like a Python float. TEXT is similar to SQL VARCHAR.
def create_table():
    c.execute("CREATE TABLE IF NOT EXISTS stuffToPlot(unix REAL, datestamp TEXT, keyword TEXT, value REAL)")

# Insert values into the table and commit (or a function that does that, anyway):
# Note the cursor and the connection are being closed at the end.
def data_entry():
    c.execute("INSERT INTO stuffToPlot VALUES(12234538, '2016-02-15', 'Sean', 45)")
    conn.commit()
    c.close()
    conn.close()

create_table()
data_entry()

'''
    Note that, because the create_table() function checks to see if that table exists,
    we can run this over and over again, simply changing the data within the
    data_entry() function to add rows to the table.
'''



