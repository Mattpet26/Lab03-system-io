using System;
using System.IO;
using Lab03;

namespace Lab03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide 3 numbers");
            string input = Console.ReadLine();
            string[] numbersInput = input.Split(" ");
            Console.WriteLine(MultiplyInput(numbersInput));
            Console.Clear();

            Console.WriteLine(medianNumber());

            ChallengeThree();
            ChallengeFour();
            Challenge5();
            challenge6();
            challenge7();

        }
        public static decimal MultiplyInput(string[] numbersInput)
        {
            decimal product = 1;
            try
            {
                if (numbersInput.Length < 3)
                {
                    return 0;
                }
                for (int i = 0;i < 3; i++ )
                {
                    decimal numToMult = Convert.ToDecimal(numbersInput[i]);

                    product = product * numToMult;
                }
                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine("Negative numbers or letters are not valid");
                return 0;
            }
        }
        public static decimal medianNumber()
        {
            decimal total = 0;
            do
            {
                Console.Write("Please provide a number between 2 - 10: ");
                string input = Console.ReadLine();
                int numbEntered = Convert.ToInt32(input);

                if (numbEntered < 2 || numbEntered > 10)
                {
                    Console.WriteLine("That number was lower than 2 or greater than 10.");
                }
                else
                {
                    for (int i = 1; i <= numbEntered; i++)
                    {
                        Console.WriteLine($"{i} of {numbEntered} - Enter a number: ");
                        decimal enteredNum = Convert.ToInt32(Console.ReadLine());
                        if(enteredNum < 0)
                        {
                            Console.WriteLine("Enter a number greater than 0!");
                            i--;
                        }
                        else
                        {
                            total += enteredNum;
                        }
                    }
                    return total / numbEntered;
                }
            } while (true);
            {

            }

        }
        static void ChallengeThree()
        {
            int charCounter = 1;
            int midpoint = (9 / 2) + 1;
            string ast;
            //0000*0000
            //000***000
            //00*****00
            while (charCounter < 4)
            {
                for (int i = 4; i <= 0; i--)
                {
                    Console.Write(" ");
                    for (int q = 1; q >= charCounter; q++)
                    {
                        Console.Write("*");
                    }
                }
                charCounter += 2;
                Console.WriteLine();
            }
        }

        public static void ChallengeFour()
        {
            Console.WriteLine("Challenge 4: Return the number with the most occurances");
            int[] arr = new int[] {1, 2, 1, 2, 1, 1, 3, 2, 1, 4, 5};
            MostCommonNumber(arr);
        }
        public static int MostCommonNumber(int[] arr)
        {
            int currentCounter = 1;
            int temp = 0;
            int popular = arr[0];
            int tempCounter;

            for(int i = 0; i < arr.Length; i++)
            {
                temp = arr[i];
                tempCounter = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    if(temp == arr[j])
                    {
                        tempCounter++;
                    }
                    if(tempCounter > currentCounter)
                    {
                        popular = temp;
                        currentCounter = tempCounter;
                    }
                }
            }
            Console.WriteLine(popular);
            return popular;
        }
        public static void Challenge5()
            {
                int[] arr = new int[] { 1, 2, 3, 4, 5 };
                FindMax(arr);
            }
        public static int FindMax(int[] arr)
        {
            int temp = 0;
            for(int i = 0;  i < arr.Length; i++)
            {
                if(arr[i] > temp)
                {
                    temp = arr[i];
                }
            }
            Console.WriteLine(temp);
            return temp;
        }
        public static void challenge6()
        {
            string path = "../../../words.txt";
            Console.WriteLine("Please input a word, we will add it to our system");
            OverWrite(path);
        }
        static void OverWrite(string path)
        {
            string input = Console.ReadLine();
            File.WriteAllText(path, input);
        }
        public static void challenge7()
        {
            string path = "../../../words.txt";
            ReadPath(path);
        }
        public static void ReadPath(string path)
        {
            string textFile = File.ReadAllText(path);
            Console.WriteLine(textFile);
        }
    }
}






















































//string path = "../../../TextFile1.txt";
//ReadFileText(path);
//ReadRawFile(path);
//ReadFileLines(path);
//OverWrite(path);
//        }
//        static void ReadFileText(string path)
//{
//    string textFromFile = File.ReadAllText(path);
//    Console.WriteLine($"Here is what we got back from that file: ");
//    Console.WriteLine(textFromFile);
//}
//static void ReadRawFile(string path)
//{
//    byte[] bytes = File.ReadAllBytes(path);
//    foreach (byte readingbytes in bytes)
//    {
//        Console.Write($"{readingbytes} ");
//    }
//}
//static void ReadFileLines(string path)
//{
//    string[] lines = File.ReadAllLines(path);
//    foreach (var line in lines)
//    {
//        Console.WriteLine($"But now with lines: {line}");
//    }
//}
//static void OverWrite(string path)
//{
//    string words = "Here is new stuff for the file";
//    File.WriteAllText(path, words);
//    ReadFileLines(path);
//}
//        static void AppendText(string path)
//        {
//            string append = "Append this to the end";
//            File.AppendAllLines(path);
//        }
//    }