namespace Task4

module PrimeNumbers =
    
    /// Generates an infinite sequence of prime numbers.
    let generateSeq () =
        let isPrime n =
            let max = float n |> sqrt |> int
            [2 .. max] |> List.exists (fun i -> n % i = 0) |> not
        Seq.initInfinite (fun n -> n + 2) |> Seq.filter isPrime