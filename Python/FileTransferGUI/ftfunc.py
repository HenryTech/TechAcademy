#!/usr/bin/env python3
# -*- coding: utf-8 -*-
#
# Python Ver:   3.5.2
#
# Author:       Sean Henry
#               fidelicatessen@gmail.com

import shutil
import os
import time
import sqlite3
from tkinter import *
from tkinter import messagebox
from tkinter import filedialog
import ftmain, ftgui



def checkFiles(self):
    result = []
    for path, subfolder, filename in os.walk(self.sourcePath):
        for i in filename:
            filepath = os.path.join(path, i)
            if os.path.getmtime(filepath) >= self.lastTrans or os.path.getctime(filepath) >= self.lastTrans:
                result.append(filepath)
    copyFiles(self, result)


def copyFiles(self, result):
    """Copies all files in result list to destPath folder.

    Args:
        An iterable series of paths.
    """    
    for filepath in result:
        shutil.copy(filepath, self.destPath)
    messagebox.showinfo(title = "Success!", message = "All files modified or created\nsince "+ time.ctime(self.lastTrans) + " in:\n" + self.sourcePath + "\nhave successfully been copied to:\n" + self.destPath)
    updateDB(self)
    refreshLabel(self)
                
        
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
    
    
def createDB(self):
    conn = sqlite3.connect("transtime.db")
    with conn:
        c = conn.cursor()
        c.execute("CREATE TABLE IF NOT EXISTS tbl_transtime(unixtime REAL)")
        conn.commit()
    c.close()
    conn.close()
    setLtrans(self)
    
    
def setLtrans(self):
    conn = sqlite3.connect("transtime.db")
    with conn:
        c = conn.cursor()
        c, count = countRecords(c)
        if count < 1:
            past = time.time() - 24*60*60 # seconds stamp from 24 hours ago
            self.lastTrans = past
            c.execute("INSERT INTO tbl_transtime (unixtime) VALUES (?)", (past,))
            conn.commit()
            messagebox.showinfo(title = "Notification", message = "This is the first time a transfer has occurred.\n\nBy default, files created or modified within\nthe last 24 hours will be transferred.")
        else:
            c.execute("SELECT * FROM tbl_transtime ORDER BY unixtime DESC LIMIT 1")
            self.lastTrans = c.fetchone()[0]
    c.close()
    conn.close()
    
    
def countRecords(c):
    count = ""
    c.execute("SELECT COUNT(*) FROM tbl_transtime")
    count = c.fetchone()[0]
    return c, count


def updateDB(self):
    self.lastTrans = time.time()
    conn = sqlite3.connect("transtime.db")
    with conn:
        c = conn.cursor()
        c.execute("INSERT INTO tbl_transtime VALUES (?)", (time.time(),))
        conn.commit()
    c.close()
    conn.close()
    
    
def refreshLabel(self):
    self.timeLabel.config(text = "Last Transfer Occurred:\n" + (time.ctime(self.lastTrans)))
        

if __name__ == "__main__":
    pass
   




                  



