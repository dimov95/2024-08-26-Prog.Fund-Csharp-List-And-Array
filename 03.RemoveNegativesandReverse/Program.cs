namespace _03.RemoveNegativesandReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            List <int> ints = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


            //process
           for (int i = 0;i < ints.Count; i++ )
            {
                if (ints[i] < 0)

                {
                    ints.RemoveAt(i);
                    i--;
                }

            }
               if (ints.Count == 0)
                Console.Write($"empty");
               else
            for (int i = ints.Count -1; i >= 0; i--)
            {
         

                Console.Write($"{ints[i]} ");
                    
            }

        }
    }
}
