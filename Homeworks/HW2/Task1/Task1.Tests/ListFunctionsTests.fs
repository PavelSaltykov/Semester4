module Task1.Tests

open NUnit.Framework
open Task1.ListFunctions
open FsUnit
open FsCheck

let cases () = 
    [
        [], 0
        [1], 0
        [2], 1
        [-2 .. 0], 2
        [1; 3; 5; 7], 0
        [1 .. 10], 5 
    ] |> List.map (fun (list, res) -> TestCaseData(list, res))

[<TestCaseSource(nameof cases)>]
let countUsingMapTest list expected =
    countEvenMap list |> should equal expected

[<TestCaseSource(nameof cases)>]
let countUsingFilterTest list expected =
    countEvenFilter list |> should equal expected

[<TestCaseSource(nameof cases)>]
let countUsingFoldTest list expected =
    countEvenFold list |> should equal expected

let checkFunctionEquivalence (list: list<int>) =
    let mapResult = countEvenMap list
    countEvenFilter list = mapResult && countEvenFold list = mapResult

[<Test>]
let functionEquivalenceTest () =
    Check.QuickThrowOnFailure checkFunctionEquivalence
