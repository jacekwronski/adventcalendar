open System.IO

let filePath = "./day_1/input.txt"
let readLines filePath = File.ReadLines(filePath)

filePath
|> readLines
|> Seq.map(fun x -> int(x))
|> Seq.pairwise
|> Seq.map(fun (x, y) -> if x < y then 1 else 0)
|> Seq.sum
|> printfn "%d"
