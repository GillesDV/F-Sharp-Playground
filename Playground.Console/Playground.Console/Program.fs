// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    let magicNumber = 123
    let pi = 3.14
    let name = "Gilles"
    let veryTrue = true
    let veryFalse = not veryTrue

    let wordLength = String.length ("hello" + "world")

    let twoToFive = [2;3;4;5]
    let oneToFive = 1 :: twoToFive //cannot change existing variables, thus must create new constant to add value to array
    let zeroToFive = [0;1] @ twoToFive

    let squareFunction x = x * x
    let fiveSquared = squareFunction 5
    printfn "5² = %i" fiveSquared

    //Console.ReadLine // no braces -> delegate 
    printfn "Please enter a value:"
    let input = Console.ReadLine() // braces -> actually execue the function
    printfn "You wrote: %s" input

    //-----------------------------------------------------

    let addFunction x y = 
        x + y
    printfn "1 + 2 = %i" (addFunction 1 2)

    let allEvenNumbers list = 
        let isEven x = x%2 = 0
        List.filter isEven list
    let evenNumbers = allEvenNumbers oneToFive
    printfn "even numbers %A" evenNumbers
    
    let sumOfSquares100 = 
        List.sum (List.map squareFunction [1..100])
    // pipe operators = use the output of one function for the input for the next
    let sumOfSquares100Pipes = 
        [1..100] |> List.map squareFunction |> List.sum
    printfn "Sum of squares 100: %i and %i" sumOfSquares100 sumOfSquares100Pipes
   
    // In F# returns are implicit -- no "return" needed. A function always
    // returns the value of the last expression used.

    //-----------------------------------------------------

    //basically a switch/case
    let patternMatch = 
        let x = "a"
        match x with 
        | "a" -> printfn "x = a"
        | "b" -> printfn "x = b"
        | _ -> printfn "x = something else"

    // ~ nullable wrappers
    let validValue = Some(99)
    let invalidValue = None
    let optionPatternMatch input = 
        match input with
        | Some i -> printfn "input is an int=%d" i
        | None -> printfn "input is missing"
    
    optionPatternMatch validValue
    optionPatternMatch invalidValue

    //-----------------------------------------------------

    // Tuple types are pairs, triples, etc. Tuples use commas.
    let twoTuple = 1,2
    let threeTuple = "a",2,true

    printfn "Printing an int %i, a float %f, a bool %b" 1 2.0 true
    printfn "A string %s, and something generic %A" "hello" [1;2;3;4]


    Console.ReadLine()
    0 // return an integer exit code