//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите целое трехзначное число: ");
string number = Console.ReadLine ();
void getSecondDigit ()
    {
        int digitAbs;
        bool digitParse = int.TryParse(number, out digitAbs);
        if (digitParse==true)
        {
            digitAbs = Math.Abs(digitAbs);
            if(digitAbs<100 | digitAbs>=1000) 
            {
                Console.WriteLine("Нужно ввести целое трехначное число!");
            }
            else
            {
                int digit = digitAbs/10;
                int secDigit = digit%10;
                Console.Write($"Вторая цифра числа: {secDigit}");
            }
        }
        else
        {
            Console.WriteLine("Нужно ввести целое трехначное число!");
        }
    }
   
getSecondDigit();
