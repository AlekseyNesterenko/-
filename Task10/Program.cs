//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите целое трехзначное число: ");

void SecondDigit ()
    {
        int DigitAbs;
        bool DigitParse = int.TryParse(Console.ReadLine (), out DigitAbs);
        if (DigitParse==true)
        {
            DigitAbs= Math.Abs(DigitAbs);
            if(DigitAbs<100 | DigitAbs>=1000) 
            {
             Console.WriteLine("Нужно ввести целое трехначное число!");
            }
            else
            {
            int Digit = DigitAbs/10;
            int SecDigit = Digit%10;
            Console.Write($"Вторая цифра числа: {SecDigit}");
            }
        }
        else
        {
            Console.WriteLine("Нужно ввести целое трехначное число!");
        }
    }
   

SecondDigit();
