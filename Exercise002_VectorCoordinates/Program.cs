// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] coordinateA = new int [3];
Console.WriteLine("Введите координату Х первой точки: ");
coordinateA[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
coordinateA[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
coordinateA[2] = Convert.ToInt32(Console.ReadLine());

int[] coordinateB = new int [3];
Console.WriteLine("Введите координату Х второй точки: ");
coordinateB[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
coordinateB[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки: ");
coordinateB[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(coordinateB[0] - coordinateA[0], 2) + Math.Pow(coordinateB[1] - coordinateA[1], 2) + Math.Pow(coordinateB[2] - coordinateA[2], 2)),2));