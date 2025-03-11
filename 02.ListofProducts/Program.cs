namespace _02.ListofProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int number = int.Parse(Console.ReadLine());
            
            //process 
                List<string> products = new List<string>();
            for (int i = 0; i < number; i++)
            {
                string produckt = Console.ReadLine();
                products.Add(produckt);

            }
            products.Sort();
            for (int i = 0;i < products.Count;i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
