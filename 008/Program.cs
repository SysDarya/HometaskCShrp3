// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void Fill (int[] M){
    for (int p = 0; p < M.Length; p++){
        M[p] = new Random().Next(1,20);
    }
}
void Print(int[] M){
    foreach(var element in M)
        Console.Write($"{element} ");
}
void Mult (int[] M){
    int l = M.Length - 1;
    Console.Write ("Ваши произведения: ");
    for(int i = 0; i < M.Length; i++){
        int mult = M[i]*M[l];
        Console.Write ($"{mult} ");
        l--;
        if (i == M.Length/2 - 1){
            break;
        }
    }
}

Console.Write("Введите размер массива: " );
int size = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[size];
Fill(array);

Console.Write("Ваш массив: ");
Print (array);
Console.WriteLine(" ");

Mult(array);