//задание 1
// using System;
// internal class Program
// {
//     static void Main(string[] args)  
//       {
//         try     
//         {
//             Sotrydnik sotrydnik1 = new Sotrydnik("Primer Primer", 19, "Menenger", 30000);
//             Sotrydnik sotrydnik2 = new Sotrydnik("Ivan Ivanov", 25, "Oxranik", 18000);

//             Console.WriteLine(sotrydnik1);
//             Console.WriteLine(sotrydnik2);

//             sotrydnik1 += 7000;  
//             Console.WriteLine($"\nПосле повышение зп: {sotrydnik1}");

//             sotrydnik1 -= 2000;
//             Console.WriteLine($"\nПосле понижение зп: {sotrydnik1}\n");

//             Console.WriteLine($"Равна ли зп: {sotrydnik1 == sotrydnik2}");
//             Console.WriteLine($"sotrydnik1 > sotrydnik2: {sotrydnik1 > sotrydnik2}");
//             Console.WriteLine($"sotrydnik1 < sotrydnik2: {sotrydnik1 < sotrydnik2}");
//             Console.WriteLine($"sotrydnik1 != sotrydnik2: {sotrydnik1 != sotrydnik2}");

             

//         }        
//         catch (ArgException ex)
//         {   Console.WriteLine($"Ошибка: {ex.Message}");
//             Console.WriteLine($"Некорректное значение: {ex.Value}");     
//         }
//         }
// }
// class Sotrydnik{ 
//     private string fio;
//     private int data;    
//     private string dolznost; 
//     private decimal zp;
//     public Sotrydnik( string fio, int data, string dolznost, decimal zp)
//     {   
//         this.fio = fio;      
//         this.data = data;
//         this.dolznost=dolznost; 
//         Zp=zp;
//     }
//     public decimal Zp
//     {
//         get { return zp; }
//         set
//         {
//             if (value < 0)
//             {
//                 throw new ArgumentException("Маленькая зп");
//             }
//             zp = value;
//         }
//     }
//     public static Sotrydnik operator +(Sotrydnik sotrydnik, decimal amount)
//     {
//         sotrydnik.Zp += amount;
//         return sotrydnik;
//     }
//     public static Sotrydnik operator -(Sotrydnik sotrydnik, decimal amount)
//     {
//         sotrydnik.Zp -= amount;
//         return sotrydnik;
//     }

// public static bool operator ==(Sotrydnik sotrydnik1, Sotrydnik sotrydnik2)
// {
//     return sotrydnik1.Zp == sotrydnik2.Zp;
// }

// public static bool operator <(Sotrydnik sotrydnik1, Sotrydnik sotrydnik2)
// {
//     return sotrydnik1.Zp < sotrydnik2.Zp;
// }

// public static bool operator >(Sotrydnik sotrydnik1, Sotrydnik sotrydnik2)
// {
//     return sotrydnik1.Zp > sotrydnik2.Zp;
// }
// public static bool operator !=(Sotrydnik sotrydnik1, Sotrydnik sotrydnik2)
// {
//     return !(sotrydnik1 == sotrydnik2);
// }

// public override string ToString()
// {       
//     return $"\nФИО: {fio}\nВозраст: {data}\nДолжность: {dolznost}\nЗп: {zp} грн";
// }
// }

// class ArgException : Exception
// {   public int Value { get; }
//     public ArgException(string message, int val) : base(message)  
//     {
//         Value = val;  
//     }
// }









//задание 2
// using System;
// internal class Program
// {
//     static void Main(string[] args)  
//       {
//         try     
//         {
//             Gorod gorod1 = new Gorod("Primer", 1580, "Odesska", 500000);
//             Gorod gorod2 = new Gorod("Ivanova", 1789, "Nikolaevska", 80000);

//             Console.WriteLine(gorod1);
//             Console.WriteLine(gorod2);

//             gorod1 += 1000;  
//             Console.WriteLine($"\nПосле увеличения насиления: {gorod1}");

//             gorod1 -= 500;
//             Console.WriteLine($"\nПосле уменьшения насиления: {gorod1}\n");

//             Console.WriteLine($"Равно ли насиление: {gorod1 == gorod2}");
//             Console.WriteLine($"gorod1 > gorod2: {gorod1 > gorod2}");
//             Console.WriteLine($"gorod1 < gorod2: {gorod1 < gorod2}");
//             Console.WriteLine($"gorod1 != gorod2: {gorod1 != gorod2}");

             

//         }        
//         catch (ArgException ex)
//         {   Console.WriteLine($"Ошибка: {ex.Message}");
//             Console.WriteLine($"Некорректное значение: {ex.Value}");     
//         }
//         }
// }
// class Gorod{ 
//     private string nazvanie;
//     private int data;    
//     private string oblast; 
//     private decimal nasilenie;
//     public Gorod( string nazvanie, int data, string oblast, decimal nasilenie)
//     {   
//         this.nazvanie = nazvanie;      
//         this.data = data;
//         this.oblast=oblast; 
//         Nasilenie=nasilenie;
//     }
//     public decimal Nasilenie
//     {
//         get { return nasilenie; }
//         set
//         {
//             if (value < 0)
//             {
//                 throw new ArgumentException("Маленькое насиление");
//             }
//             nasilenie = value;
//         }
//     }
//     public static Gorod operator +(Gorod gorod, decimal amount)
//     {
//         gorod.Nasilenie += amount;
//         return gorod;
//     }
//     public static Gorod operator -(Gorod gorod, decimal amount)
//     {
//         gorod.Nasilenie -= amount;
//         return gorod;
//     }

// public static bool operator ==(Gorod gorod1, Gorod gorod2)
// {
//     return gorod1.Nasilenie == gorod2.Nasilenie;
// }

// public static bool operator <(Gorod gorod1, Gorod gorod2)
// {
//     return gorod1.Nasilenie < gorod2.Nasilenie;
// }

// public static bool operator >(Gorod gorod1, Gorod gorod2)
// {
//     return gorod1.Nasilenie > gorod2.Nasilenie;
// }
// public static bool operator !=(Gorod gorod1, Gorod gorod2)
// {
//     return !(gorod1 == gorod2);
// }

// public override string ToString()
// {       
//     return $"\nНазвание города: {nazvanie}\nДата основания: {data}\nОбласть: {oblast}\nНасиление: {nasilenie} чел";
// }
// }

// class ArgException : Exception
// {   public int Value { get; }
//     public ArgException(string message, int val) : base(message)  
//     {
//         Value = val;  
//     }
// }