/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами*/

void FillArray(string[] M1, string[] M2)
{
    int count = 0;
    for (int i = 0; i < M1.Length; i++)
    {
        if (M1[i].Length <= 3)
        {
            M2[count] = M1[i];
            count++;
        }
    }
}
void PrintArray(string[] M)
{
    for (int i = 0; i < M.Length; i++)
    {
        Console.Write($"{M[i]} ");
    }
}
string[] array = { "I", "am", "OK!", "1234", "!!!!", "12345" };
string[] newarray = new string[array.Length];

FillArray(array, newarray);
PrintArray(newarray);