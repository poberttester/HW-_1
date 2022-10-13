

using System;
using System.Collections;
class HelloWorld {
  static void Main() {
      
      string input = " "; // переменная для ввода чисел пользователем
      ArrayList numbers = new ArrayList(); // хранилище для чисел, которые ввёл пользователь
      
      
      
      
      //  запуск программы ввода чисел в список
      Console.Write("Введите целые числа для сравнения. По завершении введите '>' чтобы продолжить: ");
      Console.WriteLine(" ");
    
        while(input != ">"){
           
        input = Console.ReadLine();
        bool result_convert = int.TryParse(input, out int number);
        
            if(result_convert == true){
             numbers.Add(number);
            }
            else if (input == ">"){}
            else{
             Console.WriteLine("Параметр ' " + input + " ' введён  неверно,  попробуйте  ещё  раз.");
             Console.WriteLine(" ");
            }
        }
        
        
        
        
        //  запуск функций программы
        while(input != "Q"){
            
            Console.WriteLine(" ");
            Console.WriteLine("Введите то, что вам нужно из списка");
            Console.WriteLine("max - для рассчёта максимального числа;");
            Console.WriteLine("max_min - для рассчёта максимального и минимального чисел;");
            Console.WriteLine("q - для выхода в предыдущее меню;");
            Console.WriteLine("Q - для выхода из программы.");
            input = Console.ReadLine();
            Console.WriteLine(" ");
            
            if(input == "max"){
                Max(numbers);
            } else if(input == "max_min"){
                MaxMin(numbers);
            } else if(input == "q"){
                
                //  повторный запуск программы ввода чисел в список
                ArrayList newNumbers = new ArrayList(); // ещё одно хранилище для чисел, которые ввёл пользователь
                Console.WriteLine(" ");
                Console.Write("Введите целые числа для сравнения. По завершении введите '>' чтобы продолжить: ");
                Console.WriteLine(" ");
                
                while(input != ">"){
           
                    input = Console.ReadLine();
                    bool result_convert = int.TryParse(input, out int number);
        
                    if(result_convert == true){     newNumbers.Add(number);      }
                    else if (input == ">"){}
                    else{   Console.WriteLine("Параметр  " + input + "  введён  неверно,  попробуйте  ещё  раз.");           }
                }
            } 
        }
        
        
        
      
  }
  //  функция дл нахождения Максимального числа
  public static void Max(ArrayList numb){
   int max = 0;
   
   for(int i = 1; i < numb.Count; i++){
       
       
       if((int)numb[max] < (int)numb[i]){
           numb[max] = numb[i];
       }
   }
   
   Console.WriteLine("Максимальное число: " + numb[max]);
  }
  
  
  //  функция дл нахождения Максимального и минимального чисел
  public static void MaxMin(ArrayList numb){
   int max = 0, min = 0;
   
   for(int i = 1; i < numb.Count; i++){
       
       
       if((int)numb[max] < (int)numb[i]){
           numb[max] = numb[i];
       }
   }
   
   Console.WriteLine("Максимальное число: " + numb[max]);
  }
}
