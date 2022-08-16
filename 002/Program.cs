// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

void Fill (int[] M){
    int l = M.Length;
    for (int i = 0; i < l; i++ ){
        M[i] = new Random().Next(0,10);
    }
}
 void Print (int[] M){
    int c = M.Length;
    for (int p = 0; p < c; p++){
        if (p == c-1){
            Console.Write ($"{M[p]} = ");
        }
        else{
            Console.Write ($"{M[p]} + ");
        }
    }
 }
void Sum (int[] M){
    int n = M.Length;
    int sum = 0;
    for (int pos = 0; pos < n; pos++){
        sum = sum + M[pos];
    }
    Console.WriteLine ($"{sum}");
}
int[] array = new int[12];
Fill (array);
Print (array);
Sum (array);