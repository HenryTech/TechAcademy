# Moves files from Folder A to Folder B on the desktop



import shutil, os

# copies all files in Folder A to Folder B
def copyFiles():
    for path, subfolder, filename in os.walk("c:\\users\\" + user + "\\desktop\\folder a"):
        for i in filename:
                  shutil.copy(path + "\\" + i, "c:\\users\\" + user + "\\desktop\\folder B")
    removeFiles()

# removes files that have just been copied from Folder A
def removeFiles():
    for path, subfolder, filename in os.walk("c:\\users\\" + user + "\\desktop\\folder a"):
        for i in filename:
                  os.remove(path + "\\" + i)
    printPaths()


# prints paths of all copied files
def printPaths():
    print "\nThe paths of the moved files are:"
    for path, subfolder, filename in os.walk("c:\\users\\" + user + "\\desktop\\folder B"):
        for i in filename:
                  print path + "\\" + i


print "Preparing to move all files from Folder A on your desktop\nto Folder B on your desktop."
user = raw_input("Please enter your windows username: ")
copyFiles()

                  



