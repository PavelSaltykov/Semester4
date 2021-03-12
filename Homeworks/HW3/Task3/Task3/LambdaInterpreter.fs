module LambdaInterpreter

/// Represents lambda-term.
type LambdaTerm =
| Variable of string
| Application of LambdaTerm * LambdaTerm
| Abstraction of string * LambdaTerm

/// Performs beta-reduction by normal strategy.
let rec performBetaReduction expression =
    let getNewVariable set =
        let rec getNewVariableRec current = 
            let generateNextVariable current =
                let indexOfLast = String.length current - 1
                let last = current.[indexOfLast]
                match last with
                | 'z' -> current + "a"
                | c -> current + string (int c + 1)
            match current with
            | cur when Set.contains cur set -> generateNextVariable cur |> getNewVariableRec
            | _ -> current

        getNewVariableRec "a"

    let rec freeVariables term =
        match term with
        | Variable(name) -> Set.add name Set.empty
        | Application(l, r) -> Set.union (freeVariables l) (freeVariables r)
        | Abstraction(variable, body) -> freeVariables body |> Set.remove variable

    let isFree variable term =
        freeVariables term |> Set.contains variable

    let rec substitute body variable term =
        match body with
        | Variable(name) when name = variable -> term
        | Variable(_) -> body
        | Application(l, r) -> Application(substitute l variable term, substitute r variable term)
        | Abstraction(v, _) when v = v -> body
        | Abstraction(v, innerTerm) when isFree v term |> not || isFree v innerTerm |> not -> 
            Abstraction(v, substitute innerTerm v term)
        | Abstraction(v, innerTerm) -> 
            let newVariable = Set.union (freeVariables innerTerm) (freeVariables term) |> getNewVariable
            let firstSubstitution = Variable(newVariable) |> substitute innerTerm v 
            Abstraction(newVariable, substitute firstSubstitution variable term)

    match expression with
    | Variable(_) -> expression
    | Abstraction(variable, term) -> Abstraction(variable, performBetaReduction term)
    | Application(Abstraction(variable, body), term) -> substitute body variable term |> performBetaReduction
    | Application(l, r) -> Application(performBetaReduction l, performBetaReduction r)