namespace Task1

module ListFunctions =
    let countEvenMap list =
        list |> List.map (fun x -> (abs x + 1) % 2) |> List.sum

    let countEvenFilter list =
        list |> List.filter (fun x -> x % 2 = 0) |> List.length

    let countEvenFold list =
        List.fold (fun acc x -> (abs x + 1) % 2 + acc) 0 list
