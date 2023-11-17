let calculate n =
    let rec loop sum multiple1 =
        if multiple1 > n then
            sum
        else
            loop (sum + multiple1) (multiple1 + 3)

    loop 0 3


let result = calculate 45
printfn "Result: %d" result
