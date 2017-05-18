import math


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

print(len(GetPrimesBelowN(1000000)))