Implementation of the famous Kata [FizzBuzz](https://codingdojo.org/kata/FizzBuzz/)
This is used to support a presentation of UnitTesting using NUnit, NSubstitute

# Prerequisite
[NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
visual studio 2022

# Get started
git clone https://github.com/AlexisGoument/FizzBuzz.git

# Kata steps

0. Project basis: FizzBuzz class with method CountTo100
1. Test project with nuget NUnit
2. Implement class FizzBuzz + Test (DummyClass allows to test method IsMultiple3 without public accessor)
3. Bonus:	 
	3.1. Add a repository Database.GetNumbers() throwing an exception
	3.2. Add a private property FizzBuzz._database (passed in constructor)
	3.3. Add a method string[] FizzBuzz.TransformFromDatabase() calling Database.GetNumbers()
	3.4. Test it (with nuget [NSubstitute](https://nsubstitute.github.io/))
