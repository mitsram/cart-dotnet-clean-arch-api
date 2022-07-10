# Notes

## Setup Project
`dotnet new sln -o CartApi`
`dotnet new webapi -o Cart.Api`
`dotnet new classlib -o Cart.Contracts`
`dotnet new classlib -o Cart.Infrastructure`
`dotnet new classlib -o Cart.Application`
`dotnet new classlib -o Cart.Domain`
`dotnet sln add (ls -r **/*.csproj` || `dotnet sln add Cart.Api/*.csproj`
`dotnet add ./Cart.Api reference ./Cart.Contracts ./Cart.Application`
`dotnet add ./Cart.Infrastructure reference ./Cart.Application`
`dotnet add ./Cart.Application reference ./Cart.Domain`
`dotnet add ./Cart.Api reference ./Cart.Infrastructure`

## Run Project
`dotnet run --project ./Cart.Api`
