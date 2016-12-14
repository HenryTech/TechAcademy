import sqlite3

with sqlite3.connect("test_database.db") as connection:
    c=connection.cursor()
    c.executescript("""
    DROP TABLE IF EXISTS People;
    CREATE TABLE People(FirstName TEXT, LastName TEXT, Age INT);
    INSERT INTO People VALUES('Ron', 'Obvious', '42');
    """)
c.close()
connection.close()

'''
    Alternately, if we had a bunch of people to enter all at once, we could
    use a tuple of tuples and use this instead of that c.executescript above.

    This is called a parameterized statement because it uses (?,?,?) and then
    specifies a variable to plug into those places.

    Entering data into SQL using a parameterized statement is preferable, as it
    minimizes the chances of a SQL injection attack.
'''
##peopleValues = (("Ron", "Obvious", 42),
##                ("Luigi", "Vercotti", 43),
##                ("Arthur", "Belling", 28))
##c.executemany("INSERT INTO People VALUES(?,?,?)",peopleValues)












