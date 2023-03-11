// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] tochka = new int[6];
System.Console.WriteLine("введите x1: ");
tochka[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите x2: ");
tochka[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите y1: ");
tochka[2] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите y2: ");
tochka[3] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите z1: ");
tochka[4] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите z2: ");
tochka[5] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Sqrt(Math.Pow(tochka[1]-tochka[0],2)+Math.Pow(tochka[3]-tochka[2],2)+Math.Pow(tochka[5]-tochka[4],2)));