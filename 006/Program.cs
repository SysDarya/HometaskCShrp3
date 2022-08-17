// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void Fill (int[] M){
    for (int p = 0; p < M.Length; p++){
        M[p] = new Random().Next(-10,111);
    }
}
void Print(int[] M)
{
    foreach(var element in M)
        Console.Write($"{element} ");
}
void Count (int[] M){
    int c = 0;
    for (int i = 0; i < M.Length; i++){
        if (M[i]>10 && M[i]<99){
            c++;
        }
    }
    Console.WriteLine($"Количество элементов из отрезка [10, 99] равно {c}.");
}

int[] array = new int[123];
Fill(array);
Console.Write("Ваш массив: ");
Print (array);
Console.WriteLine(" ");
Count(array);
