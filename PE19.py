# -*- coding: utf-8 -*-
"""
Created on Thu May 14 23:58:49 2020

@author: Tom
"""
from datetime import date

counter = 0
for i in range(1901, 2001):
    for j in range(1, 13):
        if date(i, j, 1).weekday() == 6:
            counter += 1
print(counter)
