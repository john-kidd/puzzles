open System

let add a b = a + b;

[<EntryPoint>]
let main argv = 
    let a = Console.ReadLine() |> int
    let b = Console.ReadLine() |> int
    let c = add a b;
    printfn "%d" c;

    0 // return an integer exit code

