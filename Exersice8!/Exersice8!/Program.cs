namespace Exersice8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("give me a max number");
           int maxnumber= int.Parse(Console.ReadLine()); 
         
            for (int i = 0;
                i <= maxnumber; i = i+2) 
            { 
                Console.WriteLine(i);
            }
        }
    }
}