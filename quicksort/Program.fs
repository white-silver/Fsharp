// Learn more about F# at http://fsharp.org

open System

let rec quicksort list =
    match list with 
    |[] ->
        []
    //if list is empty, return empty list
    |firstElem::otherElem ->
        let smallerElem = 
            otherElem
            |> List.filter (fun e -> e < firstElem)
            |> quicksort
        let largerElem =
            otherElem
            |> List.filter (fun e -> e >= firstElem)
            |> quicksort
        List.concat [smallerElem; [firstElem]; largerElem]

printfn "%A" (quicksort [1;5;23;18;9;1;3])
printfn "%A" (quicksort [1.0;5.2;5.0])
