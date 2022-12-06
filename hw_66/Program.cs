// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите начальное число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное число");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNum(n,m));

string PrintNum(int start, int end)

{
if (start==end)
{
return end.ToString();
}
return(start+ " "+PrintNum(start +1, end));
}
Console.WriteLine("===============================");

int summ = 0;
for (int i = 0; i <= (m-n); i++)
{
    summ += n+i;
}
Console.WriteLine("Сумма чисел в строке =");
Console.WriteLine(summ);

// int SummNum(int start1, int end1)

// {
// if (start1==end1)
// {
// return 0;
// }
// return(start1+ " "+SummNum(start1 +1, end));

// }


// int SummNum(int n, int m)
//     {
       
//     return(n%10+SummNum(n/10)); 
//     }

// Console.WriteLine(SummNum(n));
