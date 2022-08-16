// 

void Fill (int[] M){
    for (int p = 0; p < M.Length; p++){
        M[p] = new Random().Next(-90,91);
    }
}
void Print(int[] M)
{
    foreach(var element in M)
        Console.Write($"{element} ");
}

bool Contains(int[] M, int value)
{
    foreach(var element in M)
        if(element==value)
            return true;
    return false;
}
Console.Write("Введите размер массива: " );
int size = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[size];
Fill(array);

Console.Write("Ваш массив: ");
Print (array);
Console.WriteLine(" ");

Console.Write("Введите элемент, котрый хотите найти: ");
int element = int.Parse(Console.ReadLine() ?? "0");
bool contains = Contains(array,element);
Console.WriteLine(contains ? "Элемент присутствует." : 
    "Элемента нет :(");
