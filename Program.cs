// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
 //Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
  //При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();
string[] InputArray()
 {
     string[] arrayString = new string[0];
     while (true)
     {
         Console.Write("Для завершения ввода введите - q. Введите строку: ");
         string userInformation = Console.ReadLine()!;
         if (userInformation == "q" || userInformation == "Q") break;
         else arrayString = FullArray(arrayString, newRow: userInformation);
     }
    return arrayString;
 }
 string[] FullArray(string[] arr, string newRow)
 {
    string[] newArr = new string[arr.Length+1];
         for (int i = 0; i < arr.Length; i++)
     {
        newArr[i] = arr[i];
     }
     newArr[newArr.Length - 1] = newRow;
     return newArr;
 }
 string[] NewArray(string[] arr, int size = 0, int index = 0)
 {
     for (int i = 0; i < arr.Length; i++)
     {
         if (arr[i].Length <= 3) size++;
     }
     string[] newArr = new string[size];
     for (int i = 0; i < arr.Length; i++)
     {
         if (arr[i].Length <= 3)
         {
             newArr[index] = arr[i];
             index++;
         }
     }
     return newArr;
 }
 string[] information = InputArray();
 Console.WriteLine();
 Console.WriteLine("[{0}] - введенные значения ", string.Join(", ", information));
 Console.WriteLine();
 string[] newInformation = NewArray(arr: information);
 Console.WriteLine("[{0}] - длина меньше либо равна 3 символам", string.Join(", ", newInformation));

