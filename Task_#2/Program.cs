/*
Как распечатать весь массив сразу
*/

int[] array = new int[10];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = rnd.Next(1, 10);

string result = string.Join(", ", array);
Console.WriteLine(result);