import statistics

list1 = [82, 8, 23, 97, 92, 44, 17, 39, 11, 12]

resmean = statistics.mean(list1)
print(resmean)
ressum = statistics._sum(list1)
print(ressum)
resstdev = statistics.stdev(list1, xbar=None)
print(resstdev)

import random
print(random.randint(0, 100))
print(random.randint(0, 100))