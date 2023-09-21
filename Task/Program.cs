/* 
Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] 
*/

// // -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = @"Задача: Из имеющегося (созданного пользователем) массива строк 
сформировать новый массив из строк, длина которых меньше, либо равна 3 символам.";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
                    Написать программу, которая из имеющегося массива строк 
        формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
**************************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---

// Вызов метода, запрашивающего данные у пользователя
int sizeArray = GetArraySize();

#endregion --- 01. Input operations ---

#region --- 02. Business logic ---

string[] arrayToOperate = new string[sizeArray];
string[] arrayToOperate2 = new string[sizeArray];
FillArray(arrayToOperate);

ArraySort(arrayToOperate, arrayToOperate2);

#endregion --- 02. Business logic ---

#region --- 03. Output operations ---

Console.WriteLine("\nНеотсортированный массив:");
PrintArray(arrayToOperate);

Console.WriteLine("\nОтсортированный массив:");
PrintArray(arrayToOperate2);

#endregion --- 03. Output operations ---
// // -------------------------- Конец программы ----------------------------------


// // -------------------------Определение методов ---------------------------------

// Методы запроса данных у пользователя
int GetArraySize()
{
    int sizeArray = 0;
    string enteredSymbol = string.Empty;
    do
    {
        Console.Clear();
        Console.Write("Создать случайный массив из строк? Нажмите y или n: ");
        enteredSymbol = Console.ReadLine() ?? "";
        if (enteredSymbol == "y")
        {
            sizeArray = new Random().Next(2, 11);
            break;
        }
        else if (enteredSymbol == "n")
        {
            sizeArray = GetNumberFromUser ("Введите количество элементов массива: ", "Ошибка ввода данных!");
            break;
        }
    } while (true);

    return (sizeArray);
}

int GetNumberFromUser (string welcomeMessage, string errorMessage)
{   
    while(true)
    {
        try
        {
            Console.Write(welcomeMessage);
            return int.Parse(Console.ReadLine() ?? "");            
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");        
        }
    }
}

// Методы, возвращающие двумерные массивы 
string RandomString(Random random, int length)
{
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
}


void FillArray(string[] ArrayToFill)
{
    Random random = new Random();
    for (int i = 0; i < ArrayToFill.Length; i++)
    {
        var length = new Random().Next(3, 10);
        ArrayToFill[i] = RandomString(random, length);
    }
}

// Метод, сортирующий строки массива
void ArraySort(string[] arrayToSort, string[] arrayToSort2)
{
    int count = 0;
    for (int i = 0; i < arrayToSort.Length; i++)
    {
    if(arrayToSort[i].Length <= 3)
        {
        arrayToSort2[count] = arrayToSort[i];
        count++;
        }
    }
}  

// Метод вывода массива
void PrintArray(string[] ArrayToPrint)
{
    // Console.Write("[");
    for (int i = 0; i < ArrayToPrint.Length; i++)
    {
        Console.Write($"{ArrayToPrint[i]} ");//+ ", ");
    }
    // Console.WriteLine((ArrayToPrint[ArrayToPrint.Length - 1]+"]"));
}

// // ---------------------- Конец определения методов ----------------------------
string[] array1 = new string[6] {"257", "45", "hello", "world", "res","456"};
string[] array2 = new string[array1.Length];