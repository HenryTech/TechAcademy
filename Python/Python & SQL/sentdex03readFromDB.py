'''
 Gotta import it first, to use it.
 We're importing time so that we can populate our unix field,
 datetime because we have a datestamp field,
 and random to create the value field.
'''
import sqlite3
import time
import datetime
import random

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

'''
 Let's try doing this dynamically instead. We're getting the number of seconds since
 01-01-70 from the time.time() function, then we're setting date function to be a
 more readable version by formatting it using strftime (4-digit year-month#-day#
 24-hour clock hour:minutes:seconds). We could format it other ways, too, if we wanted.
 We don't want to close c and conn at the end of this because we're going to be inputting
 multiple values, and it would be silly to close those things after every entry.
'''
def dynamic_data_entry():
    unix = time.time()
    date = str(datetime.datetime.fromtimestamp(unix).strftime('%Y-%m-%d %H:%M:%S'))
    keyword = "Python"
    value = random.randrange(0,10)
    c.execute("INSERT INTO stuffToPlot (unix, datestamp, keyword, value) VALUES (?, ?, ?, ?)",
              (unix, date, keyword, value))
    conn.commit()
    
'''
 Let's create a function to read data from the dB now. Note that using SELECT * in
 this case is just like highlighting a bunch of stuff--we need to actually do something
 with it in order to make it meaningful. c.fetchall() gets all that data and puts it somewhere,
 in this case the data variable. c.fetchone() would fetch only a single row. If we tried to
 print(data) at this point, it would be a huge block of goop. But we can iterate through it!
 The for loop below those commands is a more organized way of displaying the data.

 I've added the WHERE clause to demonstrate searching a database and narrowing the returned
 results.

 You could replace the * with a list of columns, and they would appear in the order you typed them.
'''
def read_from_db():
    c.execute("SELECT * FROM stuffToPlot WHERE value=3 AND keyword='Python'")
##    data - c.fetchall()
##    print(data)
    for row in c.fetchall():
        print(row)
    


# create_table()
# data_entry()
read_from_db()

'''
 Now instead of just doing this manually with data_entry(), we're going to use a for loop
 to automatically enter data into several rows. We're adding a delay (time.sleep(1)) so
 that the timestamp will change significantly between each entry. Since we didn't close
 the cursor or connection in our function, we're doing it here at the end of the script.
'''
#for i in range(10):
#    dynamic_data_entry()
#    time.sleep(1)
c.close()
conn.close()


