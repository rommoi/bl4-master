using System;
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
            Console.WriteLine("Enter a word.");
            string word = Console.ReadLine();

            int lCounter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if(word[i] == 'a')
                {
                    lCounter++;
                }

            }
            Console.WriteLine("Letter \"a\" in word {0}, meet {1} times...", word, lCounter);
            Console.ReadLine();

        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            Console.WriteLine("So let print back alphabet.");

            for (int i = 'z'; i >= 'a'; i--)
            {
                Console.Write(char.ToUpper(Convert.ToChar(i)));
                Console.Write(Convert.ToChar(i) + " ");
            }
            Console.ReadLine();
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
            Console.WriteLine("Input number");
            double var1 = 0;
            if (!double.TryParse(Console.ReadLine(), out var1))
            {
                Console.WriteLine("Wrong input...");
                return;
            };
            Console.WriteLine("Input extent");
            double var2 = 0;
            if (!double.TryParse(Console.ReadLine(), out var2))
            {
                Console.WriteLine("Wrong input...");
                return;
            };
            double result = 0;
            var2--;
            

                if (var2 == 0)
                {
                    Console.WriteLine("Result : 1");
                    return;
                }

                if ((var2 % 1) != 0)
                {
                    Console.WriteLine("Please input correct number...");
                    return;
                }
                if (var2 < 0)
                {
                    result = var1;
                    while (var2 < 0)
                    {
                        result /= var1;
                        var2++;
                    }
                }
                else
                {
                    result = var1;
                    while (var2 > 0)
                    {
                        result *= var1;
                        var2--;
                    }
                }
            
            Console.WriteLine("Result {0}", result);
            Console.ReadLine();

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
            int player1Score = 0;
            int player2Score = 0;

            int roundNumber = 1;

            Random rnd = new Random();

            while (true)
            {
                Console.WriteLine("round {0}...", roundNumber);
                int diceValue = rnd.Next(1, 7);
                Console.WriteLine("Player 1 throw dice... result {0}", diceValue);
                player1Score += diceValue;

                if(player1Score > 25)
                {
                    Console.WriteLine("We got winner!!! player 1");
                    return;
                }

                diceValue = rnd.Next(1, 7);
                Console.WriteLine("Player 2 throw dice... result {0}", diceValue);
                player2Score += diceValue;

                if(player2Score > 25)
                {
                    Console.WriteLine("We got winner!!! player 2");
                    return;
                }

                Console.WriteLine("\nPlayer 1 position {0}.\nPlayer 2 position {1}.", player1Score, player2Score);
                roundNumber++;

                Console.WriteLine("Press enter...");
                Console.ReadLine();

            }
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            List<int> numList = new List<int>();

            for (int i = 1; i < 101; i++)
            {
                numList.Add(i);
            }
            List<string> questions = new List<string>()
            {
                "Your number have 3 digits?",
                "Your number have 2 digits?",
                "Your number have 1 digit?",
                "Your number is even?",
                "Your number is odd?",
                "Your number is grater then",
                "Your number is less then"
            };

            while (true)
            {
                Console.WriteLine(questions[0] + " Press y or n");
                if(Console.ReadKey().KeyChar == 'y')
                {
                    Console.WriteLine("Your number is 100 :)");
                    return;
                }
                else
                {
                    numList.Remove(100);
                    questions.Remove("Your number have 3 digits?");
                }
                Console.WriteLine("Next question:");
                Console.WriteLine(questions[0] + " Press y or n"); // number have 2 digits
                if(Console.ReadKey().KeyChar == 'y')
                {
                    numList.RemoveRange(0, 10);
                }else
                {
                    numList.RemoveRange(10, (numList.Count - 10));
                }
                questions.Remove("Your number have 2 digits?");
                questions.Remove("Your number have 1 digit?");

                Console.WriteLine("Next question:");
                Console.WriteLine(questions[0] + " Press y or n"); // your number is even
                if(Console.ReadKey().KeyChar == 'y')
                {
                    numList.RemoveAll(x => x % 2 != 0);
                }else
                {
                    numList.RemoveAll(x => x % 2 == 0);
                }
                questions.Remove("Your number is even?");
                questions.Remove("Your number is odd?");

                while (true)
                {
                    int midPos = numList.Count / 2;

                    Console.WriteLine(questions[0] + " {0}", numList[midPos]);

                    //foreach (var item in numList)
                    //{
                    //    Console.Write(item + " ");
                    //}
                    //Console.WriteLine("\n" + midPos + " \n");

                    if(Console.ReadKey().KeyChar == 'y')
                    {
                        numList.RemoveRange(0, midPos);
                    }else
                    {
                        //foreach (var item in numList)
                        //{
                        //    Console.Write(item + " ");
                        //}
                       
                        numList.RemoveRange(midPos + 1, numList.Count - midPos - 1);
                        if (numList.Count == 2)
                        {
                            Console.WriteLine("Your number is less then {0}", numList[midPos]);
                            if (Console.ReadKey().KeyChar == 'y')
                            {
                                Console.WriteLine("Your number is {0}", numList[0]);
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Your number is {0}", numList[midPos]);
                                return;
                            }
                        }
                    }

                    //Console.WriteLine(questions[1] + " {0}\n", numList[numList.Count-1]);
                    //if(Console.ReadKey().KeyChar == 'y')
                    //{
                    //    numList.RemoveAt(numList.Count-1);
                    //}else
                    //{
                    //    Console.WriteLine("Your number is {0}!!! :)", numList[numList.Count-1]);
                    //    return;
                    //}
                }

            }



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
            Console.WriteLine("Input your word please.");
            string word = Console.ReadLine();
            string reversedWord = String.Empty;

            Console.WriteLine("for loop ---------------");
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            Console.WriteLine(word + "\n");
            Console.WriteLine(reversedWord);

            Console.WriteLine("\n while loop --------------");

            reversedWord = String.Empty;
            int counter = word.Length - 1;
            while(counter >= 0)
            {
                reversedWord += word[counter];
                counter--;
            }

            Console.WriteLine(word + "\n");
            Console.WriteLine(reversedWord);

            Console.WriteLine("\n foreach loop --------------");

            //reversedWord = String.Empty;
            StringBuilder strB = new StringBuilder();
            foreach (var item in word)
            {
                strB.Insert(0, item.ToString(), 1);
            }

            Console.WriteLine(word + "\n");
            Console.WriteLine(strB.ToString());







        }
    }
}
