# -*- coding: utf-8 -*-
"""
Created on Fri May 15 00:09:59 2020

@author: Tom
"""
num_dict = {}
for i in range(1, 10000):
    d_a = 0
    for j in range(1, i // 2 + 1):
        if i % j == 0:
            d_a += j
    num_dict[i] = d_a
print(num_dict)

dup_answer = []
for i in range(2, 10000):
    if num_dict[i] < 10000:
        check = num_dict[i]
        if num_dict[check] == i and num_dict[i] != i:
            dup_answer.append(i)
print(dup_answer)
print(sum(dup_answer))
