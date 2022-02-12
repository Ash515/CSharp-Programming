using System;

namespace DecisionMaking
{
    
    
    class DecisionMaking{
        
         public void result(int val){
           
            if((val>=0)&&(val<=10)){
                   Console.Write("Your Value is present inbetween 0 to 10 Right?");
                   Console.ReadKey();
                   
            }
            else if((val>=11)&&(val<=20)){
                Console.Write("Your Value is present inbetween 11 to 20 Right?");
                Console.ReadKey();
            }
            else if((val>=21)&&(val<=30)){
                Console.Write("Your Value is present inbetween 21 to 30 Right?");
                Console.ReadKey();
            }
            else if((val>=31)&&(val<=40)){
                Console.Write("Your Value is present inbetween 31 to 40 Right?");
                Console.ReadKey();
            }
            else if((val>=41)&&(val<=50)){
                Console.Write("Your Value is present inbetween 41 to 50 Right?");
                Console.ReadKey();
            }
            else{
                Console.Write("Please Enter the correct range of value");
            }
        }
        public static void Main(string[] args){
            DecisionMaking d= new DecisionMaking();

            string userInput;
            int value;
             Console.WriteLine("Enter any Interger value between 0 to 50:");
             userInput=Console.ReadLine();
             value=Convert.ToInt32(userInput);
             d.result(value);
             
    }
     

}
}