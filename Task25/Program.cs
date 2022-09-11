// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов.

int GetPowerOfNumber (int a, int b)
{
    int powerOfNum = a;
    if (a == 0 && b>0) powerOfNum = 0;
    if (a !=0 && b == 0) powerOfNum = 1;
    if (b>0)
    {
        for (int i =1; i<b; i++)
        {
          powerOfNum = powerOfNum*a;
        }
    }
    if (b<0)
    {
       Console.WriteLine("Степень числа должна быть натуральным числом!");  
    }
    return powerOfNum;
}

Console.Write("Input A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = GetPowerOfNumber(numberA,numberB);
Console.WriteLine($"{numberA} в степни {numberB} = {result}");

