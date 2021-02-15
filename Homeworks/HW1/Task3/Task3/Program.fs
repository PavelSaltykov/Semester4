let reverse list =
    let rec subReverse list acc =
        match list with
        | [] -> acc
        | head :: tail -> subReverse tail (head :: acc)
    subReverse list []

let list = [1; 2; 3]
printfn "List: %A" list
reverse list |> printfn "Reverse list: %A"
