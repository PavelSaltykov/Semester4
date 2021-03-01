namespace Task2

module MapForTree =
    
    /// Binary tree
    type Tree<'a> =
    | Node of 'a * Tree<'a> * Tree<'a>
    | Empty
    
    /// Applies a function to each element of a binary tree and returns a new binary tree
    let rec map func tree =
        match tree with
        | Empty -> Empty
        | Node(value, left, right) -> Node(func value, map func left, map func right)