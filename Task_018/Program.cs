// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool check(bool x, bool y)
{
    if (!(x || y) == (!x && !y))
        return true;
    else
        return false;
}

if (check(false, false) && check(true, true) && check(true, false) && check(false, true))
    Console.WriteLine("Верно");
else
    Console.WriteLine("Неверно");