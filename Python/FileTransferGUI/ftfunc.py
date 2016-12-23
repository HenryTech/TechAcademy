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
import ftmain, ftgui
from tkinter import messagebox


def checkFiles(self, sourcePath, destPath):
    """Check files in sourcePath for creation or modification within the past 24 hours (ignoring subfolders).

    Returns:
        An iterable series of paths.
    """    
    sourcePath = "C:\\Users\\Sean\\Desktop\\Local" # can be changed to reflect any source folder
    result = []
    past = time.time() - 24*60*60 # seconds stamp from 24 hours ago
    for path, subfolder, filename in os.walk(sourcePath):
        for i in filename:
            filepath = os.path.join(path, i)
            if os.path.getmtime(filepath) >= past or os.path.getctime(filepath) >= past:
                result.append(filepath)
    copyFiles(result, sourcePath, destPath)


def copyFiles(self, result, sourcePath, destPath):
    """Copies all files in result list to destPath folder.

    Args:
        An iterable series of paths.
    """    
    destPath = "C:\\Users\\Sean\\Desktop\\HQ" # can be changed to reflect any destination folder
    for filepath in result:
        shutil.copy(filepath, destPath)
        
        
def center_window(self, w, h): # pass in the tkinter frame (master) reference and the w and h
    # get user's screen width and height
    screen_width = self.master.winfo_screenwidth()
    screen_height = self.master.winfo_screenheight()
    # calculate x and y coordinates to paint the app centered on the user's screen
    x = int((screen_width/2) - (w/2))
    y = int((screen_height/2) - (h/2))
    centerGeo = self.master.geometry('{}x{}+{}+{}'.format(w, h, x, y))
    return centerGeo
    
    
def sourceSelect(self, sourcePath, destPath):


def destSelect(self, sourcePath, destPath):


def validate(self, sourcePath, destPath):


if __name__ == "__main__":
    pass
   




                  



