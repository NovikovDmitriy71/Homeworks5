// Возведения числа А в степень Б

// Console.WriteLine("Imput x ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Imput y ");
// double y = Convert.ToDouble(Console.ReadLine());
// {
// double Result = Math.Pow(x,y);
// Console.WriteLine($"{x}^{y}={Result}");
// }

// // Нахождение суммы элементов введенного числа.
// Console.WriteLine("Input N");
// int N=Convert.ToInt32(Console.ReadLine());
// int s = N;
// int ResSum=0;
// while (N>0)
// {
//     ResSum += N % 10;
//     N =  N / 10;
//     //Console.WriteLine(ResSum);
// }
// Console.WriteLine($" namber {s} -> sumelementob {ResSum}");
//
//
//  Вывод элемента массива

// int [] array ={1,2,3,4,5,6,7,8,4};
// int n =array.Length;
// int find=4;
// int index=0;
// while (index<n)
// {
//     if (array[index]==find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }

// вывод массива из 8 элементов
void MyArray(int [] Collection)
{
    int Length =Collection.Length;
    int index=0;
    while (index<Length)
    {
        Collection[index]=new Random().Next(1,8);
        index++;
    }
}
void PrintArray(int [] col)
{
int count =col.Length;
int position=0;
while(position<count)
   {
    Console.WriteLine(col[position]);
    position++;
   }
}
int [] array= new int [10];


MyArray(array);
PrintArray(array);
