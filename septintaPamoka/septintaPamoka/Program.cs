using System;
using System.Collections.Generic;

namespace septintaPamoka
{
    public class Program
    {
        static void Main(string[] args)
        {
            WrteMyNameToconsole("Audrius");

            WrteMyNameXtimesToConsoel(10, "Audrius");

            StringConvertToCharp("Bananas");

            double kmi = ReturnsKMI(95.8, 1.85);
            Console.WriteLine($"yours kmi is {kmi}");


            int countedSpaces = CountsSpacesInstring("mašina gera ir  važiuoja .");
            Console.WriteLine($"Spaces number in string is {countedSpaces}");

            int[] newIntArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            (int sumOfitems, int NumberOfItems) = SumAndCountArrayElements(newIntArray);
            Console.WriteLine($"Array contains {NumberOfItems} items and the sum of items in array are {sumOfitems}");

            double poveredNumber = PowerNumber(8, 3);
            Console.WriteLine($"Yuor number powered and the answer is {poveredNumber}");

            int sumOfRange = SumOfElemtsInRange(3, 15);
            Console.WriteLine($"The sum from number to number is {sumOfRange}");
            int sumOfRange2 = SumOfElemtsInRange(3, 15, true);
            Console.WriteLine($"The sum from number to number is {sumOfRange2}");

            Console.WriteLine($"{ReversingWordOrSentence("bananas")}");

            var testList = new List<double>();

            testList = ReturnFibonaciList(10);
            foreach (var item in testList)
            {
                Console.WriteLine(item);

            }

            double sumOfBembersInNumber = SumOfElementsInNumber(1230000123);
            Console.WriteLine(sumOfBembersInNumber);

            double answer = ReturnFactorialOfNumber(5);
            Console.WriteLine(answer);

            static void WrteMyNameToconsole(string myName)
            {
                /*Parašyti funkciją, kuri išveda į
                konsolę Jūsų vardą */
                Console.WriteLine("lesson 7 task 1");
                Console.WriteLine("myName");

            }

            static void WrteMyNameXtimesToConsoel(int myNamesXTimes, string myName)
            {
                /*Parašyti funkciją, kuri išvedą į
                konsolę bet kokį vardą tiek kartų,
                kiek nurodo parametras. */
                Console.WriteLine("lesson 7 task 2");
                for (int i = 0; i < myNamesXTimes; i++)
                {
                    Console.WriteLine(myName);
                }
            }
            static void StringConvertToCharp(string myString)
            {
                /*Parašyti funkciją, kuri gauna string
                tipo parametrą. Funkcija turi gražinti
                eilutę su tiek „#“,kiek simbolių
                gautame parametre. */
                Console.WriteLine("lesson 7 task 3");
                Console.WriteLine(myString);
                for (int i = 0; i < myString.Length; i++)
                {
                    Console.Write("#");

                }
                Console.WriteLine();
            }

            static double ReturnsKMI(double weight, double height)
            {
                /*Prašyti funkciją, kuri gražina KMI */
                Console.WriteLine("lesson 7 task 4");

                return weight / Math.Pow(height, 2);
            }
            static int CountsSpacesInstring(string myString)
            {
                /*Parašyti funkciją, kuri suskaičiuoja ir
                gražina, kiek yra tarpų eilutėje */
                Console.WriteLine("lesson 7 task 5");
                char[] charArray = myString.ToCharArray();
                int count = 0;
                foreach (var item in charArray)
                {
                    if (item == ' ') count++;
                }
                return count;
            }

            static (int SumItems, int NumberOfItems) SumAndCountArrayElements(int[] array)
            {
                /* Parašyti funkciją, kuri paima int[]
                parametrą ir išveda elementų sumą,
                bei kiek tų elementų yra.
                Pvz.: Suma: 123, viso: 7 elementai
                */
                Console.WriteLine("lesson 7 task 6");
                int sumItems = 0;
                int countItems = array.Length;
                foreach (var item in array)
                {
                    sumItems += item;
                }
                return (sumItems, countItems);

            }
            static double PowerNumber(double number, double powerRate)
            {
                /*Parašyti funkciją, kuri pakelią vieną
                skaičių į antrojo laipsnį
                Pvz.: 2 ^ 3 = 8
                */
                Console.WriteLine("lesson 7 task 7");

                return Math.Pow(number, powerRate);
            }


            static string ReversingWordOrSentence(string enteredString)
            {
                /* Palindromas - (gr.palindromos - bėgantis atgal, grįžtantis):
                1.žodis, eilėraštis arba frazė, skaitomi iš kairės į dešinę ir
                iš dešinės į kairę, išlaikantys tą pačia prasmę
                pvz., lietuvių k. žodis: „Savas“, sakinys „Abu gaišo po šia guba“*/
                Console.WriteLine("lesson 7 task 9");
                char[] tempCharArray = enteredString.ToCharArray();
                string[] reverseString = new string[enteredString.Length];
                string returString = "";

                for (int i = enteredString.Length - 1; i >= 0; i--)
                {
                    reverseString[enteredString.Length -1 - i] = String.Join("", tempCharArray[i]);

                }
                //Array.Reverse(reverseString);
                foreach (var item in reverseString)
                {
                    returString += item;
                }
                    // tempCharArray;
                return returString;
            }

            static List<double> ReturnFibonaciList(int lenghtOfFiconaci)
            {
                /*Padaryti funkciją, kuri parodo X Fibonačio skaičių. Seka prasideda
                šiais skaičiais 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233…
                kiekvienas šios sekos skaičius lygus dviejų prieš jį einančių skaičių sumai*/
                Console.WriteLine("lesson 7 task 10");
                var fibonaciList = new List<double>();
                double x = 0;
                double y = 1;
                fibonaciList.Add(x);
                for (int i = 0; i < lenghtOfFiconaci; i++)
                {
                    double cache = x;
                    x = y;
                    y = cache + y;
                    fibonaciList.Add(y);
                }
                return fibonaciList;
            }

            static double SumOfElementsInNumber(double enteredNumber)
            {
                /*Parašyti funkciją, kuri suskaičiuoja atskirų
                bet kokio skaičiaus skaitmenų sumą */
                Console.WriteLine("lesson 7 task 11");
                double sumOfItiemsInNumber = 0;
                char[] tempCharArray = Convert.ToString(enteredNumber).ToCharArray();

                foreach (var item in tempCharArray)
                {
                    sumOfItiemsInNumber += Convert.ToInt32(Convert.ToString(item));
                }
                return sumOfItiemsInNumber;
            }
    
            static double ReturnFactorialOfNumber(int enteredNumber)
            {
                /*Parašyti rekursinę funkciją faktorialo skaičiavimui.
                Faktorialas – natūrinių skaičių sandauga
                nuo 1 iki natūrinio skaičiaus (imtinai).
                Žymima šauktuko (!) ženklu. Pvz: 5! = 1*2*3*4*5=120;*/
                Console.WriteLine("lesson 7 task 12");
                if (enteredNumber == 1)
                { 
                   return 1;
                }
                return enteredNumber * ReturnFactorialOfNumber(enteredNumber - 1);
            }




        }
        /* Parašyti 2 perkrautas funkcijas.
        1. Išveda skaičių sumą nuo ... Iki
        2. Gauna parametrus: int nuo, int iki,
        bool rodytiTarpineSuma
        Pvz: nuo 1, iki 5
        0+1=1, 1+2=3, 3+4=7, 7+5=12*/
        private static int SumOfElemtsInRange(int firstNum, int secondNum)
        {
            Console.WriteLine("lesson 7 task 8");
            int sumOfRange = 0;
            for (int i = firstNum; i <= secondNum; i++) sumOfRange += i;

            return sumOfRange;
        }

        private static int SumOfElemtsInRange(int firstNum, int secondNum, bool generateInterimResult)
        {
            Console.WriteLine("lesson 7 task 8");
            int sumOfRange = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                sumOfRange += i;
                if (generateInterimResult) Console.WriteLine($" {sumOfRange - i} + {i} =  {sumOfRange}");
            }
            return sumOfRange;
        }
    }
}




