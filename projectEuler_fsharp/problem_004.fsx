let isPalindrome (n : int32) =
  let n_str = n.ToString()
  let iter =
    if n_str.Length % 2 = 0 then n_str.Length / 2
    else n_str.Length / 2 + 1
  let rec loop = function
    | i when i = iter -> true
    | i when n_str.Chars i <> n_str.Chars (n_str.Length - i - 1) -> false
    | i -> loop (i+1)
  loop 0
    
let pairs =
  seq {
    for a in 1000 .. -1 .. 900 do
      for b in 1000 .. -1 .. 900 do
        if a >= b then yield (a,b)
  }

let solve =
  let rec loop (sek : seq<int32 * int32>) = 
    let pair = Seq.head sek
    //printfn "%A" pair
    if fst(pair) * snd(pair) |> isPalindrome then pair
    else loop (Seq.skip 1 sek)
  loop pairs

let solution = solve
fst solution * snd solution