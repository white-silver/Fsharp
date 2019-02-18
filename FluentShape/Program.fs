// Learn more about F# at http://fsharp.org

open System

type FluentShape = {
    label : string;
    color : string;
    onClick : FluentShape -> FluentShape // a function type
    }

let defaultShape = 
    {label = ""; color=""; onClick = fun shape -> shape}
let click shape = 
    shape.onClick shape
let display shape = 
    printfn "My label=%s and my color=%s" shape.label shape.color
    shape

let setLabel label shape = 
    {shape with FluentShape.label = label}
let setColor color shape = 
    {shape with FluentShape.color = color}
let appendClickAction action shape = 
    {shape with FluentShape.onClick = shape.onClick >> action}

let setRedBox = setColor "red" >> setLabel "box"

let setBlueBox = setRedBox >>  setColor "blue"

let changeColorOnClick color = appendClickAction
