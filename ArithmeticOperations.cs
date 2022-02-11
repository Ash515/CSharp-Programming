using System;

namespace Arithmetics{

    class ArithmeticProgram{
        public int Addition(int a, int b, int c){
               return a+b+c;
        }
        public int  Subtraction(int a, int b, int c){
               return a-b-c;
        }
        public int Multiplication(int a, int b, int c){
               return a*b*c;
        }
        public int Division(int a, int b){
               return a/b;
        }
        public static void Main(String[] args){
            ArithmeticProgram ap = new ArithmeticProgram();
            int add_res= ap.Addition(10,20,30);
            int sub_res= ap.Subtraction(10,20,30);
            int mul_res= ap.Multiplication(10,20,30);
             int div_res= ap.Division(10,30);
            Console.WriteLine(add_res);
            Console.WriteLine(sub_res);
            Console.WriteLine(mul_res);
            Console.WriteLine(div_res);
        }
    }
}