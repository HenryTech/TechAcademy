

from tkinter import *
import tkinter as tk
import ftgui, ftfunc


class ParentWindow(Frame):
    def __init__(self, master):
    
        # define master frame config and center window
        self.master = master
        self.master.minsize(300,200)
        self.master.maxsize(300,200)
        ftfunc.center_window(self, 300, 200)

        # title and background
        self.master.title("24-Hour Fresh File Transfer")
        self.master.configure(bg="#F0F0F0")

        # widgets are in the gui module--time to load them
        # sourcePath and destPath get passed around a lot through this program, so best to init them now
        self.sourcePath = ""
        self.destPath = ""
        ftgui.load_gui(self)
	    

if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop()