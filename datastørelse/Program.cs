using System;

namespace datastørelse
{
    class Program
    {
        
        unsafe static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("The size of an integer is " + sizeof(int) + " bytes and can hold " + values(sizeof(int)) + " diffrent values");
            represent(sizeof(int));
            Console.WriteLine("The size of a char is " + sizeof(char) +" bytes and can hold " + values(sizeof(char)) + " diffrent values");
            represent(sizeof(char));
            Console.WriteLine("The size of an integerarray of size 5 is " + intarraysize(a) + " bytes and can hold " + values(intarraysize(a))+ " diffrent values");
            represent(intarraysize(a));
            Console.WriteLine("the size of a float is " + sizeof(float) + " bytes and can hold " + values(sizeof(float)) + " diffrent values");
            represent(sizeof(float));
            int b = 200;
            PrintVariableInformation(&b);
        }

        public static void represent(int i)
        {
            Console.WriteLine("+----------+");
            for(int s = 0; s < i; s++)
            {
                Console.WriteLine("|  1 bytes |");
                Console.WriteLine("+----------+");
            }
        }

        public static long values(int a)
        {
            int cycles = a * 8;
            long value = 1;
            for(int i = 0; i < cycles; i++)
            {
                value = value * 2;
            }

            return value;
        }
        
        public static int intarraysize(int[] a)
        {
            return sizeof(int) * a.Length;
        }

        public unsafe static void PrintVariableInformation(int* datatype)
        {
            unsafe
            {
                Console.WriteLine("the address of the variable is: " + Convert.ToString((long)&datatype, 16));
                //Console.WriteLine("and holds the value of: " + datatype);
            }
        }
    }
}
