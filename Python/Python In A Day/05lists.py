epicProgrammerList = ["Tim Berners-Lee",
                      "Guido van Rossum",
                      "Linus Torvalds",
                      "Larry Page",
                      "Sergey Brin"]
epicProgrammerList[4] = "Sean Henry"
epicProgrammerList.append("Sergey Brin")
# print to console
print "An epic programmer: "+epicProgrammerList[0]
print "An epic programmer: "+epicProgrammerList[1]
print "An epic programmer: "+epicProgrammerList[2]
print "An epic programmer: "+epicProgrammerList[3]
print "An epic programmer: "+epicProgrammerList[4]
print "An epic programmer: "+epicProgrammerList[5]

# For loop works better for this!
for programmer in epicProgrammerList:
    print "An epic programmer: "+programmer

