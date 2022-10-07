// создает рандомный двумерный массив int
int[,] RandomArray (int firstArrayQuantity, int secondArrayQuantity, int minimum, int maximum) {
    int[,] array = new int[firstArrayQuantity, secondArrayQuantity];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minimum,maximum+1);
        }
    }

    return array; 
}

// возвращает строку из двумерного массива int
string ArrayIntToString(int[,] arr){
    string result = string.Empty;

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {            
            result = result + $"{arr[i, j]} ";
        }
        result = result + $"\n";
    }

    return result;
}

/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 */

int[,] matrix = RandomArray(5,4,-10,10);
System.Console.WriteLine($"{ArrayIntToString(matrix)}"); 

/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
 Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

// создает массив int Aₘₙ = m+n
int[,] FunctionArray (int firstArrayQuantity, int secondArrayQuantity) {
    int[,] array = new int[firstArrayQuantity, secondArrayQuantity];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }

    return array; 
}

int[,] matrix = FunctionArray(4,4);
System.Console.WriteLine($"{ArrayIntToString(matrix)}");  


/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4 
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

int[,] matrix = RandomArray(4,4, -10, 10);

System.Console.WriteLine($"{ArrayIntToString(matrix)}"); 
System.Console.WriteLine(); 

// вычисление
for (int i = 2; i < matrix.GetLength(0); i++)
{
    for (int j = 2; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 1 && j % 2 == 1 ){
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
}

System.Console.WriteLine($"{ArrayIntToString(matrix)}"); 


/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */


int[,] matrix = RandomArray(4, 6, -10, 10);
int result = 0;

// вычисление
for (int i = 0; i < matrix.GetLength(1); i++)
{
    if ( matrix.GetLength(0) > i && matrix.GetLength(1) > i)
    {
        result = result + matrix[i, i];
    }
}

System.Console.WriteLine($"{ArrayIntToString(matrix)}"); 
System.Console.WriteLine($"Сумма элементов главной диагонали: {result}"); 


/* Необходимо найти  5 целых чисел (положительных), которые будут удовлетворять такому условию
x^5 + y^5 + z^5 + q^5 = w^5
Т.е. сумма 4 чисел в пятой степени = 5 числу в пятой степени */

Int64 length = 10;
Int64 start = 1;
for (Int64 x = start; x < length; x++)
{
    for (Int64 y = start; y < length; y++)
    {
        for (Int64 z = start; z < length; z++)
        {
            for (Int64 q = start; q < length; q++)
            {
                for (Int64 w = start; w < length; w++)
                {
                    if (Math.Pow(x, 5) + Math.Pow(y, 5) + Math.Pow(z, 5) + Math.Pow(q, 5) == Math.Pow(w, 5)){
                        System.Console.WriteLine($"{x} + {y} + {z} + {q} = {w}");
                        break;
                    }
                        System.Console.WriteLine($"{x} + {y} + {z} + {q} != {w}");
                }
            }
        }    
    }
}
