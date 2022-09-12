// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов.

void GetPowerOfNumber (int a, int b)
{
    int powerOfNum = a;
    if (a !=0 && b == 0)
    {
      powerOfNum = 1;
      Console.WriteLine($"{a} в степни {b} = {powerOfNum}");
    } 
    
    if (b>0)
    {
        for (int i =1; i<b; i++)
        {
          powerOfNum = powerOfNum*a;
        }
        Console.WriteLine($"{a} в степни {b} = {powerOfNum}");
    }

    if (b<0)
    {
       Console.WriteLine("Степень числа должна быть натуральным числом!");  
    }
}

Console.Write("Основание: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());

GetPowerOfNumber(numberA,numberB);


