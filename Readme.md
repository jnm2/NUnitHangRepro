See https://github.com/nunit/nunit/issues/3295.

To reproduce, method 1: type `dotnet run --project HangRepro` in the repo root.

To reproduce, method 2: open HangRepro.sln in Visual Studio and press F5.

You should expect to see live output similar to the following (9-13% is a common fluctuation on the same machine):

```
15 repros/100 tries, 15.0%
```

On the first run only, this will happen first:

```
Downloading https://github.com/nunit/nunit-console/releases/download/v3.10/NUnit.ConsoleRunner.3.10.0.nupkg to C:\Users\Joseph\Source\Repos\jnm2\NUnitHangRepro\HangRepro\bin\Debug\net472\tools\NUnit.ConsoleRunner...
Download complete.
```
