﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 5,0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. RecursiveEven"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    //case '5':
                    //    RecursiveEven();
                    //    break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

 

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            
            do
            {
                Console.WriteLine("Add or remove input from the list");

                List<string> theList = new List<string>();
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                //do
                //{
                if (nav == '0') { break; }

                //while(true)
                // {
                switch (nav)
                {
                    case '+':
                        theList.Add(Console.ReadLine());
                        break;
                    case '-':
                        theList.Remove(Console.ReadLine());
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Use only + or -");
                        break;

                }
            } while(true);
            //}
            //} while (true);

        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            do
            {
                Console.WriteLine("Enqueue items '+' or dequeue items '-'.");
                Queue<string> strQ = new Queue<string>();
            string input = Console.ReadLine();
            char nav = input[0];
            string value = input.Substring(1);

            switch (nav)
            {
                case '+':
                    strQ.Enqueue(Console.ReadLine());
                    break;
                case '-':
                    strQ.Dequeue();
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Use only + or -");
                    break;

            }
            } while (true);
        }

            /// <summary>
            /// Examines the datastructure Stack
            /// </summary>
            static void ExamineStack()
            {
                /*
                 * Loop this method until the user inputs something to exit to main menue.
                 * Create a switch with cases to push or pop items
                 * Make sure to look at the stack after pushing and and poping to see how it behaves
                */
                do
                {
                Console.WriteLine("Push items '+' or Pop '-'.");
                    Stack myStack = new Stack();
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        myStack.Push(Console.ReadLine());
                        break;
                    case '-':
                        myStack.Pop();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Use only + or -");
                        break;

                }
            } while (true);


        }


        static void CheckParanthesis()
        {
                    /*
                     * Use this method to check if the paranthesis in a string is Correct or incorrect.
                     * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
                     * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
                     */
                    do
                    {

                        bool error = false;
            var str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (var item in str.ToCharArray())
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    stack.Push(item);
                }
                else if (item == ')' || item == '}' || item == ']')
                {
                    if (stack.Peek() != ComplementParenthesis(item))
                    {
                        error = true;
                        break;
                    }
                }
            }

            if (error)
                Console.WriteLine("Incorrect brackets");
            else
                Console.WriteLine("Brackets are fine");
            Console.ReadLine();
             static char ComplementParenthesis(char item)
            {
                switch (item)
                {
                    case ')':
                        return '(';
                    case '}':
                        return '{';
                    case ']':
                        return '[';
                    default:
                        return ' ';
                }
            }
            } while (true);
        }
        public int RecursiveEven(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            return(RecursiveEven(2*(n-1))+2);
        }
        public int Fibonacci(int n)
        {
            if (n==0)
            {
                return 1;
            }
            return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }


    }
}
