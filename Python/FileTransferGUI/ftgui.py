#!/usr/bin/env python3
from tkinter import *
import tkinter as tk
from tkinter import ttk

import ftmain, ftfunc


def load_gui(self):

    # setting up labels and gridding them
    ttk.Label(self.master, text = "Source Folder:").grid(row = 0, column = 0, padx = (20, 0), pady = (15, 0), sticky = "nw")
    ttk.Label(self.master, text = "Destination Folder:").grid(row = 2, column = 0, padx = (20, 0), pady = (15, 0), sticky = "nw")
    
    # setting up entry boxes and gridding them
    self.sourceEntry = ttk.Entry(self.master, width = 40)
    self.destEntry = ttk.Entry(self.master, width = 40)
    self.sourceEntry.grid(row = 1, column = 0, columnspan = 2, padx = (20, 0), pady = (0, 10), sticky = "new")
    self.destEntry.grid(row = 3, column = 0, columnspan = 2, padx = (20, 0), pady = (0, 20), sticky = "new")
    
    # setting up buttons, gridding them, and calling functions on events
    ttk.Button(self.master, text = "Select Source", command = lambda: ftfunc.sourceSelect(self)).grid(row = 0, column = 1, pady = (15, 0), sticky = "se")
    ttk.Button(self.master, text = "Select Destination", command = lambda: ftfunc.destSelect(self)).grid(row = 2, column = 1, pady = (10, 0), sticky = "se")
    ttk.Button(self.master, text = "Transfer", command = lambda: ftfunc.validate(self)).grid(row = 4, column = 0, padx = (20, 0), sticky = "w")
    
    
if __name__=="__main__":
    pass