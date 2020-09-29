# dot-net-tdd
Sample Katas written in Test Driven Development

## Example 1: Create a fully implemented List utilizing Test Driven Development.
Implement the following methods:
```
public object Get(int index);
public object Remove(int index);
public object Add();
public object Insert(int index);
public int Size();
```
## Example 2: Get prime factors of a number in sorted order.
Write a class named “PrimeFactors” that has one method: generate.
```
List<Integer> Generate(Integer number);
```
That list contains the prime factors in numerical sequence.  Remember: 1 is not a prime number!

Sample Outputs:
```
Generate(1) returns []
```
```
Generate(12) returns [2,2,3]
12 = 2 * 2 * 3
```

## Example 3: Implement a String Calculator
Source: https://osherove.com/tdd-kata-1

### Create a simple String calculator with a method signature:
```
int Add(string numbers)
```
The method can take up to two numbers, separated by commas, and will return their sum. 
for example `“”` or `“1”` or `“1,2”` as inputs.
(for an empty string it will return 0) 

#### Hints:
* Start with the simplest test case of an empty string and move to one and two numbers
* Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
* Remember to refactor after each passing test

### Allow the Add method to handle an unknown amount of numbers
Allow the Add method to handle new lines between numbers (instead of commas).
the following input is ok: “1\n2,3” (will equal 6)
the following input is NOT ok: “1,\n” (not need to prove it - just clarifying)

### Support different delimiters
to change a delimiter, the beginning of the string will contain a separate line that looks like this: “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the default delimiter is ‘;’ .
the first line is optional. all existing scenarios should still be supported

### Calling Add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed. 
if there are multiple negatives, show all of them in the exception message.

STOP HERE if you are a beginner. Continue if you can finish the steps so far in less than 30 minutes.

### Numbers bigger than 1000 should be ignored, so adding 2 + 1001 = 2

### Delimiters can be of any length with the following format: 
```
“//[delimiter]\n” for example: “//[***]\n1***2***3” should return 6
```

### Allow multiple delimiters like this: 
```
“//[delim1][delim2]\n” for example “//[*][%]\n1*2%3” should return 6.
```
Make sure you can also handle multiple delimiters with length longer than one char

## Other Examples
https://codingdojo.org/kata/
