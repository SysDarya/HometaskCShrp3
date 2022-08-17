// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void Fill (int[] M){
    for (int p = 0; p < M.Length; p++){
        M[p] = new Random().Next(100,1000);
    }
}
void Print(int[] M)
{
    foreach(var element in M)
        Console.Write($"{element} ");
}
void Count (int[] M){
    int even = 0;
    int odd = 0;
    for (int c = 0; c < M.Length; c++){
        if (M[c]%2 == 0){
            even++;
        }
        else{
            odd++;
        }
    }
    Console.Write ($"Количество четных чисел в массиве - {even}. Количество нечетных - {odd}.");
}
Console.Write("Введите размер массива: " );
int size = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[size];
Fill(array);

Console.Write("Ваш массив: ");
Print (array);
Console.WriteLine(" ");
Count(array);