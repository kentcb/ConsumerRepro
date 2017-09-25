# A Repro for VS/VS4M/NuGet/RxUI Consumer Scenarios

## Windows

1. Open in VS on Windows and build the solution
2. Open terminal and `cd` to the root of the repro
3. `.\.nuget\NuGet.exe install xunit.runner.console -OutputDirectory .\packages\`
4. `.\packages\xunit.runner.console.2.2.0\tools\xunit.console.exe .\Repro\UnitTests\bin\Debug\net46\UnitTests.dll`

Observe that the two tests correctly execute.

## Mac

1. Open up the _UnitTests.csproj_ file and change the `TargetFrameworks` to just `Xamarin.Mac20` (see questions below)
2. Open in VS4M and build the solution

Observe that we cannot even build yet.

## Questions/Problems
 - I have not a clue why I need the assembly redirects in the UnitTest project. Built binaries are referencing unexpected version, so without them things are messed up.
 - why doesn't VS4M build _all_ target frameworks? It only seems to build the first, which differs to VS behavior