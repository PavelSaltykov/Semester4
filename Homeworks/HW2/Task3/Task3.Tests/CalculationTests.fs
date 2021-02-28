module Task3.Tests

open NUnit.Framework
open Task3.ParseTree
open FsUnit

[<Test>]
let dividingByZero () =
    (fun () -> Division(Number(1), Number(0)) |> calculate |> ignore) 
        |> should throw typeof<System.InvalidOperationException>

let cases () =
    [
        Number(1), 1
        Multiplication(Addition(Number(1), Number(1)), Number(2)), 4
        Multiplication(Addition(Number(52), Number(71)), Subtraction(Number(6), Number(31))), -3075
    ] |> List.map (fun (tree, res) -> TestCaseData(tree, res))

[<TestCaseSource(nameof cases)>]
let calculationTests tree res =
    calculate tree |> should equal res
