string role = "user";

string result = role switch 
{
"admin" => "Полный доступ",
"teacher" => "Доступ преподавателя",
not "admin" => "Ограниченный доступ"
};

Console.WriteLine(result);

int age = 20;
bool hasTicket = true;

string Result = age switch
{
    >= 18 when hasTicket => "Вход разрешён",
    >= 18 => "Нет билета",
    _ => "Возраст не подходит"
};

Console.WriteLine(Result);

int level = 2;

switch (level)
{
    case 1:
    Console.WriteLine("Начальный уровень");
    break;
    case 2:
    Console.WriteLine("Средний уровень");
    goto case 1;
    case 3:
    Console.WriteLine("Продвинутый уровень");
    break;
}
