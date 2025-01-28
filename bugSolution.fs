let mutable x = ref 10
let mutable y = ref 20

let swap x y = 
    let temp = !x
    x := !y
    y := temp

swap x y
printfn "%d %d" !x !y //This will print 20 10 as expected

let tupleSwap (x,y) = (y,x)
let a = ref 10
let b = ref 20
let (c,d) = tupleSwap (!a,!b)
printfn "%d %d" !c !d // This will also print 20 10 as expected

//Now using references, it works as expected

let mutable x1 = ref 10
let mutable y1 = ref 20

let mutable z = (x1,y1)

let swapTuple z = 
    let (a,b) = z
    a := !b
    b := !a

swapTuple z
printfn "%A" z // This will print (20, 10) as expected because we are using references

//To change the original tuple, we need to modify the contents of the references
// rather than creating a copy and modifying the copy. 