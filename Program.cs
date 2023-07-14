/*Task1 Напишите программу, которая принимает на вход число
 и проверяет, является ли оно палиндромом*/



bool IsNumberAPalindrome(int number)
    {
        string numberString = number.ToString();
        int length = numberString.Length;

        for (int i = 0; i < length / 2; ++i)
        {
            if (numberString[i] != numberString[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
    if (IsNumberAPalindrome(number))
        {
            Console.WriteLine("Число является палиндромом.");
        }
    else
        {
            Console.WriteLine("Число не является палиндромом.");
        }

/*Task2 Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними в 3D пространстве.*/

double distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double sqrt = Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1))+((z2-z1)*(z2-z1)));
    return sqrt;
}

Console.WriteLine("Input A coordinate x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input A coordinate y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input A coordinate z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input B coordinate x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input B coordinate y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input B coordinate z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double doub = distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(doub);


/*Task3 Напишите программу, которая принимает на вход число (N) 
и выдает таблицу кубов чисел от 1 до N.*/

void TableQuad(int N)
{
    int count = 1;
    while(count <= N)
    {
        Console.WriteLine($"{count} = {count*count*count}");
        count++;
    }
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

TableQuad(num);
