namespace Task2

module MapForTree =
    type Tree<'a> =
    | Node of 'a * Tree<'a> * Tree<'a>
    | Empty
    
    let rec map func tree =
        match tree with
        | Empty -> Empty
        | Node(value, left, right) -> Node(func value, map func left, map func right)