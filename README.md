# CalculatorNumberAndLetter

this program will determine how many numbers and letters are present in the text entered by the user

I have used some methods and foreach loop.

`Main method`
```cs
  static void Main(string[] args)
  {
      Presentation();
  }
```

`Presentation method`
![](https://github.com/Javohir0102/CalculatorNumberAndLetter/blob/master/CalculatorNumberAndLetter/Asset/Presentation().png)

`Service class`
![](https://github.com/Javohir0102/CalculatorNumberAndLetter/blob/master/CalculatorNumberAndLetter/Asset/ServicesClass.png)

`Foreach loop`
```cs
foreach (char c in str)
{
    if (char.IsDigit(c))
    {
        numberOfDigits++;
    }
    else if (char.IsLetter(c))
    {
        numberOfLetters++;
    }
    else if (!char.IsLetterOrDigit(c))
    {
        numberOfCharacters++;
    }
}
```

I have used __char.IsDigit()__, __char.IsLetter()__ and __char.IsLetterOrDigit()__.

- __IsDigit__
  - It is for calculate only digits.
- __IsLetter__
  - This method for counting letters
- __IsLetterOrDigit__
  - It is for calculating all characters without digits and letters.
 
`Result to GIF:`

![](https://github.com/Javohir0102/CalculatorNumberAndLetter/blob/master/CalculatorNumberAndLetter/Images/Result.gif)

You are now version 1.
