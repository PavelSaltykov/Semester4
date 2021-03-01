module Task4.Tests

open NUnit.Framework
open FsUnit
open Task4

[<Test>]
let ``first prime number should be 2`` () =
    PrimeNumbers.generateSeq () |> Seq.item 0 |> should equal 2

[<Test>]
let ``check first 10 numbers`` () =
    let expected = seq { 2; 3; 5; 7; 11; 13; 17; 19; 23; 29 }
    PrimeNumbers.generateSeq () 
    |> Seq.take 10 
    |> should equal expected