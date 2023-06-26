namespace Reversing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a text to be reversed");
            Reverse reversed = new Reverse();
            string text=Console.ReadLine(); 
            reversed.ReverseMethod(text);
        }
    }
}