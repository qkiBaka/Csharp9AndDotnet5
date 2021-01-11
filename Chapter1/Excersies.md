 # Exercise 1.1
 **1. Why can a programmer use different languages, for example, C# and F#, to write applications that run on .NET?**
They implement different types of paradigm to programming, C# implements Object-Oriented (afaik, older, more used paradigm) vs F# that uses functional programming (again afaik newer aproach that suppose to be better in huge projects due to lack of data change inside entities). Answering question - programmer may use different languages depending on what he knows/like and depending on solution (people say it's easier to implement UI in OO for example)

 **2. What do you type at the prompt to create a console app?**  
 `dotnet new console`

**3. What do you type at the prompt to build and execute C# source code?**  
 `dotnet run`
 
**4. What is the Visual Studio Code keyboard shortcut to view Terminal?**  
``
Ctrl+`  
``

**5.Is Visual Studio 2019 better than Visual Studio Code?**  
Well currently VS Code is the most popular editor for code, can be installed on almost every OS and has extensions for almost every programming language. Visual Studio 2019 can build Windows desktop app with UWP though.  

**6. Is .NET Core better than .NET Framework?**
Yes, Core is cross-platform and is what MS goes hard in. Framework is Windows only and for existing apps using old technologies

**7. What is .NET Standard and why is it still important?**  
It's a specification for a set of APIs that .NET platform can implement to indicate what compatibility they have between other platforms:
- .NET Core
- .NET Framework
- Xamarin  

The higher standard is you can migrate solutions between platforms easier and more unified they are.

**8. What is the name of the entry point method of a .NET console application and how should it be declared?**  
Entry point method is Main() it should be delared as this:  
```
using System;
class Program
{
    static void Main(string[] args)
    {
        // Code here
    }
}
```

**9. Where would you look for help about a C# keyword?**  
https://docs.microsoft.com/, Go To Definition (F12), StackOverflow, Google

**10. Where would you look for solutions to common programming problems?**  
StackOverflow, Google