
PrintPerson(Person());

///Метод возвращающий кортеж 
(string,string,int, string[], string[]) Person()
{
    (string _name,string _surName,int _age, string[] _nameOfPets, string[] _nameOfColor) User;

    string _presenceOfPets;
    int _countOfPets;
    int _countOfColor;

    Console.WriteLine("Введите ваше имя");
    User._name = Console.ReadLine();

    Console.WriteLine("Введите вашу фамилию");
    User._surName = Console.ReadLine();

    User._age = Check("Введите возраст:");


    //Получаем количество питомцев, при наличии
    Console.WriteLine("У вас есть питомцы? (Да,Нет)");
    _presenceOfPets = Console.ReadLine();
    
    if (_presenceOfPets.ToLower().Contains("да"))
    {
        _countOfPets = Check("Введите количество питомцев");
        Console.WriteLine("Введите клички питомцев, через Enter:");
        User._nameOfPets = GetArrayNameOf(_countOfPets);
    }
     else  User._nameOfPets = [ "Питомцев нет"];

    //Получаем количество цветов
    _countOfColor = Check("Введите количество любимых цветов(красный, желтый и т.д.)");
    Console.WriteLine("Введите название цветов, через Enter:");
    User._nameOfColor = GetArrayNameOf(_countOfColor);



    int Check(string text)//Проверяет на правильность ввода и введено ли число <= 0
    {
        Console.WriteLine(text);
        if(!int.TryParse(Console.ReadLine(), out int value))
        {
            Console.WriteLine("Введено некорректное значение. Введите целочисленное значение");
            Check(text);
        }

        if (value <= 0)
        {
            Console.WriteLine("Значение должно быть больше 0");
            Check(text);
        }
        return value;
    }


    string[] GetArrayNameOf(int _countOf)//Создание массива
    {
        string [] arr = new string[_countOf];
        for (int i =0; i<arr.Length;i++)
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
    Console.WriteLine("....................................................................");

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
