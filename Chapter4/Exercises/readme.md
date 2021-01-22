# Chapter 4 Exercises

## 1
1. What does the C# keyword void mean?
Means that method wont return anything

2. What are some differences between imperative and functional programming styles?
   [Wikipedia](https://en.wikipedia.org/wiki/Comparison_of_programming_paradigms)
   [MSdocs](https://docs.microsoft.com/en-us/dotnet/standard/linq/functional-vs-imperative-programming#:~:text=With an imperative approach, a,of functions to be executed.)
   Imperative: Contains instructions how to perform tasks, state changes (inside vars change), order of execution is important, flow controlled by loops, conditionals and method calls
   Functional: Declarative approach, describes what is desired and what transformations are required, state doesnt change (immutability) - if something changes its copied to new value

3. In Visual Studio Code, what is the difference between pressing F5, Ctrl or Cmd + F5, Shift + F5, and Ctrl or Cmd + Shift + F5?
   F5 - Run with debugging
   Ctrl + F5 - Run without debugging
   Shift + F5 - Stop debugging
   Ctrl + Shift + F5 - Restart debugging

4. Where does the Trace.WriteLine method write its output to?
   It can write to any trace listener. It's type that can be configured to wirte output anywhere
   There's DefaultTraceListener class and it is automatically configured to write to Debug Console but it can be set differently

5. What are the five trace levels?
   **0** - Off - Outputs nothing  
   **1** - Error - Outputs only errors
   **2** - Warning - Outputs Errors and Warnings
   **3** - Info - Output errors,warnings and information
   **4** - Verbose - Outputs all levels

6. What is the difference between Debug and Trace?
   Debug adds log only during development
   Trace adds logs during developement and runtime

7. When writing a unit test, what are the three As?
   Arrange, Act, Assert

8. When writing a unit test using xUnit, what attribute must you decorate the test methods with?
   [Fact]

9. What dotnet command executes xUnit tests?
    dotnet test

10. What is TDD?
    It's short for Test-driven Development, it's a principle that says devs should first create unit tests before writing code itself.

## 2 
Create workspace with 3 projects: class library with method calcularing PrimeFactors(int) returns string showing prime factors; unit test; console app. Max value = 1000;