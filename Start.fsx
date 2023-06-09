#load "Common.fsx"

open Common
open DotNetEnv
open System.IO

let value = Env.GetString("key")

printfn $"-->{value}"