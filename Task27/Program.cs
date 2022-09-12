// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int getNumberDigitsSum(int number)
{
       int sum=0;
       int tempNumber = Math.Abs(number);
        while (tempNumber > 0)
        {
            int lastDigit = tempNumber % 10;
            sum = sum + lastDigit;
            tempNumber = tempNumber / 10;
        }
    return sum;
}

while (true)
{
    try
    {
        Console.Write("Введите число: ");
        int a = int.Parse(Console.ReadLine());
        int digitsSum = getNumberDigitsSum(a);
        Console.WriteLine($"Сумма цифр в числе: {digitsSum}");
        break;
    }
    catch (Exception)
    {
        Console.WriteLine($"Входное значение имеет неверный формат");
 
    }
}