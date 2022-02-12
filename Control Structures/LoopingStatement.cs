using System;
namespace Looping{
    class LoopingStatement{

        public int forloop(int startValue, int stopVal, int iter){
                int sum=0;
                for(iter=startValue;iter<=stopVal;iter++){
                    sum+=iter;
                }
                return sum;
        }
        public int WhileLoop(int startValue,int stopVal,int iter){
            int sum =0;
            iter=startValue;
            while(iter<=stopVal){
                sum+=iter;
                iter++;
            }
            
            return sum;
        }

        public int DoWhileLoop(int startValue,int stopVal, int iter){
            int sum=0;
            iter=startValue;
            do{
                sum+=iter;
                iter++;
            }
            while(iter<=stopVal);
            return sum;
        }
        //Driver Function
        public static void Main(String[] args){
            LoopingStatement l=new LoopingStatement();
           int startvalue, stopvalue,userInput;
           char iterator ='i';

           Console.Write("Enter Start Value:");
           startvalue=Convert.ToInt16(Console.ReadLine());
           Console.Write("Enter Stop Value:");
           stopvalue=Convert.ToInt16(Console.ReadLine());
           Console.Write("Which Method do you want to follow \n 1.For loop \n 2.While Loop \n 3.Do While Loop:");
           userInput=Convert.ToInt16(Console.ReadLine());


           if (userInput==1){
              Console.Write( l.forloop(startvalue,stopvalue,iterator));
           }
           else if(userInput==2){
               Console.Write(l.WhileLoop(startvalue,stopvalue,iterator));
           }
           else if(userInput==3){
               Console.Write(l.DoWhileLoop(startvalue,stopvalue,iterator));
           }

        }
    }
}