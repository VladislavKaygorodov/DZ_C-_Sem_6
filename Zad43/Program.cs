/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = y1 * x + x1, 
y = y2 * x + x2; 
значения x1, y1, x2 и y2 задаются пользователем.
x1 = 2, y1 = 5, x2 = 4, y2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите начальную точку первой прямой: ");
double startLineA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите конечную точку первой прямой: ");
double endLineA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите начальную точку второй прямой: ");
double startLineB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите конечную точку второй прямой: ");
double endLineB = Convert.ToDouble(Console.ReadLine());

double x1 = startLineA;
double y1 = endLineA;
double x2 = startLineB;
double y2 = endLineB; 

Console.WriteLine();
Console.WriteLine($"Система уравнений выглядит так: y={y1}x+{x1}");
Console.WriteLine($"                                y={y2}x+{x2}");
Console.WriteLine();
Console.WriteLine($"Из 1го ур-я выразим у и подставим найденое у во 2е ур-е: {y1}x+{x1}={y2}x+{x2}");

Console.WriteLine($"Перенесем слагаемое с переменной х из правой части в левую со сменой знака: -{y2}x+({y1}x+{x1})={x2}");
y1 = y1 - y2;
Console.WriteLine($"                                                                             {x1}{y1}x={x2}");

x1 *= -1;
Console.WriteLine($"Перенесем свободное слагаемое {startLineA} из левой части со сменой знака:             {y1}x={x1}+{x2}");

double tempX = x1 + x2;
double x = tempX / y1;
Console.WriteLine($"При делении обеих частей ур-я на множитель при Х получаем:                   x={x}");

Console.WriteLine($"Так как: y= {endLineA}x+{startLineA}");
Console.WriteLine($"То:      y= {endLineA}({x})+{startLineA}");

double tempY = endLineA * x;
double y = tempY + startLineA;
Console.WriteLine($"Получаем:y={y}");

Console.WriteLine($"Таким образом точкой пересечения являются точки [{x};{y}]");