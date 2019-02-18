open System.Xml.Linq
open System.Globalization
open System.ComponentModel.Design
// Learn more about F# at http://fsharp.org

let add2 x = x + 2
let mult3 x = x * 3
let square x = x * x

[1..10] |> List.map add2 |> printfn  "%A"
[1..10] |> List.map mult3 |> printfn  "%A"
[1..10] |> List.map square |> printfn  "%A"

let add2ThenMult3 = add2 >> mult3
let mult3ThenSquare = mult3 >> square

add2ThenMult3 3 |> printfn "%d"

let logMsg msg x = printf "%s%i" msg x; x
let logMsgN msg x = printfn "%s%i" msg x; x

let mult3ThenSquareLogged = 
    logMsg "before="
    >> mult3
    >> logMsg " after mult3="
    >> square
    >> logMsgN " result="

mult3ThenSquareLogged 5 |> ignore

[1..10] |> List.map mult3ThenSquareLogged |> ignore 

let listOfFunctions = [
    mult3
    square
    add2
    logMsgN "result=";
    ]
let allFunctions = List.reduce (>>) listOfFunctions
allFunctions 5 |> ignore

type DateScale = Hour | Hours | Day | Days | Week | Weeks
type DateDirection = Ago | Hence

let getDate interval scale direction = 
    let absHours = match scale with
                    |Hour | Hours -> 1 * interval
                    |Day | Days -> 24 * interval
                    |Week | Weeks -> 24 * 7 * interval
    let signedHours = match direction with
                        | Ago -> -1 * absHours
                        | Hence -> absHours
    System.DateTime.Now.AddHours(float signedHours)

printfn "%A" (getDate 5 Days Ago)
printfn "%A" (getDate 1 Hour Hence)