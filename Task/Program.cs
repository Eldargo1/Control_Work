
    Console.WriteLine("Введите элементы массива через запятую");
    string input = Console.ReadLine();
    
    string[] inputArray = input.Split(',');
    
    // Убираем пробелы в начале и в конце каждой строки
    for (int i = 0; i < inputArray.Length; i++)
    {
        inputArray[i] = inputArray[i].Trim();
    }

    