open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.


let isPrime n =
  let sqrt' = (float >> sqrt >> int) n // square root of integer
  [ 2 .. sqrt' ] // all numbers from 2 to sqrt'
  |> List.forall (fun x -> n % x <> 0) // no divisors

let allPrimes =
  let rec allPrimes' n =
    seq { // sequences are lazy, so we can make them infinite
      if isPrime n then
        yield n
      yield! allPrimes' (n+1) // recursing
    }
  allPrimes' 2 // starting from 2



            
    
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    for x in (Seq.unfold (fun s -> if s < 1000 * 1000 * 1000 then Some(s, s*10) else None) 100) do
        let watch = new System.Diagnostics.Stopwatch();
        Console.WriteLine("all priems below {0} parallel", x);
        watch.Start();
        for i in 0..2 do
            do allPrimes
                |> Seq.takeWhile (fun p -> p < x) // only 20
                |> List.ofSeq
                |> ignore
        watch.Stop()
        Console.WriteLine(new TimeSpan(watch.Elapsed.Ticks/3L));
        Console.WriteLine();


    0 // return an integer exit code
