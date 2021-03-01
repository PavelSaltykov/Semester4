namespace Task1

module ListFunctions =
    
    /// Counts even numbers in a list using the function List.map
    let countEvenMap list =
        list |> List.map (fun x -> (abs x + 1) % 2) |> List.sum

    /// Counts even numbers in a list using the function List.filter
    let countEvenFilter list =
        list |> List.filter (fun x -> x % 2 = 0) |> List.length

    /// Counts even numbers in a list using the function List.fold
    let countEvenFold list =
        List.fold (fun acc x -> (abs x + 1) % 2 + acc) 0 list
