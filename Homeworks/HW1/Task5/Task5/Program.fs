let findInList list number =
    let rec find list i =
        match list with
        | [] -> -1
        | head :: tail ->
            if List.head list = number then i
            else find tail (i + 1)
    find list 0

let list = [1; 2; 3]
let number = 1
printfn "Position of %d in %A: %d" number list (findInList list number)