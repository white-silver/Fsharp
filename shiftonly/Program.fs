// Learn more about F# at http://fsharp.org

open System
let N = Console.ReadLine() |> int
let A = Console.ReadLine().Split(' ') |> Array.toList |> List.map int

let rec countShift x =
    match x with
        |[] -> 1 
        |first::rest when first%2=0 -> countShift(rest)
        |_ -> 0

let rec action list = 
    match countShift(list) with
        |1 -> 1 + action(list)
        |_ -> 0

printfn "%d" (action(A))