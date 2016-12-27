#!/usr/bin/env python2
# -*- coding: utf-8 -*-
#
# Python Ver:   2.7.12
#
# Author:       Sean Henry
#               fidelicatessen@gmail.com

import shutil
import os
import time
from tkinter import *
from tkinter import messagebox
from tkinter import filedialog
import ftmain, ftgui



def checkFiles(self):
    """Check files in sourcePath for creation or modification within the past 24 hours (ignoring subfolders).

    Returns:
        An iterable series of paths.
    """    
    result = []
    past = time.time() - 24*60*60 # seconds stamp from 24 hours ago
    for path, subfolder, filename in os.walk(self.sourcePath):
        for i in filename:
            filepath = os.path.join(path, i)
            if os.path.getmtime(filepath) >= past or os.path.getctime(filepath) >= past:
                result.append(filepath)
    copyFiles(self, result)


def copyFiles(self, result):
    """Copies all files in result list to destPath folder.

    Args:
        An iterable series of paths.
    """    
    for filepath in result:
        shutil.copy(filepath, self.destPath)
    messagebox.showinfo(title = "Success!", message = "All files modified or created within the past 24 hours in:\n" + self.sourcePath + "\nhave successfully been copied to:\n" + self.destPath)
        
        
def center_window(self, w, h): # pass in the tkinter frame (master) reference and the w and h
    # get user's screen width and height
    screen_width = self.master.winfo_screenwidth()
    screen_height = self.master.winfo_screenheight()
    # calculate x and y coordinates to paint the app centered on the user's screen
    x = int((screen_width/2) - (w/2))
    y = int((screen_height/2) - (h/2))
    centerGeo = self.master.geometry('{}x{}+{}+{}'.format(w, h, x, y))
    return centerGeo
    
    
def sourceSelect(self):
    self.sourcePath = filedialog.askdirectory()
    self.sourceEntry.delete(0, END)
    self.sourceEntry.insert(0, self.sourcePath)
    

def destSelect(self):
    self.destPath = filedialog.askdirectory()
    self.destEntry.delete(0, END)
    self.destEntry.insert(0, self.destPath)
    
    
def validate(self):
    if self.sourcePath == "" or self.destPath == "":
        messagebox.showinfo(title = "Warning", message = "Please select both a source and a destination folder!")
    elif self.sourcePath == self.destPath:
        messagebox.showinfo(title = "Warning", message = "Source and Destination folders must be different!")
        clearEntry(self)
    else:
        checkFiles(self)
        
        
def clearEntry(self):
    self.destEntry.delete(0, END)
    self.sourceEntry.delete(0, END)
    

if __name__ == "__main__":
    pass
   




                  



