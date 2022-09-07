// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число дня недели: ");
int number = int.Parse(Console.ReadLine ());
void getDayOfWeek ()
    {
        if (number==7 | number== 6) Console.WriteLine("Ура, выходной!");
        else if (number>0 && number<6) Console.WriteLine("Нужно работать");
        else Console.WriteLine("Это не день недели");   
    }
   
getDayOfWeek();
