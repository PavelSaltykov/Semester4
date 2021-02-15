let findInList list number =
    let rec find list i =
        match list with
        | [] -> None
        | head :: _ when head = number -> Some(i)
        | _ :: tail -> find tail (i + 1)
    find list 0

let list = [1; 2; 3]
let number = 1
let position = findInList list number
match position with
| Some(res) -> printfn "Position of %d in %A: %d" number list res
| None -> printfn "%A doesn't contain %d" list number
