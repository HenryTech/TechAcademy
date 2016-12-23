import datetime
import pytz

portland = datetime.datetime.now()
nyc = portland.hour + 3
london = portland.hour + 8

print "Time at Portland HQ is " + str(portland.time())

if nyc >= 9 and nyc < 21:
    print "The New York City branch is open."
else:
    print "The New York City branch is closed."

if london >= 9 and london < 21:
    print "The London branch is open."
else:
    print "The London branch is closed."

