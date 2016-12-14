# First, let's "borrow" the math module
# import math

# The math module let's you perform square roots! YOW!
# Let's try it out!
# print math.sqrt(16)

# Y'know what? We're only going to use 2 functions. Let's just focus on those.
from math import sqrt, exp

# Now, since we only got the 2 functions, our expressions can be terser.
# Is terser a word?
print sqrt(16)
print exp(2)

# Import our module
import smallMathsModule

# multiplyBy5 function
print smallMathsModule.multiplyBy5(3)

# add5 function
print smallMathsModule.add5(9)

# randomAdd function
print smallMathsModule.randomAdd(8)


