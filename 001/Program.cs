// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void Fill (int[] M)
{
    int l = M.Length;
    int i = 0;
    while (i < l){
        M[i] = new Random().Next(0,2);
        i++;
    }
}

void Print (int[] M)
{
    int c = M.Length;
    int p = 0;
    while (p < c){
        Console.Write ($"{M[p]}, ");
        p++;
    }
}

int [] array = new int [8];
Fill (array);
Print (array);