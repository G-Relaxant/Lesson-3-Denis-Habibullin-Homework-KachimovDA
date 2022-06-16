int number = Input("Введите число: ");

int num = 1;

if(number > 0)
{
    Console.Write("Кубы до вашего числа включительно: 1");
    while(num < number)
    {
        Console.Write(", ");
        num = num + 1;
        int num2 = Cube(num);
        Console.Write(num2);
    }
}
else
{
    Console.WriteLine("Вы ввели недопустимое число");
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int Cube(int a)
{
    return a * a * a;
}