using System;

namespace ExceptionHandling {
   class DivNumbers {
      int result;
      
      DivNumbers() {
         result = 0;
      }
      public void division(int num1, int num2) {
         try {
            result = num1 / num2;
         } 
         catch (DivideByZeroException e) {
            Console.WriteLine("Exception caught: {0}", e);
         }
      }
      static void Main(string[] args) {
         DivNumbers d = new DivNumbers();
         d.division(25, 0);
      }
   }
}