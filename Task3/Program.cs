// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 6:
    {
    Console.WriteLine("Yes");
    break;
    }
    case 7:   
    {
    Console.WriteLine("Yes");
    break;
    }
    default:
    {
    Console.WriteLine("No");
    break;
    }
}
