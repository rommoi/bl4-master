﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
            string name = "blablabla";
            var time = DateTime.Now.TimeOfDay.Hours;
            if(time < 7)
            {
                Console.WriteLine("Good night! {0}", name);
            }
            else if(time >= 7 && time < 12)
            {
                Console.WriteLine("Good morning! {0}", name);
            }
            else if(time >= 12 && time <= 22 )
            {
                Console.WriteLine("Good day, good day! {0}", name);
            }
            else
            {
                Console.WriteLine("Good nught! {0}", name);
            }

        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            
        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            while (true)
            {
                //Label:
                var input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case 'w':
                        Console.WriteLine("\nMove Forward.\n");
                        
                        break;
                    case 'a':
                        Console.WriteLine("\nMove Left.\n");
                        break;
                    case 's':
                        Console.WriteLine("\nMove Back.\n");
                        break;
                    case 'd':
                        Console.WriteLine("\nMove Right.\n");
                        break;
                    case 'q':
                        return;
                    default:
                        Console.WriteLine("\nStay on place.\n");
                        break;
                }
                //goto Label;
            }
        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} \t {1}", i, i % 2 == 0 ? "Even" : "Odd");
            }
        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
            for (int i = 30; i > 0; i--)
            {
                if(i%3 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
            string row = String.Empty;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //Console.Write("{0}{1} ", i, j);
                    row += " " + j.ToString();
                    //Console.WriteLine("");
                    if (j == 9)
                    {
                        Console.WriteLine(row);
                        row = String.Empty;
                    }
                }
                Console.WriteLine();
            }
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
           
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            
        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
        }
    }
}
