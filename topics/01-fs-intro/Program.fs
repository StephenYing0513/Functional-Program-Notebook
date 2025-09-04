// F# Hello World Program
// This is a simple console application to get started with F#

open System

// Define a simple function
let greet name =
    $"Hello, {name}! Welcome to F# programming!"

// Main program entry point
[<EntryPoint>]
let main args =
    printfn "=== F# Hello World ==="
    printfn ""
    
    // Simple greeting
    printfn "Hello, World!"
    printfn ""
    
    // Interactive greeting
    printf "What's your name? "
    let name = Console.ReadLine()
    let message = greet name
    printfn "%s" message
    printfn ""
    
    // Show some F# features
    printfn "Let's explore some F# features:"
    
    // List and map
    let numbers = [1; 2; 3; 4; 5]
    let doubled = List.map (fun x -> x * 2) numbers
    printfn "Original numbers: %A" numbers
    printfn "Doubled numbers: %A" doubled
    
    // Pattern matching
    let describeNumber n =
        match n with
        | 0 -> "zero"
        | 1 -> "one"
        | 2 -> "two"
        | n when n < 10 -> "single digit"
        | _ -> "big number"
    
    printfn "Number 3 is: %s" (describeNumber 3)
    printfn "Number 15 is: %s" (describeNumber 15)
    
    printfn ""
    printfn "Press any key to exit..."
    Console.ReadKey() |> ignore
    
    0 // Return success code
