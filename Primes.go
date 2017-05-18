package main

import (
	"fmt"
	"math"
	"testing"
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

func BenchmarkFunction(b *testing.B) {
	for i := 0; i < b.N; i++ {
		getPrimesBelowN(1000000)
	}
}

func main() {

	br := testing.Benchmark(BenchmarkFunction)
	fmt.Println(float64(br.NsPerOp()) / math.Pow(10.0, 9.0))
}
