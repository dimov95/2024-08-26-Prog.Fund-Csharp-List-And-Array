using System.ComponentModel;

namespace _04.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
           string  numbers = Console.ReadLine();
            string commande = "";
            //process
            List<int> manupulation = numbers
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            commande = Console.ReadLine();
            while (commande!= "end") 
            {

                string[] totalCommand = commande
                      .Split(" ")
                      .ToArray();
                if (totalCommand[0] == "Add")
                {
                    int number = int.Parse(totalCommand[1]);
                    manupulation.Add(number);
                }
                else if (totalCommand[0] == "Remove") //Remove {number}"
                {
                   
                     
                    int number = int.Parse( totalCommand[1]);
                        manupulation.Remove(number);
                     
                }
                else if (totalCommand[0] == "RemoveAt") //RemoveAt {index}: 
                {
                  
                    
                        int index = int.Parse(totalCommand[1]);
                    manupulation.RemoveAt(index);
                    
                }
                else if (totalCommand[0] == "Insert") //Insert {number} {index}": 
                {
                    int number = int.Parse(totalCommand[1]);
                    int index = int.Parse(totalCommand[2]);
                    manupulation.Insert(index, number);
                }

                commande = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", manupulation));
        }
    }
}
