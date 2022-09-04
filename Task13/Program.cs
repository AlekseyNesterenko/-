// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void DelSecDigit ()
    {
        Console.Write("Введите целое число: ");
        double num = int.Parse(Console.ReadLine ());
        if (x<100) 
        {
           Console.WriteLine("В числе нет третьей цифры."); 
        }
        else
        {
        int count = 0;
        while(x>0)
        {
        num = num/10; 
        count++;
        }
        }
       double DigitsCout = Math.Pow(10, count);
       double 
        
    }


DelSecDigit();
