open System
open System
let i = 1
let s = "Hello"
let tuple = s,i
let s2,i2 = tuple
let list = [s2]

let sumLengths strList = 
    List.sumBy String.length strList

// some "record" types
type Person = {FirstName:string; LastName:string; Dob:DateTime}
type Coord = {Lat:float; Long:float}

// some "union" (choice) types
type TimePeriod = Hour | Day | Week | Year
type Temperature = C of int | F of int
