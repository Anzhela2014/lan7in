// // // // Задание 1.1
// // // string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

// // // for (int i = days.Length - 1; i >= 0; i--)
// // // {
// // //     Console.WriteLine(days[i]);
// // // }
// // // Задание 1.2
// // double[] t = { 12.5, 8.1, -2.4, -5.0, 0.3, 4.7, -1.1 };

// // foreach (double x in t)
// // {
// //     Console.Write(x + " ");
// // }
// // Console.WriteLine();
// // Задание 2
// int[] p = { 120, 45, 300, 80, 15, 210 };
// int s = 0;
// int k = 0;
// foreach (int x in p)
// {
//     s = s + x;
//     if (x > 100)
//     {
//         k = k + 1;
//     }
// }
// double sr = (double)s / p.Length;
// Console.WriteLine("Сумма: " + s);
// Console.WriteLine("Среднее: " + sr);
// Console.WriteLine("Дороже 100: " + k);
// Задание 3
// int[] p = { 120, 45, 300, 80, 15, 210 };
// int min = p[0];
// int max = p[0];
// int ind = 0;
// for (int i = 0; i < p.Length; i++)
// {
//     if (p[i] < min)
//     {
//         min = p[i];
//     }
    
//     if (p[i] > max)
//     {
//         max = p[i];
//         ind = i;
//     }
// }
// Console.WriteLine("Минимум: " + min);
// Console.WriteLine("Индекс самого дорогого: " + ind);
// Задание 4
// int[] b = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < b.Length; i++)
// {
//     if (b[i] < 0)
//     {b[i] = 0;}
// }
// foreach (int x in b)
// {
//     Console.Write(x + " ");
// }
// Console.WriteLine();
// Задание 5
// int[] a = new int[5];
// int k = 0;
// Console.WriteLine("Введите 5 чисел:");
// for (int i = 0; i < 5; i++)
// {
//     a[i] = int.Parse(Console.ReadLine());
//     if (a[i] % 2 == 0)
//     {
//         k = k + 1;
//     }
// }
// Console.WriteLine("Массив наоборот:");
// Console.Write(a[4] + " " + a[3] + " " + a[2] + " " + a[1] + " " + a[0]);
// Console.WriteLine();
// Console.WriteLine("Чётных чисел: " + k);
// Задание 6
// string[] n = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// Console.Write("Введите имя для поиска: ");
// string s = Console.ReadLine();
// int ind = -1;
// for (int i = 0; i < n.Length; i++)
// {
//     if (n[i] == s)
//     {
//         ind = i;
//         break;}
// }
// if (ind != -1)
// {
//     Console.WriteLine("Позиция в массиве: " + ind);
// }
// else
// {
//     Console.WriteLine("Не найдено");
// }

// я решила сократить так как код большой и так ваще проще написать
// Итоговая задача журнал оценок
int[] g = { 5, 4, 3, 5, 2, 4, 5, 4 };
Console.Write("Все оценки: ");
foreach (int x in g) Console.Write(x + " ");
Console.WriteLine();
int s = 0, max = g[0], min = g[0], d = 0, p = 0;
for (int i = 0; i < g.Length; i++)
{
    s = s + g[i];
    if (g[i] > max) max = g[i];
    if (g[i] < min) min = g[i];
    if (g[i] == 2) d = d + 1;
    if (g[i] == 5) p = p + 1;
}
double sr = (double)s / g.Length;
Console.WriteLine("Средняя: " + sr + "\nМакс: " + max + "\nМин: " + min);
Console.WriteLine("Двоек: " + d + "\nПятерок: " + p);
if (sr >= 4.5) Console.WriteLine("Отличник");
else if (sr >= 3.5) Console.WriteLine("Хорошист");
else Console.WriteLine("Есть над чем поработать");
