// Learn more about F# at http://fsharp.org

open System
let input = Console.ReadLine()
let charlist = input.ToCharArray(0,input.Length) |> Array.toList
let countMarble list =
    let initialValue = 0
    let action counter x = if x='1' then counter + 1 else counter
    list |> List.fold action initialValue

printfn "%d" (countMarble charlist)