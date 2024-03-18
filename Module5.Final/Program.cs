
PrintPerson(Person());

///Метод возвращающий кортеж 
(string, string, int, string[], string[]) Person()
{
    (string _name, string _surName, int _age, string[] _nameOfPets, string[] _nameOfColor) User;

    string _presenceOfPets;
    int _countOfPets;
    int _countOfColor;

    Console.WriteLine("Введите ваше имя:");
    User._name = Console.ReadLine();

    Console.WriteLine("Введите вашу фамилию:");
    User._surName = Console.ReadLine();

    User._age = Check("Введите возраст:");


    //Получаем количество питомцев, при наличии  и присваиваем массив петов в кортеж
    do
    {
        Console.WriteLine("У вас есть питомцы? (Да,Нет)");
        _presenceOfPets = Console.ReadLine().ToLower();
        switch (_presenceOfPets.ToLower())
        {
            case "да":
                _countOfPets = Check("Введите количество питомцев:");
                User._nameOfPets = GetArrayNameOf(_countOfPets, "Введите клички питомцев, через Enter:");
                break;
            case "нет":
                User._nameOfPets = ["Питомцев нет"];
                break;
            default:
                User._nameOfPets = null;
                Console.WriteLine("Нужно ввести \"Да\" или \"Нет\"");
                break;
        }
    } while (!(_presenceOfPets == "да") && !(_presenceOfPets == "нет"));



    //Получаем количество цветов
    _countOfColor = Check("Введите количество любимых цветов(красный, желтый и т.д.):");
   

    //Присваиваем массив Color
    User._nameOfColor = GetArrayNameOf(_countOfColor, "Введите название цветов, через Enter:");



    int Check(string text)//Проверяет на правильность ввода и введено ли число <= 0
    {
        
        while (true)
        {
            Console.WriteLine(text);
            if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
            {
                return value;
            }
            Console.WriteLine("Введено некорректное значение. Введите положительное целочисленное значение.");
        }
    }


    string[] GetArrayNameOf(int _countOf, string text)//Создание массива
    {
        string[] arr = new string[_countOf];

        Console.WriteLine(text);

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Console.ReadLine();
        }
        return arr;
    }

    return User;
}


//Метод выводящий информацию о жертве
void PrintPerson((string, string, int, string[], string[]) person)
{
    Console.Clear();

    Console.WriteLine($"Ваше имя: {person.Item1}");
    Console.WriteLine($"Ваше Фамилия: {person.Item2}");
    Console.WriteLine($"Ваш возраст: {person.Item3}");
    Console.WriteLine("....................................................................");

    Console.WriteLine("Имена ваших питомцев:");
    foreach (string name in person.Item4)
    {
        Console.WriteLine(name);
    }
    Console.WriteLine("....................................................................");

    Console.WriteLine("Ваши любимые цвета:");
    foreach (string color in person.Item5)
    {
        Console.WriteLine(color);
    }
}
