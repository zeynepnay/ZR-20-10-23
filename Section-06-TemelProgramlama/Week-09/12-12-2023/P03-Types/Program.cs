namespace P03_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DataTypes
            //C#'ta veri tipleri çok önemlidir.Çeşitli veri tipleri bulunmaktadır.Özellikle sayılar ve sayı olmayanlar şeklinde incelemek iyi olacaktır.
            //TAM SAYILAR
            byte sayi1 = 255; //8bit'lik yer alıyor.
            sbyte sayi2 = -127; //ya da +127 olabilir. bu da 8bit çünkü 
            sbyte sayi3 = 15;
            Console.WriteLine(sayi1 + " sayısının alabileceği minimum değer:" + byte.MinValue);
            Console.WriteLine(sayi1 + " sayısının alabileceği maximum değer:" + byte.MaxValue);
            Console.WriteLine(sayi1 + " sayısının bellekte kapladığı alan:" + sizeof(byte) + "byte" );
            Console.WriteLine(sayi2 + "-" + sizeof(sbyte)+ "byte");
            Console.WriteLine(sayi2 + "-" + sizeof(double) + "byte");

            #endregion

            Console.ReadLine();

        }
    }
}