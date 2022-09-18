//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

void FindIntersectionPoint(float k1, float b1, float k2, float b2)
{
    if(k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают.");
    }
    else if(k1 == k2)
    {
        Console.WriteLine("Прямые параллельны."); 
    }
    else
    {
        float x = (b2 - b1)/(k1 - k2);
        float y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых y1 и y2 = ({x}; {y})");
    }
}



Console.WriteLine("Дано уравнение прямой y1 = Ax1 + B.");
Console.Write("Введите коэффициент А:");
float k1 = float.Parse(Console.ReadLine());
Console.Write("Введите коэффициент B:");
float b1 = float.Parse(Console.ReadLine());

Console.WriteLine("Дано уравнение прямой y2 = Cx2 + D.");
Console.Write("Введите коэффициент C:");
float k2 = float.Parse(Console.ReadLine());
Console.Write("Введите коэффициент D:");
float b2 = float.Parse(Console.ReadLine());

FindIntersectionPoint(k1, b1, k2, b2);