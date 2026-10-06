# SchoolSystem — Task 1

A beginner C# console application with variables and arrays.

## Add to your repository

Extract the ZIP into the root of your repository. Keep the project at
`CSharp_tasks/SchoolSystem`.

## Run

This project targets .NET 10. Install the .NET 10 SDK or use a Visual Studio
version that supports it.

From the root of your repository:

```bash
cd CSharp_tasks/SchoolSystem
dotnet run
```

In Visual Studio, open `SchoolSystem.csproj` and press Ctrl + F5.
If your course uses a different supported .NET version, create a Console App
named SchoolSystem with that version and replace its entire Program.cs with
the included Program.cs.

## What the code does

1. Stores and prints one student's name, age, grade, average, gender, and active status.
2. Prints four names from the students array and its Length.
3. Prints the first and last names, displays the array before changing it,
   changes students[2] from Omar to Khaled, then displays it again.

The array starts at index 0. The last element is at students.Length - 1.
The for loops print one array element per iteration.

## Data types

| Variable | Type |
| --- | --- |
| studentName | string |
| studentAge | int |
| studentGrade | int |
| studentAverage | double |
| studentGender | char |
| isStudentActive | bool |
| students | string[] |

## Validation

The code was reviewed against the assignment requirements. It was not compiled
or executed in the preparation environment because the .NET SDK was unavailable.
