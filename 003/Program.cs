// Написать программу замену элементов массива на противоположные

void Fill (int[] M){
    for (int p = 0; p < M.Length; p++){
        M[p] = new Random().Next(-90,91);
    }
}
void Print (int[] M){
    for (int i = 0; i < M.Length; i++){
        if (i == M.Length - 1){
            Console.Write ($"{M[i]}.");
        }
        else{
        Console.Write ($"{M[i]}; ");
        }
    }
}
void Change (int[] M){
    for (int pos = 0; pos < M.Length; pos++){
        M[pos] *= -1;
    }
}

int[] array = new int[10];
Fill (array);
Print (array);
Change (array);
Console.WriteLine (" ");
Print (array);