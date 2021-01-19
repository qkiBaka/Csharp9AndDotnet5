# Controlling Flow and Converting Types

Unary operators:  
increment ++ and decrement --  
Don't use those operators with assignment as it's confusing.

## Logical Operators

AND is &
OR is  |
XOR is ^

## Conditional logical operators

aka short-circuiting Boolean operators

AND is &&
OR is ||

Interesting stuff, if you calculate AND for example and you have one of the operands false the second operand wont be calulated.
For example:

ReturnsFalse() && ReturnsTrue() - here second function wont be executed at all - you have false at the end.

On one hand it is more efficient but if the 2nd function in that example would do some stuff in behind it could be hard to find a bug reading code.  
In other words [Side Effects](https://en.wikipedia.org/wiki/Side_effect_(computer_science)) may not happen as expected.

## Other operators

nameof() returns string with short name of variable, type or member  
sizeof() returns size in bytes

the dot in for example dog.walk() is member access operator

## Pattern matching

Interesting stuff:

```object o = "4";
int j = 4;
if (o is int i)
{
  WriteLine($"{i} x {j} = {i * j}");
}
else
{
  WriteLine("o is not an int so it cannot multiply!");
}
```

It's an IF that also checks type of variable, here the else will be executed as o is string  

Switch also has pattern maching

## Casting

You can assign values like int to float without problem but if you want do otherwise you have to cast because there will be info lost, casting for example:
long e = someNumberHere
int d = (int)e

## Converting

System.Convert has methods to properly convert (round etc)

**Rounding rules:**
Works as expected tf decimal point is below .5 rounds down if above .5 round up.
Crazy stuff happens if it is exactly .5
If **non-decimal** part: 
odd -> round up
even -> round down

example: ToInt(9.5) is 10 ; ToInt(10.5) is 10
It is known as **Banker's Rounding**