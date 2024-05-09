//Домашнее задание. Тема 15. Урок 3. Свойства и методы
//одномерных массивов.

//1


//int[] numbers = new int[10];
//for (int i = 0; i < 10; i++)
//{
//    Console.Write($"Введите {i + 1}-е число: ");
//    numbers[i] = int.Parse(Console.ReadLine());
//}


//Array.Sort(numbers);


//Console.WriteLine("Отсортированный массив:");
//foreach (int num in numbers)
//{
//    Console.Write(num + " ");
//}
//Console.WriteLine();


//Console.Write("Введите число для поиска: ");
//int searchNum = int.Parse(Console.ReadLine());
//int index = Array.IndexOf(numbers, searchNum);
//if (index >= 0)
//{
//    Console.WriteLine($"Число {searchNum} находится на индексе {index}");
//}
//else
//{
//    Console.WriteLine("Число не найдено в массиве.");
//}

//Домашнее задание. Тема 15. Урок 4. Свойства и методы
//одномерных массивов. Тип Object.

//2


//int[] arr1 = GetRandomArray(2);
//int[] arr2 = GetRandomArray(2);
//int[] arr3 = GetRandomArray(2);
//int[] arr4 = GetRandomArray(2);

//// Вычисляем средние арифметические для каждой пары массивов
//double avg1_0 = GetAverage(arr1);
//double avg1_1 = GetAverage(arr2);
//double[] avg1 = { avg1_0, avg1_1 };

//double avg2_0 = GetAverage(arr3);
//double avg2_1 = GetAverage(arr4);
//double[] avg2 = { avg2_0, avg2_1 };

//// Вычисляем произведение средних арифметических
//double result_0 = avg1[0] * avg2[0];
//double result_1 = avg1[1] * avg2[1];
//double[] result = { result_0, result_1 };

//// Выводим результат
//Console.WriteLine("Массив 1: " + string.Join(", ", arr1));
//Console.WriteLine("Массив 2: " + string.Join(", ", arr2));
//Console.WriteLine($"Средние арифметические массивов 1 и 2: {avg1[0]}, {avg1[1]}");
//Console.WriteLine("Массив 3: " + string.Join(", ", arr3));
//Console.WriteLine("Массив 4: " + string.Join(", ", arr4));
//Console.WriteLine($"Средние арифметические массивов 3 и 4: {avg2[0]}, {avg2[1]}");
//Console.WriteLine($"Произведение средних арифметических: {result[0]}, {result[1]}");


//    static int[] GetRandomArray(int size)
//{
//    Random rnd = new Random();
//    int[] arr = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//        arr[i] = rnd.Next(1, 101);
//    }
//    return arr;
//}

//static double GetAverage(int[] arr)
//{
//    double sum = 0;
//    foreach (int num in arr)
//    {
//        sum += num;
//    }
//    return sum / arr.Length;
//}