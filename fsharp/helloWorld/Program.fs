open System

let hello_worlds n = 
    for i in 1 .. n do
        Console.WriteLine "Hello World" 

let add a b = a + b;

[<EntryPoint>]
let main argv = 
    let tokens_n = Console.ReadLine();
    let n = Convert.ToInt32(tokens_n);
    hello_worlds n;
    0 // return an integer exit code

