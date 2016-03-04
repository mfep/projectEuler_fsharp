let square x = x * x
let squareOfSum = [1..100] |> List.sum |> square
let sumOfSquares = [1..100] |> List.map square |> List.sum
squareOfSum - sumOfSquares