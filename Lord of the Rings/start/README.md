# Lord of the Rings - Kata

## Description

The main goal of this kata is to refactor the code we have in order to get an easier to maintain code base.

## What we need

- [.NET Core 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- Visual Studio / Rider

## Requisites

- `Domain` classes and enums may change (in fact, they should)
- `Application` classes should not change, until step 4
- Tests in `TheseTestsShouldNotBeChanged.cs` should not be changed
- Tests in `SomeOfTheseTestsMayChange.cs` should be changed in steps 3 and 4

## What we are trying to solve

1. We have been asked to add a new race: dwarf. They have name, but the can't own The One Ring. Their strength will be 20. The current `Character.cs` class is quite messy and you have noticed that it breaks all SOLID principles. Refactor it, so you don't need to add more `if/switch` to the code.
2. Could you remove all `if` and `switch` statements?
3. The One Ring is just that: one. Try to refactor the code, in order to make sure there can't be more than one
4. How would you ensure an army is just built up on the same alignment?
