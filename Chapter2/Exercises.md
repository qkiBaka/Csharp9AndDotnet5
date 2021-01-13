# Exercise 2.1
**What type would you choose for the following "numbers"?**
- A person's telephone number  
String
- A person's height  
Depends, in metric in cm then int. In meters float  

- A person's age  
Int  

- A person's salary  
decimal  

- A book's ISBN  
13 digit number with '-', I would use long and when outputted format it properly  

- A book's price  
decimal  

- A book's shipping weight  
float  

- A country's population  
according to https://www.infoplease.com/world/population/worlds-most-populous-countries max is China with 1_402_756_160  
so in theory int should be enough.. but this number grows over time so better would be  
uint or long

- The number of stars in the universe  
double  

- The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business)  
different sources say different number but there's areound 5 milion companies, not sure how many of those are small to medium, but let's assume that all which gives around 250 000 000 000  
long

# Exercise 2.2
For given number types display how many bates do they occupy in memory and their min and max values  
Goto code\Exercise02