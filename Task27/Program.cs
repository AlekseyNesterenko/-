// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int getSumNumberDigits(int number)
{
       int sum=0;
       int count = 0;
       int tempNumber = Math.Abs(number);
        while (tempNumber > 0)
        {
            int lastDigit = tempNumber % 10;
            sum = sum + lastDigit;
            count++;
        }
    return sum;
}


Console.WriteLine("Введите число: ");
try
{
    int a = int.Parse(Console.ReadLine());
    int digitsSum = getSumNumberDigits(a);
    Console.WriteLine($"Сумма цифр в числе: {digitsSum}");
}
catch (Exception)
{
    Console.WriteLine($"Входное значение имеет неверный формат");
}