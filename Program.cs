string str;
int flag;
do
{
    Console.WriteLine("Введите строку: ");
    flag = 0;
    str = Console.ReadLine();
    foreach (char s in str)
    {
        if (s == '0') flag = 1;
        if (s == '1') flag = 1;
        if (s == '2') flag = 1;
        if (s == '3') flag = 1;
        if (s == '4') flag = 1;
        if (s == '5') flag = 1;
        if (s == '6') flag = 1;
        if (s == '7') flag = 1;
        if (s == '8') flag = 1;
        if (s == '9') flag = 1;

    }
    if (flag == 1)
    {
        Console.WriteLine("Я сказал без цифр");
    }
} while (flag == 1);
Console.WriteLine("Строка без цифр.");