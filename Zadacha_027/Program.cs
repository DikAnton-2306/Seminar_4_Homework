// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//------------------------  START  -----------------------------------------------------------------

int DataNumber(string str) // метод ввода числа
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumDissection(int number) //Decay
{
    int sum;
    for (sum = 0; number != 0; number = number/10)
    {
        int count = number % 10;
        sum = sum + count;
        // Console.WriteLine(sum); //Поверка(что происходит в цикле)
    }
    return sum;
}

//---------------------  РАБОЧАЯ ОБЛАСТЬ  ----------------------------------------------------------

int num = DataNumber("Введите число: "); // получить от пользователя число А
int sum = SumDissection(num);

Console.WriteLine($"Сумма всех цифр в числе {num} равняется {sum}");

// ----------------------  END  --------------------------------------------------------------------