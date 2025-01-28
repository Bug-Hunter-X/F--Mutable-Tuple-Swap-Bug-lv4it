let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 20 as expected

let tupleSwap (x,y) = (y,x)
let a = 10
let b = 20
let (c,d) = tupleSwap (a,b)
printfn "%d %d" c d // This will also print 20 10 as expected

//however if we do this:

let mutable x1 = 10
let mutable y1 = 20

let mutable z = (x1,y1)

let swapTuple z = 
    let (a,b) = z
    z <- (b,a)

swapTuple z
printfn "%A" z // This will print (20,20) unexpectedly, because the tuple is copied by value, not by reference

// the values are copied, and the swap operation is performed on the copy
// rather than on the original variables

// To correct this, use references:
let mutable x2 = ref 10
let mutable y2 = ref 20

let swapRef x y = 
    let temp = !x
    x := !y
    y := temp

swapRef x2 y2
printfn "%d %d" !x2 !y2 // prints 20 10 as expected