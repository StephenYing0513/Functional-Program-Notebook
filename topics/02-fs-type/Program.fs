// For more information see https://aka.ms/fsharp-console-apps

// Basic Types
let aByte : byte = 255uy
let anInt : int = 42
let aFloat : float = 3.14
let aString : string = "hello"
let aChar : char = 'c'
let aBool : bool = true
let unitVal : unit = ()   // absence of value

// Compound Types
// 	•	Pros: lightweight, no definition needed.
// 	•	Cons: order can be confusing.
let aTuple : int * string = (1, "one")
let aList : int list = [1; 2; 3]

let tuple1 = (1, "hi", 3.5)
let first = fst (1,2)    // 1
let second = snd (1,2)   // 2

// Record Types
// 	•	Pros: named fields, easy to extend.
// 	•	Cons: need to define type first.
type Point3D = { X: float; Y: float; Z: float }

let p1 = { X = 1.0; Y = 2.0; Z = 3.0 }
let p2 = { p1 with Y = 5.0 }   // copy & update
let yVal = p1.Y

// Discriminated Unions
// 	•	Pros: named cases, can hold data.
// 	•	Cons: need to define type first.
type Shape =
    | Circle of radius: float
    | Rectangle of width: float * height: float
    | Point of Point3D
let area shape =
    match shape with
    | Circle r -> System.Math.PI * r * r
    | Rectangle (w, h) -> w * h
    | Point _ -> 0.0    
let myCircle = Circle 2.0
let myRect = Rectangle (3.0, 4.0)
let myPoint = Point p1
let circleArea = area myCircle
let rectArea = area myRect
let pointArea = area myPoint


