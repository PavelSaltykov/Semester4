let factorial n =
    let rec subFactorial i acc = 
        match i with
        | 0 -> acc
        | _ -> subFactorial (i - 1) (acc * i)

    if n < 0 then
        invalidArg (nameof n) "Incorrect number"
    subFactorial n 1

let number = 5
printfn "%d! = %d" number (factorial number)