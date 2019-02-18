// Learn more about F# at http://fsharp.org

open System

//variables
let myInt = 5
let myFloat = 3.14
let myString = "Hello!"

//semicolon is used for delimiter
let twoToFive = [2;3;4;5]

//add element to front
let oneToFive = 1 :: twoToFive

let zeroToFive = [0;1] @ twoToFive

//commas are never used

let square x = x * x

printfn "%d" (square 3)

let add x y = x + y

printfn "%f" (add 2.1 3.5)

//use indent for multi-line function

//two parameters,boolean function and list
let evens list = 
    let isEven x = x%2 = 0
    List.filter isEven list

printfn "%O" (evens oneToFive)

let sumOfSquaresTo100 = 
    List.sumBy square [1..100]
printfn "%d"(sumOfSquaresTo100)

let sumOfSquaresTo100piped = 
    [1..100] |> List.map square |> List.sum
printfn "%A" (sumOfSquaresTo100piped)

//no "return" is needed.

//Pattern matching

let simplePatternMatch = 
    let x = "a"
    match x with
        | "a" -> printfn "x is a"
        | "b" -> printfn "x is b"
        | _ -> printfn "x is somethin' else"

printfn "%A" (simplePatternMatch)

//Nullable wrappers
let validValue = Some(99)
let invalidValue = None

let optionPatternMatch input = 
    match input with
        | Some i -> printfn "input is a int=%d" i
        | None -> printfn "input is missing"
printfn "%A" (optionPatternMatch validValue)
printfn "%A" (optionPatternMatch invalidValue)

//complex data types

let twoTuple = 1,2
let threeTuple = "a",2,true

type Person = {First:string; Last:string}
let person1 = {First="john"; Last="Doe"}

//Union types have choices.
type Temp = 
    |DegreesC of float
    |DegreesF of float
let temp = DegreesF 98.6

type Employee = 
    |Worker of Person
    |Manager of Employee list
let jdoe = {First="John";Last="Doe"}
let worker = Worker jdoe

printfn "Printing an int %i, a float %f, a bool %b" 1 2.0 true

printfn "A string %s, and something generic %A" "hello" [1;2;3;4]

printfn "twoTuple=%A,\nPerson=%A,\nTemp=%A,\nEmployee=%A" 
        twoTuple person1 temp worker
        