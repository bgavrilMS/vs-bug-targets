# Bug in VS

Repros in 17.2.4 and in 17.3.0 Preview 2.0

## Description

In a test project that multi-targets .net core and .net fx, VS no longer respects 
the package structure and does not execute the targets file inside the package.

## Repro Steps

1. Clone this repo and build it
1. Run the test on netcoreapp 3.1 -> prints OK
1. Run the test on net48 -> you get an exception

Expected: the bin/debug/net48 folder should have a runtime subfolder just like bin/debug/netcoreapp3.1

This happens because the targets file inside https://www.nuget.org/packages/Microsoft.Identity.Client.NativeInterop do not execute.

Important note: 

1. If you use a console app instead of a test project this works fine.
1. If you build the test project via `msbuild` or `dotnet build` this works
1. If you edit the test project and remove the netcore tfm, this works