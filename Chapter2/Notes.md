**Naming conventions:**

https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines

Shortly:  
Camel case - cost, orderDetail, dateOfBirth - Local variables, private fields.
Title case -String, Int32, Cost, DateOfBirth, Run - Types, non-private fields, and other members like methods.

## Text

**Char**  
Use '' in literal declaration

**Strings:**  
Use "" in literal declaration

Verbatim:  
use @ at beginning:  
for example: string filePath = @"C:\televisions\sony\bravia.txt";  

## Numbers
**Int16 (aka short)** signed int with 16bits
**Int32 (aka int)** signed int with 32bits
**Int64 (aka long)** signed int with 64bits
**Single (aka float)** floating point 32 bit
**Double (aka double)** floating point 64 bit
**Decimal (aka decimal)** floating point 128 bit

Use  
**int** for whole numbers  
**double** for real numbers that will not be compared to other values.   
**decimal** for money, CAD drawings, general engineering, and wherever the accuracy of a real number is important.

Double - for speed; Decimal - for precision

## Floating point types:
Store numbers as exponent and mantissa and may have round errors
Binary:  
https://csharpindepth.com/Articles/FloatingPoint  
**double** 
Double precision
64 bits
Sign (s, 1 bit),Stored exponent (e, 11 bits),Mantissa (m, 52 bits)
**float** 
32 bits
Sign (s, 1 bit),Stored exponent (e, 8 bits),Mantissa (m, 23 bits)

Example:  
64bit double:  
0100000001000111001101101101001001001000010101110011000100100011  
Sign: 0
Exponent: 10000000100 binary = 1028 decimal  
Mantissa: 0111001101101101001001001000010101110011000100100011  

(-1)^0 x 1.0111001101101101001001001000010101110011000100100011 (binary) x **2**^(1028-1023)  

**decimal**  
https://csharpindepth.com/Articles/Decimal  
128bits  
uses base10 math
(-1)^0 x 1.0111001101101101001001001000010101110011000100100011 (binary) x **10**^(1028-1023)

## Other types:
**object** 
assigned at runtime 
dynamic type - messier code, worse performance = don't use  

**dynamic**
assigned at runtime 
dynamic type - messier code, even worse performance than above = don't use  

**var**
assigned at compilation; local variables
static type - less readable in code, performance should be same


## Formatting  
https://docs.microsoft.com/en-us/dotnet/standard/base-types/formatting-types