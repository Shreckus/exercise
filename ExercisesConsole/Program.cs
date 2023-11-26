// See https://aka.ms/new-console-template for more information



bool result = Task1(500);

Console.WriteLine("Hello, World!");

bool Task1(int money)
{
    // У кассира всего 5000 рублей и все эти деньги - монеты по 5 рублей.
    // Узнать может ли он разменять money покупателя
    int kasir = 5000;
    int moneta = 5;
    if (money > kasir)

    {
        Console.WriteLine("В кассе недостаточно средств.");
        return false;   
    }
    else if (money % moneta == 0)

    {
        Console.WriteLine("Кассир может разменять деньги");
        return true;
    }
        else
        {
            Console.WriteLine("Кассир не может разменять деньги");
            return false;
        }
}

bool Task2(int[] ageArray)
{
    // На вход получаем массив возрастов компании отдыхающих. Заведение 18+. Определить все ли ее участники могут быть в заведении
    throw new NotImplementedException();
}