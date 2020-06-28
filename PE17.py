# -*- coding: utf-8 -*-
"""
Created on Thu May 14 22:22:07 2020

@author: Tom
"""

numbers_dict = {
    1: "one",
    2: "two",
    3: "three",
    4: "four",
    5: "five",
    6: "six",
    7: "seven",
    8: "eight",
    9: "nine",
    10: "ten",
    11: "eleven",
    12: "twelve",
    13: "thirteen",
    14: "fourteen",
    15: "fifteen",
    16: "sixteen",
    17: "seventeen",
    18: "eighteen",
    19: "nineteen",
    20: "twenty",
    30: "thirty",
    40: "forty",
    50: "fifty",
    60: "sixty",
    70: "seventy",
    80: "eighty",
    90: "ninety",
    100: "hundred"
}

num_letters = 0
for i in range(1, 20):
    num_letters += len(numbers_dict[i])
for i in range(20, 100):
    if i % 10 == 0:
        num_letters += len(numbers_dict[i])
    else:
        num_letters += len(numbers_dict[i - i % 10]) + \
                        len(numbers_dict[i % 10])
num_letters *= 10
num_letters += 99*((3+7+3) + (3+7+3) + (5+7+3) + (4+7+3) + (4+7+3) +
                   (3+7+3) + (5+7+3) + (5+7+3) + (4+7+3))
num_letters += len("hundred")*9 + (3+3+5+4+4+3+5+5+4)
num_letters += len("onethousand")
print(num_letters)
