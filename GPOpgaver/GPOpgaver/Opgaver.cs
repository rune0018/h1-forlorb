﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GPOpgaver
{
    public static class Opgaver
    {
        /*
        * Introduktion til Algoritmer
        * Exercise 1. 
        * Make an algorithm that interchanges the values of the variables x and y, using only assignment statements.
        * What is the minimum number of assignment statements needed to do so?
        */
        public static void Interchange(ref int x, ref int y)
        {
            int x1 = y;
            y = x;
            x = x1;
            //Write your solution here
        }
        /*
        * Introduktion til Algoritmer
        * Exercise 2. 
        * Make an algorithm that uses only assignment statements to replace thevalues of the triple(x, y, z) with (z, x, y).
        * What is the minimum number of assignment statements needed?
        */
        public static void InterchangeTriple(ref int x, ref int y, ref int z)
        {
            int x1 = x,y1= y;
            x = z;
            z = y1;
            y = x1;
            //Write your solution here
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 3.
         * A palindrome is a string that reads the same forward and backward.
         * Make an algorithm for determining whether a string of n characters is a palindrome and output true or false.
         */
        public static bool IsPalindrome(string s)
        {
            int indeks = 1;
            foreach (char letter in s){
                if (!(letter == s[s.Length - indeks]))
                    return false;
                indeks++;
            }
            return true;
            //Write your solution here
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 4.a.
         * List all the steps used to search for 9 in the sequence 1, 3, 4, 5, 6, 8, 9, 11
         * Do this by completing the unit test for 4A
         * The solution should return the number of steps that it goes through to complete the unit test
         */
        public static int StepsInLinearSearch(int searchFor, int[] intergerArray)
        {
            for(int indeks = 0; indeks < intergerArray.Length; indeks++)
            {
                if (intergerArray[indeks] == searchFor)
                    return indeks+1;
            }
            return 0;
            //Write your solution here
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 4.b.
         * List all the steps used to search for 9 in the sequence 1, 3, 4, 5, 6, 8, 9, 11
         * Do this by completing the unit test for 4B
         * The solution should return the number of steps that it goes through complete the unit test
         */
        public static int StepsInBinarySearch(int[] integerArray, int arrayStart, int arrayEnd, int searchFor)
        {
            int mid = arrayStart + (arrayEnd-arrayStart) / 2;
            
            if(integerArray[mid] == searchFor)
                return 1;

            if (integerArray[mid] < searchFor)
                return 1 + StepsInBinarySearch(integerArray, mid, arrayEnd, searchFor);

            if (integerArray[mid] > searchFor)
                return 1 + StepsInBinarySearch(integerArray, arrayStart, mid - 1, searchFor);
            return -1;
            //Write your solution here
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 5.
         * Describe an algorithm based on the linear search for de-termining the correct position in which to insert a new element in an already sorted list.
         */
        public static int InsertSortedList(List<int> sortedList, int insert)
        {
            throw new NotImplementedException();
            //Write your solution here
        }
        /*
         * Exercise 6.
         * Arrays
         * Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num up to length.
         * Notice that num is also included in the returned array.
         */
        public static int[] ArrayOfMultiples(int num, int length)
        {
            throw new NotImplementedException();
            //Write your solution here
        }
        /*
         * Exercise 7.
         * Create a function that takes in n, a, b and returns the number of values raised to the nth power that lie in the range [a, b], inclusive.
         * Remember that the range is inclusive. a < b will always be true.
         */
        public static int PowerRanger(int power, int min, int max)
        {
            throw new NotImplementedException();
            //Write your solution here
        }
        /*
         * Exercise 8.
         * Create a Fact method that receives a non-negative integer and returns the factorial of that number.
         * Consider that 0! = 1.
         * You should return a long data type number.
         * https://www.mathsisfun.com/numbers/factorial.html
         */
        public static long Factorial(int n)
        {
            throw new NotImplementedException();
            //Write your solution here
        }
        /*
         * Exercise 9.
         * Write a function which increments a string to create a new string.
         * If the string ends with a number, the number should be incremented by 1.
         * If the string doesn't end with a number, 1 should be added to the new string.
         * If the number has leading zeros, the amount of digits should be considered.
         * exampel: 
         * wow0849 -> wow0850
         * test99 -> test100
         */
        public static string IncrementString(string txt)
        {
            throw new NotImplementedException();
            //Write your solution here
        }
        /*
         * Exercise 10.
         * Write a method to validate a sercure password.
         *     The password must contain at least one uppercase character.
         *     The password must contain at least one lowercase character.
         *     The password must contain at least one number.
         *     The password must contain at least one special character 
         *     The password must not contain other special characters then ! @ # $ % ^ & * ( ) + = - { } [ ] : ; " ' ? < > , . _
         *     The password must be at least 8 characters in length.
         *     The password must not be 25 characters or over in length.
         */
        public static bool ValidatePassword(string password)
        {
            throw new NotImplementedException();
            //Write your solution here
        }
    }
}