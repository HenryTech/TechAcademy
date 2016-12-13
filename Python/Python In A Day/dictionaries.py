epicProgrammerDict = {"Tim Berners-Lee":"tbl@gmail.com",
                      "Guido van Rossum":"gvr@gmail.com",
                      "Linus Torvalds":"lt@gmail.com"
                      }
# Adds a different email address
epicProgrammerDict["Tim Berners-Lee"] = "tim@gmail.com"
print "New email for Tim: "+epicProgrammerDict["Tim Berners-Lee"]

# Let's get Larry Page in on this
epicProgrammerDict["Larry Page"]="lp@gmail.com"
epicProgrammerDict["Sean Henry"]="fidelicatessen@gmail.com"
epicProgrammerDict["Sergey Brin"]="sb@gmail.com"

# WHAT IS SEAN HENRY DOING IN THERE!? Let's delete him!
del epicProgrammerDict["Sean Henry"]
                      
