package main

import (
	"fmt"
	"math"
)

func getPrimesBelowN(n int) []int {
	primes := []int{2}

	for i := 3; i < n; i += 2 {
		isPrime := true
		sqI := int(math.Sqrt(float64(i)))
		for _, prime := range primes {
			if i%prime == 0 {
				isPrime = false
				break
			} else if prime > sqI {
				break
			}
		}
		if isPrime {
			primes = append(primes, i)
		}
	}

	return primes
}

func main() {

	fmt.Println(len(getPrimesBelowN(1000000)))
}
