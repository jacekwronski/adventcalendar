open System.IO

let filePath = "./day_1/input.txt"
let readLines filePath = File.ReadLines(filePath)

filePath
|> readLines
|> Seq.map(fun x -> int(x))
|> Seq.windowed 3
|> Seq.pairwise
|> Seq.map(fun (x ,y) -> if (Seq.sum x) < (Seq.sum y) then 1 else 0)
|> Seq.sum
|> printfn "%d"
