module Task2.Tests

open NUnit.Framework
open FsUnit
open Task2.MapForTree

[<Test>]
let emptyTreeTest () =
    map (fun x -> x + 1) Empty |> should equal (Empty: Tree<int>)

[<Test>]
let idFunctionTest () =
    let tree = Node(1, Node(2, Empty, Empty), Node(3, Empty, Empty))
    map id tree |> should equal tree

[<Test>]
let simpleMapTest () =
    let tree = Node(1, Node(0, Empty, Empty), Node(2, Empty, Node(5, Node(4, Empty, Empty), Empty)))
    let func x = x + 1
    let expected = Node(2, Node(1, Empty, Empty), Node(3, Empty, Node(6, Node(5, Empty, Empty), Empty)))
    map func tree |> should equal expected
