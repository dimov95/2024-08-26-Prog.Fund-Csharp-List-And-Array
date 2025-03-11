using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;

namespace _05.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            string numbers = Console.ReadLine();
            string commande = "";
            //process
            List<int> manupulation = numbers
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            commande = Console.ReadLine();
            while (commande != "end")
            {

                string[] totalCommand = commande
                      .Split(" ")
                      .ToArray();
                if (totalCommand[0] == "Contains") //Contains {number}" 
                {
                    int number = int.Parse(totalCommand[1]);
                    if (manupulation.Contains(number))
                    { Console.WriteLine("Yes"); }
                    else
                    { Console.WriteLine("No such number"); }

                }
                else if (totalCommand[0] == "PrintEven") //PrintEven
                {

                    List<int> printEnev = new List<int>();
                    int sum = 0;
                    foreach (int number in manupulation)

                    {
                        if (number % 2 == 0)
                        {
                            printEnev.Add(number);
                        }
                    }
                    Console.WriteLine(string.Join(" ", printEnev));


                }
                else if (totalCommand[0] == "PrintOdd") //PrintOdd 
                {


                    List<int> printEnev = new List<int>();
                    int sum = 0;
                    foreach (int number in manupulation)

                    {
                        if (number % 2 == 1)
                        {
                            printEnev.Add(number);
                        }
                    }
                    Console.WriteLine(string.Join(" ", printEnev));

                }
                else if (totalCommand[0] == "GetSum") //GetSum 
                {
                    int sum = 0;
                    foreach (int number in manupulation)
                    {
                        sum += number;

                    }
                    Console.WriteLine(sum);
                }
                else 
                if (totalCommand[0] == "Filter") //Filter {condition} {number
                {
                    if (totalCommand[1] == "<")
                        {
                        char condition = char.Parse(totalCommand[1]);
                        int number21 = int.Parse(totalCommand[2]);

                        for (int i = 0; i < manupulation.Count ; i++)
                        {
                          int cuurentNumber = manupulation[i];
                            if (cuurentNumber >= number21) 
                            {
                                manupulation.Remove(manupulation[i]);
                                i--;
                            }
                        }
                        }
                        
                    else if (totalCommand[1] == ">")
                    {
                        char condition = char.Parse(totalCommand[1]);
                        int number21 = int.Parse(totalCommand[2]);

                        for (int i = 0; i < manupulation.Count; i++)
                        {
                            int cuurentNumber = manupulation[i];
                            if (cuurentNumber <= number21)
                            {
                                manupulation.Remove(manupulation[i]);
                                i--;
                            }
                        }
                    }
                    else if (totalCommand[1] == ">=")
                    {
                        char condition = char.Parse(totalCommand[1]);
                        int number21 = int.Parse(totalCommand[2]);

                        for (int i = 0; i < manupulation.Count; i++)
                        {
                            int cuurentNumber = manupulation[i];
                            if (cuurentNumber < number21)
                            {
                                manupulation.Remove(manupulation[i]);
                                i--;
                            }
                        }
                    }
                    else if (totalCommand[1] == "<=")
                    {
                        char condition = char.Parse(totalCommand[1]);
                        int number21 = int.Parse(totalCommand[2]);

                        for (int i = 0; i < manupulation.Count; i++)
                        {
                            int cuurentNumber = manupulation[i];
                            if (cuurentNumber > number21)
                            {
                                manupulation.Remove(manupulation[i]);
                                i--;
                            }
                        }
                    }

                }


                commande = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", manupulation));
        }
    }
}
