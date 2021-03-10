namespace Task3

module ParseTree =
    
    /// Represents parse tree
    type Tree =
    | Number of int
    | Addition of Tree * Tree
    | Subtraction of Tree * Tree
    | Multiplication of Tree * Tree
    | Division of Tree * Tree

    /// Calculates the value of an arithmetic expression parse tree
    let rec calculate (tree: Tree) =
        match tree with
        | Number(n) -> n
        | Addition(left, right) -> calculate left + calculate right
        | Subtraction(left, right) -> calculate left - calculate right
        | Multiplication(left, right) -> calculate left * calculate right
        | Division(left, right) ->
            calculate right |> fun r -> if r = 0 then invalidOp "Dividing by zero." else calculate left / r