let powers n m =
    if n < 0 then invalidArg (nameof n) "Incorrect value"
    if m < 0 then invalidArg (nameof m) "Incorrect value"

    let rec makeList newList count =
        match count with
        | 0 -> newList
        | _ -> makeList ((List.head newList / 2) :: newList) (count - 1)
    makeList [pown 2 (n + m)] m

let n = 2
let m = 8
powers n m |> printfn "Powers: %A"