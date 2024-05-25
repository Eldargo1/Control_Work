
    Console.WriteLine("Введите элементы массива через запятую");
    string input = Console.ReadLine();
    
    string[] inputArray = input.Split(',');
    
    // Убираем пробелы в начале и в конце каждой строки
    for (int i = 0; i < inputArray.Length; i++)
    {
        inputArray[i] = inputArray[i].Trim();
    }

    // Подсчитываем количество строк, удовлетворяющих условию
    int count = 0;
    foreach (string str in inputArray)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

   