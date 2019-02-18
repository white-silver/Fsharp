// Learn more about F# at http://fsharp.org

open FSharp.Scanf

type Foo =
  | A of int
  | B of bool
  | C of Foo * Foo

let x = C (A 42, B true)

let rec f x =
  match x with
    | A _ -> "A"
    | _ -> "not A"

printfn "What is the ultimate answer?"

let a =
  try
    1 + 3
  with
    | _ -> 42

try
    let ans = scanfn "%i"
    if ans = 42 then
        printfn "correct."
    else
        printfn "%i? no" ans
with
    | _ -> printfn "you entered something other than a number."
    