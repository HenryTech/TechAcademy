import datetime
from pytz import timezone
import pytz

#Gets the time in the foramt Hours:Minutes
def getTime(TZ):
    loc_time = datetime.datetime.now(TZ)
    loc_time = str(str(loc_time).split(' ')[1])
    loc_time = loc_time.split('.')[0]
    loc_time = loc_time.split(':')
    loc_time = loc_time[0]+':'+loc_time[1]
    return loc_time

#Gets the branches status open or closed based on local time
def branchStatus(time):
    hour = int(time.split(':')[0])
    minute = int(time.split(':')[1])

    if hour >= 9 and hour < 21:
        return 'OPEN'
    elif hour == 21 and minute == 0:
        return 'OPEN'
    else:
        return 'CLOSED'

#Prints out the branch, time and status of all branches
def printInfo(branches):
    print ("Branch\t\tTime\t\tStatus")
    print ("---------------------------------------")
    for b in branches:
        print (b + '\t' + branches[b])

def main():
    #Define timezones for the three offices as finals
    POR_TZ = pytz.timezone('US/Pacific')
    NY_TZ = pytz.timezone('US/Eastern')
    LON_TZ = pytz.timezone('Europe/London')
    

    #Dictionary of branches, local time and status
    branches = {
        'Portland' : getTime(POR_TZ) + '\t\t' + branchStatus(getTime(POR_TZ)),
        'New York' : getTime(NY_TZ) + '\t\t' + branchStatus(getTime(NY_TZ)),
        'London  ' : getTime(LON_TZ) + '\t\t' + branchStatus(getTime(LON_TZ))
        }

    printInfo(branches)

main()