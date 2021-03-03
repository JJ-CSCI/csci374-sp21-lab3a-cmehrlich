module Assignment

// DO NOT MODIFY LEFT PART OF `LET` OPERATOR

// Define following distance unit transformations
let inchToMillimeter v =
    v * 25.4 // write your code here

let footToInch x =
    x * 12.0 // write your code here

let yardToFoot v =
    v * 3.0 // write your code here

let mileToYard mile =
    mile * 1760.0 // write your code here

(*
Use ONLY above functions and the forward pipe operator, `|>`,  to define the following unit transformation

Forward pipe operator passes the result of the left side to the function on the right side.
*)
let yardToMillimeter y =
    yardToFoot y |> footToInch |> inchToMillimeter // write your code here

// Define the curried function `divBy1000` that has the signature `float -> float -> float`
let divBy1000 =
     fun (x:float) ->x / 1000.0 // write your code here

(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)
let millimeterToMeter n =
    n |> divBy1000 // write your code here

let meterToKilometer =
    fun // write your code here

(*
Use above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)
let millimeterToKilometer =
    fun (x:float) -> x
    millimeterToMeter  >> meterToKilometer  // write your code here

let inchToMeter =
    fun (x:float) -> x
    inchToMillimeter >> millimeterToMeter // write your code here

let yardToKilometer =
    fun (x:float)->x
    yardToMillimeter >> millimeterToMeter >> divBy1000 // write your code here

let mileToMeter =
    fun x->x // write your code here


// Define following weight unit transformations
let ounceToGram v =
    0.0 // write your code here

let poundToOunce p =
    0.0 // write your code here

let shortTonToPound t =
    0.0 // write your code here


(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)

let gramToKilogram g =
    0.0 // write your code here

(*
Use ONLY above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)

let gramToMetricTon =
    fun (x:float) -> x
    divBy1000 >> divBy1000 // write your code here

let poundToKilogram =
    fun (x:float) -> x
    poundToOunce >> ounceToGram >> gramToKilogram // write your code here

let shortTonToMetricTon =
    fun x->x // write your code here
