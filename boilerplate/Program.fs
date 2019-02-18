open System.Xml
// Learn more about F# at http://fsharp.org

let product n = 
    let initialValue = 1
    let action productSoFar x = productSoFar * x
    [1..n] |> List.fold action initialValue

printfn "%d" (product 10)

let sumOfOdds n = 
    let initialValue = 0
    let action sumSoFar x = if x%2=0 then sumSoFar else sumSoFar + x
    [1..n] |> List.fold action initialValue

printfn "%d" (sumOfOdds 10)

type NameAndSize = {Name:string; Size:int}
let maxNameAndSize list =
    let innerMaxNameAndSize initialValue rest =
        let action maxSoFar x = if maxSoFar.Size < x.Size then x else maxSoFar
        rest |> List.fold action initialValue
    
    match list with
    | [] ->
        None
    | first::rest ->
        let max = innerMaxNameAndSize first rest
        Some max
let list = [
    {Name="Alice"; Size=10}
    {Name="Bob"; Size=1}
    {Name="Carol"; Size=12}
    {Name="David"; Size=5}
    ]    

printfn "%A" (maxNameAndSize list)
printfn "%A" (maxNameAndSize [])
