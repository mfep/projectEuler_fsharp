open System

let allDivisors (n: int64) =
  let lim = n / 2L
  [2L..lim] |> List.filter (fun x -> n % x = 0L)

let isPrime (n:int64) =
  allDivisors n = List.empty

let maxPrimeDivisors (n:int64) =
  let lim = int64(Math.Sqrt(float(n)))
  [2L..lim] |> List.filter (fun x -> n % x = 0L && isPrime x) |> List.max

maxPrimeDivisors 600851475143L