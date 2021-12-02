open System.IO

let filePath = "./day_2/input.txt"
let readLines filePath = File.ReadLines(filePath)

let calculateMove (move: string) = 
    match move.Split(" ").[0] with
    | "forward" -> (int(move.Split(" ").[1]), 0, 0)
    | "down" -> (0, 0, int(move.Split(" ").[1]))
    | "up" -> (0, 0, -int(move.Split(" ").[1]))
    | _ -> (0, 0, 0)

let calculateCoordinates (ch: int, cd: int, caim: int) (h: int, d: int, aim: int)  = 
    if h > 0 then (ch + h, cd + (caim * h), caim) else (ch, cd, caim + aim)

let multiply (h: int, d: int, c: int) = h * d

filePath
|> readLines
|> Seq.map(fun x -> calculateMove(x))
|> Seq.reduce(fun x y -> calculateCoordinates x y)
|> multiply
|> printfn "%d"