import math
import time


def GetPrimesBelowN(n):
    primes = [2]
    for i in range(3,n,2):
        isPrime = True
        sqI = math.sqrt(i)
        for prime in primes:
            if i % prime == 0:
                isPrime = False
                break
            elif prime > sqI:
                break
        if isPrime :
            primes.append(i)

    return primes


x = 100
while x <= 10000000:
    start = time.clock()
    for i in range(10):
        GetPrimesBelowN(x)
    end = time.clock()
    tTime = (end-start)/10
    print(x, "in:",tTime)
    x *= 10
