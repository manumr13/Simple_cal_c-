//simple calculater

using System;

namespace calculater{
    class Calculater{
        static void Main(string[] args){

            Console.WriteLine("Enter the 1st and 2nd number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation you want to do +, -, /, *");
            string symbol = Console.ReadLine();
            switch(symbol){
                case "+":
                Console.WriteLine(num1+num2);
                break;
                case "-":
                Console.WriteLine(num1-num2);
                break;
                case "/":
                Console.WriteLine(num1/num2);
                break;
                case "*":
                Console.WriteLine(num1*num2);
                break;
                default:
                Console.WriteLine("enter the correct operation");
                break;
            }
            }
    }
}