// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine ());

void getThirdDigit ()
    {
        num = Math.Abs(num);
        if (num>=0 && num<100) 
        {
           Console.WriteLine("В числе нет третьей цифры."); 
        }
        else
        {
            while(num>999)
                 {
                     num = num/10; 
                 }
            int num1 = num % 10;
            Console.WriteLine($"Третья цифра в числе: {num1}"); 
        }
    }

getThirdDigit();
