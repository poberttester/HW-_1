

using System;
using System.Collections;
class HelloWorld {
  static void Main() {
      
      string input = " "; // переменная для ввода чисел пользователем
      var numbers = new ArrayList(); // хранилище для чисел, которые ввёл пользователь
      
      
      Console.Write("Введите целые числа для сравнения. По завершении введите '>' чтобы продолжить: ");
    
    
        while(input != ">"){
           
        input = Console.ReadLine();
        bool result_convert = int.TryParse(input, out int number);
        
            if(result_convert == true){
             numbers.Add(number);
            }
            else if (input == ">"){}
            else{
             Console.WriteLine("Параметр " + input + " введён неверно, попробуйте ещё раз.");
            }
        }
        
        
        
      
  }
  //  функция дл нахождения Максимального числа
  public void Max(ArrayList numb){
   int max = 0;
   
   for(int i = 1; i < numb.Count; i++){
       
       
       if((int)numb[max] < (int)numb[i]){
           numb[max] = numb[i];
       }
   }
   
   Console.WriteLine("Максимальное число: " + numb[max]);
  }
  
  
  //  функция дл нахождения Максимального и минимального чисел
  public void MaxMin(ArrayList numb){
   int max = 0, min = 0;
   
   for(int i = 1; i < numb.Count; i++){
       
       
       if((int)numb[max] < (int)numb[i]){
           numb[max] = numb[i];
       }
   }
   
   Console.WriteLine("Максимальное число: " + numb[max]);
  }
}
