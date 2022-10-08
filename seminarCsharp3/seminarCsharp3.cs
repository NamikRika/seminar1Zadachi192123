
// // Урок 3. Массивы и функции в программировании

// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

// Console.WriteLine("Задача 19 \n Напишите программу, которая принимает на вход \n пятизначное число и проверяет, является ли оно палиндромом.");
// Console.WriteLine();
// Console.WriteLine("Решение");    

//  void  PalindromYesOrNo (double chisloN) 
// {        
//   for (int i = 0; i <= 1; i++) 
// {
  
//          int delitel = 0;
//          int delitel2 = 0;
         

//          if (i==0) delitel = 10000; 
//          if (i==0) delitel2 = 10;
//          if (i==1) delitel = 100; 
//          if (i==1) delitel2 = 10;
        
       
//          double aa = chisloN / delitel;      
//          int a = Convert.ToInt32(chisloN) / delitel;
//          int b = Convert.ToInt32(chisloN) % delitel2;        
        
//          if (a == b) 
//          {                 

//          string str = System.Convert.ToString(aa);
//          string[] parts = str.Split(',');
        
//          chisloN = Convert.ToDouble(parts[1]);
//          chisloN = Convert.ToInt32(chisloN / delitel2); 

//          if (i==1) Console.WriteLine("Введйнное число является палиндромом");                              
         

//          }

//          else
//          {                         
//             i=1;
//             Console.WriteLine("Введйнное число не является палиндромом");              
//         }  

// }   
// }

// Console.WriteLine("Введите пятизначное число");    
// double chisloP = Convert.ToInt32(Console.ReadLine());
// PalindromYesOrNo (chisloP);

// // Задача 19 -------- завершена

// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Задача 21 \n Напишите программу, которая принимает на вход координаты двух точек \n и находит расстояние между ними в 3D пространстве");    
// Console.WriteLine();    
// Console.WriteLine("Решение");

// void rasstoyaniyeMejduTremyaTochkami (double x1, double y1, double z1, double x2, double y2, double z2)

// {
 
//   double A = x1 - x2;
//          A = Math.Pow(A,2);
  
//   double B = y1 - y2;
//          B = Math.Pow(B,2);
  
//   double Z = z1 - z2;
//          Z = Math.Pow(Z,2);

//   double summaABZ = A + B + Z;  
//          summaABZ = Math.Sqrt(summaABZ);
//          summaABZ =Math.Round(summaABZ,2);
  
  
//   Console.WriteLine("Растояние между точками равно " + summaABZ);    

// }

// Console.Write("Введите координату X1 ");    
// double xPervogoChisla = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y1 ");    
// double yPervogoChisla = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z1 ");    
// double zPervogoChisla = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координату X2 ");    
// double xVtorogoChisla = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y2 ");    
// double yVtorogoChisla = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z2 ");    
// double zVtorogoChisla = Convert.ToDouble(Console.ReadLine());

// rasstoyaniyeMejduTremyaTochkami(xPervogoChisla, yPervogoChisla, zPervogoChisla, xVtorogoChisla, yVtorogoChisla, zVtorogoChisla);

// // // Задача 21 -------- завершена

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Задача 23 \n Напишите программу, которая принимает на вход число (N) \n и выдаёт таблицу кубов чисел от 1 до N");    
Console.WriteLine();    
Console.WriteLine("Решение");


// void tablicaKubov (double chisloN)
// {

//         Console.WriteLine();    
//         Console.WriteLine("  " + "Число" + "  " + "Куб");

//         for (int i = 1; i <= chisloN; i++)
//         {
//                 double znacheniyeI = Convert.ToDouble(i);
//                 double chisloKuba = Math.Pow(znacheniyeI , 3);
//                 Console.WriteLine("    " + i + "     " + chisloKuba);
//         }

// }

// Console.Write("Введите число ");    
// double chisloNn = Convert.ToDouble(Console.ReadLine());

// tablicaKubov(chisloNn);


