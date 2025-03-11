using Microsoft.VisualBasic.FileIO;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        //input
        string numbers = Console.ReadLine();
        List<int> firstlist = numbers.Split(" ").Select(int.Parse).ToList().ToList();

        //process

        string commande = "";
        while ((commande = Console.ReadLine()) != "end")
        

                {
            string[] checkc = commande.Split(" ").ToArray();

            
            
                if (checkc[0] == "Delete")
                {
                    int intIndex1 = int.Parse(checkc[1]);
                    while (firstlist.Contains(intIndex1))
                        firstlist.Remove(intIndex1);
                }
                else if (checkc[0] == "Insert")
                {
                int intIndex1 = int.Parse(checkc[1]);
                int indexToInsert = int.Parse(checkc[2]);
                firstlist.Insert(indexToInsert, intIndex1);
                }
                
            
        }

        Console.WriteLine(string.Join(" ", firstlist));
    }
}