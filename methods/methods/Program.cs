#region task1
//Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
using System.ComponentModel.Design;

string NumbersCheck(int num)
{
    if (num % 3 == 0)
    {
        return "Eded 3e tam bolunur";
    }
    if (num % 7 == 0)
    {
        return "Eded 7 ye tam bolunur";
    }
    return "Eded serti odemir";
}
int num=int.Parse(Console.ReadLine());
Console.WriteLine(NumbersCheck(num));

#endregion

#region task2
//n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(Calculate(num1, num2));
string Calculate(int num1, int num2)
{
    if (num1 % 2 == 0 && num2 % 2 == 0)
    {
        return $"Ededlerin cemi={num1 + num2}";
    }
    return "Ededlerin her ikisi cut deyil";
}
#endregion

#region task3
// Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
Console.WriteLine(OddNumbers(n, m));
string OddNumbers(int n, int m)
{
    int count = default;

    if (n < m)
    {
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 1)
            {
                count++;
            }
        }
        return $"{count}";
    }
    return "Ededler serti odemir";
}
#endregion

#region task4
//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
Console.WriteLine(OddNumbersSum(n, m));

string OddNumbersSum(int n, int m)
{
    int result = default;

    if (n < m)
    {
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 1)
            {
                result += i;
            }
        }
        return $"{result}";
    }
    return "Ededler serti odemir";
}
#endregion
