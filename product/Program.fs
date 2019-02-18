// Learn more about F# at http://fsharp.org
open System
let a:string array = Console.ReadLine().Split(' ')
let product list = 
    match list with
    | [] -> 0
    | first::rest -> first * rest.Head
    
let evenOrOdd x  =
    match x%2 with
    |0 -> printfn "Even"
    |_ -> printfn "Odd"

a |> Array.toList |> List.map int|> product |> evenOrOdd