import sqlite3

# Get person data from user and import into a tuple
firstName = raw_input("Enter your first name: ")
lastName = raw_input("Enter your last name: ")
age = int(raw_input("Enter your age: "))
personData = (firstName, lastName, age)

# Now we execute the insert statement for supplied person data
with sqlite3.connect("test_database.db") as conn:
    c=conn.cursor()
    c.execute("INSERT INTO People VALUES(?,?,?)",personData)
# I could also update a row by using the parameterized method
    c.execute("UPDATE People SET Age=? WHERE firstName=? AND lastName=?",
              (45, "Luigi", "Vercotti"))
c.close()
conn.close()
