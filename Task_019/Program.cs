// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int x = new Random().Next(-100, 101);
int y = new Random().Next(-100, 101);
Console.Write($"Координаты ({x}, {y})");
if ((x>0) && (y>0)) Console.WriteLine(" находятся в первой четверти");
if ((x<0) && (y>0)) Console.WriteLine(" находятся во второй четверти");
if ((x<0) && (y<0)) Console.WriteLine(" находятся в третьей четверти");
if ((x>0) && (y<0)) Console.WriteLine(" находятся в первой четверти");
if ((x==0) || (y==0)) Console.WriteLine(" находятся на осях");