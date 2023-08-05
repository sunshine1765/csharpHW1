Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
while(number > 2)
{
    if(number %2 == 0)
    {
        number -= 2;
        Console.WriteLine(number);
    }
    else 
    {
        number -= 1;
        Console.WriteLine(number);
    }
}