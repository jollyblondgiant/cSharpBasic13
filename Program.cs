using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void PrintNumbers(){
            for(var idx =1; idx <= 255; idx ++){
                Console.WriteLine(idx);
            }
        }
        public static void PrintOdds(){
            for(var idx = 1; idx <=255; idx++){
                if(idx % 2 !=0){
                    Console.WriteLine(idx);
                }
            }
        }
        public static void PrintSum(){
            int sum = 0;
            for(var idx = 0; idx <=255; idx++){
                sum += idx;
                Console.WriteLine($"New Number: {idx} Sum: {sum}");
            }
        }
        public static void LoopArray(int[] numbers){
            foreach(int number in numbers){
                Console.WriteLine(number);
            }
        }
        public static void FindMax(int[] numbers){
            int max = numbers[0];
            foreach(int number in numbers){
                if(number > max){
                    max = number;
                }
            }
            Console.WriteLine($"Max = {max}");
        }
        public static void GetAverage(int[] numbers){
            int sum = 0;
            int count = 0;
            foreach(int number in numbers){
                sum += number;
                count ++;
            }
            sum /= count;
            Console.WriteLine($"Average of numbers is {sum}");
        }
        public static int[] OddArray(){
            List<int> odds = new List<int>{};
            for(var idx = 0; idx <=255; idx++){
                if(idx % 2 != 0){
                    odds.Add(idx);
                }
            }
            int[] oddArray = new int[odds.Count];
            for(var idx = 0; idx<= odds.Count; idx++){
                oddArray[idx] = odds[idx];
            }
            return oddArray;
        }
        public static int GreaterThanY(int[] numbers, int y){
            int numGreater = 0;
            foreach(int number in numbers){
                if(number > y){
                    numGreater ++;
                }
            }
            return numGreater;
        }
        public static int[] SquareArrayValues(int[] numbers){
            for(var idx = 0; idx < numbers.Length; idx ++){
                numbers[idx] *= numbers[idx];
            }
            return numbers;
        }
        public static int[] EliminateNegatives(int[] numbers){
            for(var idx = 0; idx < numbers.Length; idx++){
                if(numbers[idx] < 0){
                    numbers[idx] = 0;
                }
            }
            return numbers;
        }
        public static void MinMaxAverage(int[] numbers){
            int min = numbers[0];
            int max = numbers[0];
            int avg = 0;
            foreach(int number in numbers){
                avg += number;
                if(number > min){
                    max = number;
                }
                else if (number < min){
                    min = number;
                }
            }
            avg /= numbers.Length;
            Console.WriteLine($"Min: {min}; Max: {max}; Avg: {avg}");
        }
        public static void ShiftValues(int[] numbers){
            for(var idx = 0; idx<numbers.Length; idx ++){
                numbers[idx] = numbers[idx+1];
            }
            numbers[numbers.Length-1]=0;
        }
        public static object[] NumToString(int[] numbers){
            object[] arr = new object[numbers.Length];
            for(var idx = 0; idx < numbers.Length; idx++){
                if(numbers[idx] >= 0 ){
                    arr[idx] = numbers[idx];
                }
                if(numbers[idx]< 0){
                    arr[idx] = (string)"Dojo";
                }
            
            }
            return arr;
        }
    }
}
