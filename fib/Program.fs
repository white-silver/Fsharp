// Learn more about F# at http://fsharp.org
open System
let rec fib x = 
    match x with
        |0 -> 0
        |1 -> 1
        |_ -> fib(x-1) + fib(x-2)
printfn "%i" (fib 2)

let rec fact x =
    match x with
        |0 -> 1
        |_ -> x * fact(x-1)
printfn "%i" (fact 10)