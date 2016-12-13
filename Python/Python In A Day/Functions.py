# To demonstrate global vs function variables, setting someValue outside the function.
someValue=5

def letsAdd (x, y):
    addition = x+y
    someValue=10
    return addition

# Note that someValue stays 5, even though the function tries to change it.
print letsAdd(3,5)
print someValue

def letsSubtract(x,y):
    subtraction=x-y
    return subtraction

print letsSubtract(10,4)

def moreSubtraction(x,y,z):
    subtraction=x-y-z
    return subtraction

print moreSubtraction(40,3,11)

def letsMultiply(x,y):
    multiplication=x*y
    return multiplication

print letsMultiply(8,17)

def letsDivide(x,y):
    division=float(x)/float(y)
    return division

print letsDivide(100,3)
