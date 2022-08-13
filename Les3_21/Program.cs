//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
//                                                        __________________________
// формула d12(расстояние между первой и второй точками)=V(x2−x1)2+(y2−y1)2+(z2−z1)2

Console.WriteLine("введите координату X1");
var x1String = Console.ReadLine();
int x1 = int.Parse(x1String!);

Console.WriteLine("введите координату Y1");
var y1String = Console.ReadLine();
int y1 = int.Parse(y1String!);

Console.WriteLine("введите координату Z1");
var z1String = Console.ReadLine();
int z1 = int.Parse(z1String!);

Console.WriteLine("введите координату X2");
var x2String = Console.ReadLine();
int x2 = int.Parse(x2String!);

Console.WriteLine("введите координату Y2");
var y2String = Console.ReadLine();
int y2 = int.Parse(y2String!);

Console.WriteLine("введите координату Z2");
var z2String = Console.ReadLine();
int z2 = int.Parse(z2String!);

var kor = Math.Sqrt((x2 - x1)*(x2 - x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));

Console.WriteLine("Расстояние между двумя точками в 3D пространстве: " + kor);