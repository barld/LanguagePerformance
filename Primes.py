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

start= time.clock()
for i in range(10):
    GetPrimesBelowN(1000000)
end= time.clock()
time= (end-start)/10
print(time)
