// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число дня недели: ");
int x = int.Parse(Console.ReadLine ());
void DayOfWeek ()
    {
        
        if (x==7 | x== 6) Console.WriteLine("Ура, выходной!");
        else if (x>0 && x<6) Console.WriteLine("Нужно работать");
        else Console.WriteLine("Это не день недели");
        
    }
   
DayOfWeek();

