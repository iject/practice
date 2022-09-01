using System;

// расстояние между часовой и минутной стрелкой
int h, m;
int res;
//int a = Convert.ToInt32(Console.ReadLine());
//int.TryParse(Console.ReadLine(), out b);
h = int.Parse(Console.ReadLine());
m = int.Parse(Console.ReadLine());

if ((0 <= h && h <= 24) && (0 <= m && m <= 60))
{
    res = Math.Abs(h % 12 * 5 - m);
    res = res > 30 ? 60 - res : res;
    Console.WriteLine(res * 360 / 60);
}
else Console.WriteLine("Error");



// перемножение двух матриц
/*string s = Console.ReadLine();
string[] s_arr = s.Split();
int[] arr1 = new int[s_arr.Length];

while (s != null)
{
    for (int i = 0; i < s_arr.Length; i++)
    {

    }
    s = Console.ReadLine();
    s_arr = s.Split();

}*/

while (Console.ReadLine() != null)
{
    string s = Console.ReadLine();
    Console.WriteLine(s);
}