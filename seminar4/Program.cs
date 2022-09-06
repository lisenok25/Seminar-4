
// Задача 25. Написать прогу, кот на вход принимает два числа (А и В)
// и возводит число А в натуральную степень В. 
// (3,5-243), (2,4-16)


// void Number(int a, int b)
// {
//     int result=1;
//     for(int i=1; i <= b; i++){
//         result=result * a;
//     }
//     Console.WriteLine(+ result);
// }     

// Console.Write("Введите число а: ");
// int a= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число b: ");
// int b= Convert.ToInt32(Console.ReadLine());
// Number(a,b);




// Задача 29.  Написать прогу, кот задает массив 
//  из произвольного кол-ва элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//  (задаем сами кол-во и потом выводим на экран- не через рандом,
//  нужно придумать еще одну функци,кот будет запрашивать эл-ты массива)

// int[] CreateArray(int size){     
//     int[]array=new int[size];       
//     for(int i=0; i<size; i++){
//         Console.Write("Введите эл-ты мaссива: ");
//         array[i]=Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] arr){
//     Console.Write("массив элементов[ ");    
    
//     for ( int i=0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");

//     }
//     Console.Write("]");
// }

// Console.Write("Введите размер мaссива: ");
// int size= Convert.ToInt32(Console.ReadLine());
// ShowArray(CreateArray(size));



// Задача 27. Написать прогу, кот принимает на вход число и выдает сумму цифр в числе
// (452-11, 82-10)


//   int Sum(int n){
    
//     int count= Convert.ToString(n).Length;
//     int advance= 0;
//     int result = 0;

//     for (int i = 0; i < count; i++){
//       advance = n - n % 10;
//       result = result + (n - advance);
//       n = n/ 10;
//     }
//    return result;
//   }
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = Sum(n);
// Console.WriteLine("Сумма цифр в числе: " + sum);