// 17. Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.WriteLine("Введите координату точки по Х")ж
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки по Y")ж
int y = Convert.ToInt32(Console.ReadLine());
if (x >0 && y>0)
{
    Console.WriteLine ("Точка  находится в первой координатной четверти");
}