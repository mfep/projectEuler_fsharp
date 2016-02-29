(1,1)
    |> Seq.unfold (fun (a, b) -> Some( a, ( b, a + b )))
    |> Seq.takeWhile (fun n -> n <= 4000000)
    |> Seq.filter (fun n -> n%2=0)
    |> Seq.sum