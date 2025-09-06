open System

let employees =
    [ "neal"; "s"; "stu"; "j"; "rich"; "bob"; "aiden"; "j"
      "ethan"; "liam"; "mason"; "noah"; "lucas"; "jacob"; "jayden"; "jack" ]

let capitalize (s: string) =
    if String.IsNullOrEmpty s then s
    else s.Substring(0, 1).ToUpperInvariant() + s.Substring(1)

let cleanNames (names: string list) : string =
    names
    |> List.filter (fun n -> n.Length > 1)   // drop 1-letter names
    |> List.map capitalize                   // capitalize first letter
    |> String.concat ", "                    // join safely (handles empty list)

let cleanNames_lec (names : List<string>) =
    names 
    |> List.filter (fun name -> name.Length > 1) // 1)
    |> List.map (fun s -> s.[0..0].ToUpper() + s.[1..] ) // 2)
    |> List.reduce (fun acc name -> acc + "," + name) // 3)  
    // Or use List.fold (fun acc n -> acc + ", " + n) "" names

[<EntryPoint>]
let main _ =
    printfn "%s" (cleanNames employees)
    0