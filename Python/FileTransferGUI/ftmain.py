

from tkinter import *
import tkinter as tk
import ftgui, ftfunc


class ParentWindow(Frame):
    def __init__(self, master):
    
        # define master frame config and center window
        self.master = master
        self.master.minsize(500,300)
        self.master.maxsize(500,300)
        ftfunc.center_window(self, 500, 300)

        # title and background
        self.master.title("24-Hour Fresh File Transfer")
        self.master.configure(bg="#F0F0F0")

        # widgets are in the gui module--time to load them
        ftgui.load_gui(self)
	    

if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop()