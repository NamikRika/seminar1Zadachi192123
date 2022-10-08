// Урок 3. Массивы и функции в программировании

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Задача 19 \n Напишите программу, которая принимает на вход \n пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine();
Console.WriteLine("Решение");    

 void  PalindromYesOrNo (double chisloN) 
{        
  for (int i = 0; i <= 1; i++) 
{
  
         int delitel = 0;
         int delitel2 = 0;
         

         if (i==0) delitel = 10000; 
         if (i==0) delitel2 = 10;
         if (i==1) delitel = 100; 
         if (i==1) delitel2 = 10;
        
       
         double aa = chisloN / delitel;      
         int a = Convert.ToInt32(chisloN) / delitel;
         int b = Convert.ToInt32(chisloN) % delitel2;        
        
         if (a == b) 
         {                 

         string str = System.Convert.ToString(aa);
         string[] parts = str.Split(',');
        
         chisloN = Convert.ToDouble(parts[1]);
         chisloN = Convert.ToInt32(chisloN / delitel2); 

         if (i==1) Console.WriteLine("Введйнное число является палиндромом");                              
         

         }

         else
         {                         
            i=1;
            Console.WriteLine("Введйнное число не является палиндромом");              
        }  

}   
}

Console.WriteLine("Введите пятизначное число");    
double chisloP = Convert.ToInt32(Console.ReadLine());
PalindromYesOrNo (chisloP);

// Задача 19 -------- завершена

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125