# Chapter 3 Exercises

## Exercise 1

1. What happens when you divide an int variable by 0?

System.DividebyZeroException will be thrown at runtime

1. What happens when you divide a double variable by 0?

Compiles, runs, return Infinity

[Link](https://stackoverflow.com/questions/4609698/inconsistency-in-divide-by-zero-behavior-between-different-value-types) to explanation. Basicly returned value in case 1) is int which doesn't have Infinity represenatation, but in case 2) double has it

3. What happens when you overflow an int variable, that is, set it to a value beyond its range?

Basicaly it's situation when all bits in that var are set to 1 and when you add one more they all will be set to 0. So it's value will change from highest to lowest. If you substract then it's other way around. 


4. What is the difference between x = y++; and x = ++y;?

x = y++ - First y is assigned to x and then y is incremented by one
x = ++y - First y is incremented by one and then assigned to x

It's better not to mix increments/decrements and assignments, it's confusing


5. What is the difference between break, continue, and return when used inside a loop statement?

**break** - terminates loop execution, basicaly you go out of loop statement
**continue** - skips this loop iteration and goes to next one
**return** - gets execution out of calling method, may return value

7. What are the three parts of a for statement and which of them are required?

[Link](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for)

for (initializer; condition; iterator) {}
All those parts are optional
**initializer** - happens once before entering loop
**condition** - boolean expression, evaluated **before** every loop iteration
**iterator** - happens after each iteration


8. What is the difference between the = and == operators?

Classic one,
The '=' is assignment operator, for example x = y; It will assign y (executed value,reference) to the x variable.
The '==' operator will return boolean value if left and right side are 'equal', altough there are whole articles about equality of different things

9. Does the following statement compile? for ( ; true; ) ;

Sure but it will be endless for loop

10. What does the underscore _ represent in a switch expression?

**default** case

11. What interface must an object implement to be enumerated over by using the foreach statement?

IEnumerable and IEnumerable\<T\>

Type must have method GetEnumerator that return object
Returned object must have property named Current and method named MoveNext
MoveNext method must return true if there are more items to enumerate through or false if there are no more

## Exercise 2

What will happen?

```int max = 500;
for (byte i = 0; i < max; i++)
{
  WriteLine(i);
}
```

Byte max value is 255 (0-255, 2^8-1) and condition is to stop at 500 which will never happen as byte will overflow and continue from 0. This will endlessly execute. 

What code could you add (don't change any of the preceding code) to warn us about the problem?

Place this code in  checked{} block.

## Exercise 3

Write FizzBuzz:
Players take turns to count incrementally, replacing any number divisible by three with the word fizz, any number divisible by five with the word buzz, and any number divisible by both with fizzbuzz.