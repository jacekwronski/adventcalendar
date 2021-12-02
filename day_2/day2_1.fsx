open System.IO

let filePath = "./day_2/input.txt"
let readLines filePath = File.ReadLines(filePath)

let calculateMove (move: string) = 
    match move.Split(" ").[0] with
    | "forward" -> (int(move.Split(" ").[1]), 0)
    | "down" -> (0, int(move.Split(" ").[1]))
    | "up" -> (0, -int(move.Split(" ").[1]))
    | _ -> (0, 0)

let calculateCoordinates (ch: int, cd: int) (h: int, d: int)  = (ch + h, cd + d)

let multiply (h: int, d: int) = h * d

filePath
|> readLines
|> Seq.map(fun x -> calculateMove(x))
|> Seq.reduce(fun x y -> calculateCoordinates x y)
|> multiply
|> printfn "%d"