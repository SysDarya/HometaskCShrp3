// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void Fill (double[] M){
    for (int p = 0; p < M.Length; p++){
        M[p] = new Random().Next(1,20);
    }
}
void Print (double[] M){
    foreach(var element in M)
        Console.Write($"{element} ");
}
void Diff (double[] M){
    double min = 20;
    double max = 0;
    for (int i = 0; i < M.Length; i++){
        if (M[i] < min){
            min = M[i];
        }
        if (M[i] > max){
            max = M[i];
        }
    }
    double diff = max - min;
    Console.WriteLine ($"Наибольшее: {max}.");
    Console.WriteLine ($"Наименьшее: {min}.");
    Console.WriteLine ($"Разница между наибольшим и наименьшим элементом равна {diff}.");
}


Console.Write("Введите размер массива: " );
int size = int.Parse(Console.ReadLine() ?? "0");

double[] array = new double[size];
Fill(array);

Console.Write("Ваш массив: ");
Print (array);
Console.WriteLine(" ");

Diff(array);