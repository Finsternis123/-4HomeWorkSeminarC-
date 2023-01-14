//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
int[] Array = GetArray(8); 
Console.Write($"[{String.Join(";", Array)}]"); 
 
int[] GetArray (int size) 
{ 
    int[] Array = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        Array[i] = new Random().Next(); 
    } 
    return Array; 
}


