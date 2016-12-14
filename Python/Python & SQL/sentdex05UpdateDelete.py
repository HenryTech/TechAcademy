'''
 Gotta import it first, to use it.
 We're importing time so that we can populate our unix field,
 datetime because we have a datestamp field,
 and random to create the value field.

 Importing the tools to do plotting now, with matplotlib files
 which I went to great lengths to figure out how to pip install.
'''
import sqlite3
import time
import datetime
import random
import matplotlib.pyplot as plt
import matplotlib.dates as mdates
from matplotlib import style
style.use('fivethirtyeight')

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

'''
    This next function grabs just the unix timestamp and value columns from
    our table and graphs them using matplotlib methods.
'''
def graph_data():
    c.execute("SELECT unix, value FROM stuffToPlot")
    dates=[]
    values=[]
    for row in c.fetchall():
##        print(row[0])
##        print(datetime.datetime.fromtimestamp(row[0]))
        dates.append(datetime.datetime.fromtimestamp(row[0]))
        values.append(row[1])
    plt.plot_date(dates, values, '-')
    plt.show()
    

'''
    The following function uses a 1-line for loop to print each row in the SQL search parameters.
    It prints out the entire dB using that 1-line for loop, then changes all values where value = 8. Then
    it prints the entire dB out again for comparison. Don't forget conn.commit()!

    After we did that, I commented out those lines and made it so that all rows with value = 99 are
    deleted.
'''
def del_and_update():
    c.execute("SELECT * FROM stuffToPlot")
    [print(row) for row in c.fetchall()]

##    c.execute("UPDATE stuffToPlot SET value = 99 WHERE value = 8")
##    conn.commit()
##
##    c.execute("SELECT * FROM stuffToPlot")
##    [print(row) for row in c.fetchall()]

    c.execute("DELETE FROM stuffToPlot WHERE value = 99")
    conn.commit()
    print(50*"#")

    c.execute("SELECT * FROM stuffToPlot")
    [print(row) for row in c.fetchall()]
    


# create_table()
# data_entry()
# read_from_db()
# graph_data()
del_and_update()

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



