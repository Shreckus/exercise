// See https://aka.ms/new-console-template for more information


#region Использование остатка от деления
int num1 = 6;
int num2 = 4;

int ostatok = num1 % num2; // 2 
#endregion

#region Использование оператора if

// 1 случай. Когда в if используется значение (типа bool - логический тип) погугли что это

bool isRafaFromBClass = false;

if (isRafaFromBClass)
{
    Console.WriteLine("Рафа из Б класса");
}
else
{
    Console.WriteLine("Рафа не из Б класса");
}

//2 случай. когда испльзуется выражение. Погугли логические операторы в c#

int apelsini = 3;

if(apelsini == 4)
{
    Console.WriteLine("У вас 4 апельсина");
}

//3 случай. Результат логического выражения можно записать в переменную и его использовать в if

int yabloki = 5;
bool yablokiBolsheApelsinov = yabloki > apelsini;

if (yablokiBolsheApelsinov)
{
    Console.WriteLine("Яблок больше чем апельсинов");
}

#endregion


Console.WriteLine("Hello, World!");

bool Task1(int money)
{
    // У кассира всего 5000 рублей и все эти деньги - монеты по 5 рублей.
    // Узнать может ли он разменять money покупателя
    int kasir = 5000;
    if (money % 5 == 0)

    {
        Console.WriteLine("Кассир может разменять деньги");

    }
    else
    {
        Console.WriteLine("Кассир не может разменять деньги");
    }

}

bool Task2(int[] ageArray)
{
    // На вход получаем массив возрастов компании отдыхающих. Заведение 18+. Определить все ли ее участники могут быть в заведении
    throw new NotImplementedException();
}