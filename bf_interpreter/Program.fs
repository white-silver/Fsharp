(*
 + : increment the memory's data
 - : decrement the memory's data
 [ : goto ']' if the memory is null(0)
 ] : goto '[' if the memory is not null
 . : output from the memory
 , : input to the memory
 > : increment memory position
 < : decrement memory position
*)

open System
let mutable mem : int array = Array.zeroCreate 30000
let mutable ptr = 0

let interpret code = 
    match code with 
    |'+' ->
        mem.[ptr] <- mem.[ptr] + 1
    |'-' ->
        mem.[ptr] <- mem.[ptr] - 1 
    |'.' -> 
        printfn "%O" mem.[ptr]      
    |'>' -> 
        ptr <- ptr + 1
    |'<' ->
        ptr <- ptr - 1         
    |_ -> ()

[<EntryPoint>]
let main argv =
    let code = System.Console.ReadLine()
    String.iter interpret code
    0