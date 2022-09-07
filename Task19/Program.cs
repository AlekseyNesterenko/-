// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine ();

void checkForPalindrome ()
    {
        int fiveDigitsNum;
        bool numberParse = int.TryParse(number, out fiveDigitsNum);
        if (numberParse == true)
        {
            fiveDigitsNum = Math.Abs(fiveDigitsNum);
            if(fiveDigitsNum <= 10000 | fiveDigitsNum > 100000) 
            {
                Console.WriteLine("Нужно ввести целое пятизначное число!");
            }
            else
            {
                int a = fiveDigitsNum / 1000;                                 // получить первые две цирфы числа
                int b = fiveDigitsNum % 10 * 10 + fiveDigitsNum % 100 / 10;   // получить две последние цифры числа
                if (a == b)
                {
                    Console.WriteLine("Это палиндром!");
                }
                else
                {
                    Console.WriteLine("Число не является палиндромом!");
                }
            }
        }
        else
        {
            Console.WriteLine("Нужно ввести целое пятизначное число!");
        }
    }
   
checkForPalindrome();