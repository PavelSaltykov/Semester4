let fibonacci n =
    let rec subFubonacci i previous1 previous2 =
        let current = previous1 + previous2
        if i = n then 
            current
        else 
            subFubonacci (i + 1) current previous1
    
    if n < 0 then None
    elif n >= 2 then Some(subFubonacci 2 1 0)
    else Some(n)

let n = 5
printfn "Number: %d" n

match (fibonacci n) with
| Some(res) -> printfn "Fibonacci: %d" res
| None -> printfn "Incorrect number"