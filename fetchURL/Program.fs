// Learn more about F# at http://fsharp.org

open System.Net
open System
open System.IO

//Fetch the contents of a web page
let fetchURL callback url =
    let req = WebRequest.Create(Uri(url))
    use resp = req.GetResponse()
    use stream = resp.GetResponseStream()
    use reader = new IO.StreamReader(stream)
    callback reader url

let myCallback (reader:IO.StreamReader) url = 
    let html = reader.ReadToEnd()
    let html1000 = html.Substring(0,1000)
    printfn "Downloaded %s. First 1000 is %s" url html1000
    html

let google = 
    fetchURL myCallback "http://cosmicwhale.xyz"

let fetchURL2 = fetchURL myCallback

let sites = ["http://www.google.com";
             "http://www.bing.com";]

printfn "%A" (sites |> List.map fetchURL2)