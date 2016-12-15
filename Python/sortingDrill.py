# This is a bubble sort that checks to see if it has already gotten to a sorted
# state and stops operation if it finds that it hasn't changed the order of any
# values during a given pass. The exch value is used to determine this.
def shortBubbleSort(someList):
    exch = True
    passnum = len(someList)-1
    while passnum > 0 and exch:
        exch = False
        for i in range(passnum):
            if someList[i] > someList[i+1]:
                exch = True
                someList[i], someList[i+1] = someList[i+1], someList[i]
        passnum -= 1

# Now we set up our pre-defined lists to be sorted
firstList = [67, 45, 2, 13, 1, 998]
secondList = [89, 23, 33, 45, 10, 12, 45, 45, 45]

# Send firstList through the bubble sorter and then print results
shortBubbleSort(firstList)
print(firstList)

# Send secondList through the bubble sorter and then print results
shortBubbleSort(secondList)
print(secondList)
