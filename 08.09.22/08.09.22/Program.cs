string str = Console.ReadLine();

string sort(string a)
{
    int flag = 1;
    char[] s = a.ToCharArray();
    while (flag == 1)
    {
        flag = 0;
        for (var i = 0; i < s.Length - 1; i++)
        {
            if (s[i] < s[i + 1])
            {
                char temp = s[i];
                s[i] = s[i + 1];
                s[i + 1] = temp;
                flag = 1;
            }
        }
    }
    string res = new string(s);
    return res;
}

char[] s = str.ToCharArray();
char[] s1 = new char[str.Length];
char[] s2 = new char[str.Length];
int i_l = str.Length;

string a;
string b;

for (var i = 0; i < s.Length; i++)
{
    if (i < i_l)
    {
        s1[i] = s[i];
    }
    else 
    {
        s2[i - i_l] = s[i];
    }
    if (s[i] == ' ')
    {
        i_l = i+1;
        
    }
}
a = new string(s1);
b = new string(s2);

Console.WriteLine(a);
Console.WriteLine(b);

if (a.Length == b.Length)
{
    if (sort(a) == sort(b))
    {
        Console.WriteLine("YES");
    }
    else { Console.WriteLine("NO"); }
}
else { Console.WriteLine("NO"); }
