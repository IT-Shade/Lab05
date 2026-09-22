int age = 17;

string category = age switch 
{
    < 0 => "Ошибка",
    >= 0 and <= 6 => "Ребёнок",
    >= 7 and <= 17 => "Подросток",
    >= 18 and <= 64 => "Взрослый",
    >= 65 => "Пенсионер"
};

Console.WriteLine(category);

int day = 2;

string result = day switch
{
1 or 2 or 3 or 4 or 5 => "Будний",
6 or 7 => "Выходной",
_ => "Некорректный номер дня"
};

Console.WriteLine(result);

int score = 64;

string Result = score switch 
{
>= 0 and <= 39 => "Неудовлетворительно",
>= 40 and <= 59 => "Удовлетворительно",
>= 60 and <= 79 => "Хорошо",
>= 80 and <= 100 => "Отлично",
_ => "Ошибка"
};

Console.WriteLine(Result);