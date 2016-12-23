#!/usr/bin/env python2
# -*- coding: utf-8 -*-
#
# Python Ver:   2.7.12
#
# Author:       Sean Henry
#               fidelicatessen@gmail.com
"""Checks for files in sourcePath created or modified within past 24 hours (ignoring subfolders) and copies them to destPath.

Usage:

	python DailyFileTransfer.py
"""

import shutil, os, time


def checkFiles():
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
    copyFiles(result)


def copyFiles(result):
    """Copies all files in result list to destPath folder.

    Args:
        An iterable series of paths.
    """    
    destPath = "C:\\Users\\Sean\\Desktop\\HQ" # can be changed to reflect any destination folder
    for filepath in result:
        shutil.copy(filepath, destPath)


checkFiles()
   




                  



