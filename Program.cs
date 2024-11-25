int objectselection;
double circlerad;
double pryamoW;
double pryamoH;
double TriangleOsn;
double TriangleH;

Console.Title = "SGK Math Calculator";

Console.WriteLine("Choise object type...");
Console.WriteLine("Circle - 1; Pryamougolnik - 2; Triangle - 3");

objectselection = Convert.ToInt32(Console.ReadLine());


switch (objectselection)
{
    case 1:
        Console.WriteLine("Введите радиус круга");
        circlerad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("S круга = " + Math.PI * Math.Pow(circlerad, 2));
        break;
    case 2:
        Console.WriteLine("Введите Длину прямоугольника");
        pryamoH = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите Ширину прямоугольника");
        pryamoW = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("S Прямоугольника = " + pryamoH * 2 + pryamoW * 2);
        break;
    case 3:
        Console.WriteLine("Введите Длину Основания Треугольника");
        TriangleOsn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите Высоту Треугольника");
        TriangleH = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("S Треугольника = " + (TriangleOsn * TriangleH) / 2);
        break;
}
Console.WriteLine("Программа завершится через 5 секунд.");
await(Task.Delay(5000));