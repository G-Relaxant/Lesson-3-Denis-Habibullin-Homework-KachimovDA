int number = Input("Введите число: ");

//bool result = true;

if(number > 9999 && number < 100000)
{
    int pervrazr = number / 10000;
    int pyatrazr = number % 10;
    int vtorrazr = (number / 1000) % 10;
    int chetrazr = (number % 100) / 10;
    if(pervrazr == pyatrazr && vtorrazr == chetrazr)
    {
        Console.WriteLine("Да, Ваше число является палиндромом");
    }
    else
    {
        Console.WriteLine("Нет, Ваше число не является палиндромом");
    }
}
else
{
    if(number > -100000 && number < -9999)
    {
        int pervrazr = number / -10000;
        int pyatrazr = number % -10 * -1;
        int vtorrazr = (number / -1000) % 10;
        int chetrazr = (number % -100) / -10;
        if(pervrazr == pyatrazr && vtorrazr == chetrazr)
        {
            Console.WriteLine("Да, Ваше число является палиндромом");
        }
        else
        {
            Console.WriteLine("Нет, Ваше число не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели недопустимое число");
    }
}




/*int PositiveNumber(int a)
{
    int pervrazr = a / 10000;
    int pyatrazr = a % 10;
    int vtorrazr = (a / 1000) % 10;
    int chetrazr = (a % 100) / 10;
    if(pervrazr == pyatrazr && vtorrazr == chetrazr)
    {
        result = true;
    }
    else
    {
        result = false;
    }
}


int NegativeNumber(int a)
{
    int pervrazr = number / -10000;
    int pyatrazr = number % -10 * -1;
    int vtorrazr = (number / -1000) % 10;
    int chetrazr = (number % -100) / -10;
    if(pervrazr == pyatrazr && vtorrazr == chetrazr)
    {
        result = true;
    }
    else
    {
        result = false;
    }
}*/



int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}