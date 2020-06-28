# -*- coding: utf-8 -*-
"""
Created on Fri May 15 00:41:28 2020

@author: Tom
"""

num_dict = {}
for i in range(1, 28123):
    d_a = 0
    for j in range(1, int(i ** 0.5) + 1):
        if i % j == 0:
            if j != i // j:
                d_a += j + i // j
            else:
                d_a += j
    num_dict[i] = d_a - i
# print(num_dict)

abundant_nums = []
for key in num_dict:
    if num_dict[key] > key:
        abundant_nums.append(key)
# print(abundant_nums)
# print(len(abundant_nums))

sums = [0] * 28124
for i in range(0, len(abundant_nums)):
    for j in range(i, len(abundant_nums)):
        combo_sum = abundant_nums[i] + abundant_nums[j]
        if combo_sum <= 28123:
            if sums[combo_sum] == 0:
                sums[combo_sum] = combo_sum

total = 0
for i in range(1, len(sums)):
    if (sums[i] == 0):
        total += i

print(total)
