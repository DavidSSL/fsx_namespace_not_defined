#r "nuget: DotNetEnv, 2.3.0"
open DotNetEnv
open System.IO

let envPath = Path.Combine(__SOURCE_DIRECTORY__ , ".env")
Env.Load(envPath)

let value = Env.GetString("key")

printfn $"==>{value}"