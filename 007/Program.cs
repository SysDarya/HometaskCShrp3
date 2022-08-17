// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void Fill (int[] M){
    for (int p = 0; p < M.Length; p++){
        M[p] = new Random().Next(1,20);
    }
}
void Print(int[] M){
    foreach(var element in M)
        Console.Write($"{element} ");
}
void Sum (int[] M){
    int sum = 0;
    for (int i = 0; i < M.Length; i++){
        if (i%2 != 0){
            sum = sum + M[i];
        }
    }
Console.WriteLine ($"Сумма чисел на нечетной позиции равна {sum}.");
}

Console.Write("Введите размер массива: " );
int size = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[size];
Fill(array);

Console.Write("Ваш массив: ");
Print (array);
Console.WriteLine(" ");

Sum(array);