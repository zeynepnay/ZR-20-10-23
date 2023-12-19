namespace P04_ReferenceTypes
{
    class Product
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number1=50;

            Random random = new Random();

            int sayi1=random.Next();

            Console.WriteLine(sayi1);

            Product urun1 = new Product();

            Console.ReadLine();
        }
    }
}