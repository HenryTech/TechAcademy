import sqlite3

# first set person values
personValues = (
    ("Jean-Baptiste Zorg", "Human", 122),
    ("Korben Dallas", "Meat Popsicle", 100),
    ("Ak'not", "Mangalore", -5)
    )

# Then perform actions on dB in RAM. Note that executescript could have been
# used but I was trying to make this easier to parse and debug.
with sqlite3.connect(":memory:") as conn:
    c = conn.cursor()
    c.execute("DROP TABLE IF EXISTS Roster")
    c.execute("CREATE TABLE Roster(Name TEXT, Species TEXT, IQ INT)")
    c.executemany("INSERT INTO Roster VALUES(?,?,?)",personValues)
    c.execute('UPDATE Roster SET Species = "Human" WHERE Name = "Korben Dallas"')
    c.execute("SELECT Name, IQ FROM Roster WHERE Species = 'Human'")
    for row in c.fetchall():
        print(row)
c.close()
conn.close()

    
