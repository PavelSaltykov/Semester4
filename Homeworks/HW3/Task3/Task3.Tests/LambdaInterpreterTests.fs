module Task3.Tests

open NUnit.Framework
open FsUnit
open LambdaInterpreter

let testCases () =
    let x = "x"
    let y = "y"
    let a = "a"
    let I = Abstraction(x, Variable(x))
    let term = Abstraction(x, Application(Application(Variable(x), Variable(x)), Variable(x)))
    [
        I, I
        Application(I, Variable(a)), Variable(a)
        Application(I, I), I
        Application(Abstraction(x, Variable(y)), Application(term, term)), Variable(y)
    ] |> List.map (fun (expression, res) -> TestCaseData(expression, res))

[<TestCaseSourceAttribute(nameof testCases)>]
let tests expression result =
    performBetaReduction expression |> should equal result
