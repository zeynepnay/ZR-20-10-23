namespace P06_NumberMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number1 = 40;
            //int number2 = 60;
            //Console.WriteLine($"En küçük: {Math.Min(number1, number2)}");
            //Console.WriteLine($"En büyük: {Math.Max(number1, number2)}");

            //int sayi = 4;
            //int us = 2;
            //Console.WriteLine("double max value0" + double.MaxValue);
            //Console.WriteLine("int max value" + int.MaxValue);


            //int sonuc = Convert.ToInt32(Math.Pow(sayi, us));
            //Console.WriteLine(sonuc);

            //int sonuc2 = int.MaxValue;
            //Console.WriteLine(Convert.ToInt32(sonuc2+1));

            //Console.Write("Bir sayı giriniz.");
            //int number1=Convert.ToInt32(Console.ReadLine());

            //Console.Write("Bir sayı daha giriniz.");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number1+number2);

            //kullanıcıdan taban ve üs sayılarını alıp tabanının üssüncü kuvvetini hesaolayarak konsola yazdıran kodu yazınız.

            //Console.Write("tabanı giriniz: ");
            //int taban= Convert.ToInt32(Console.ReadLine());
            //Console.Write("üssü giriniz: ");
            //int us=Convert.ToInt32(Console.ReadLine());

            //int sonuc=Convert.ToInt32(Math.Pow(taban,us));
            //Console.WriteLine($"{taban} sayısının {us}. kuvveti : {sonuc}");
            //Console.WriteLine(sonuc);


            double sayi = 5.46959;
            Console.WriteLine($"Ceiling: { Math.Ceiling(sayi)}");
            Console.WriteLine($"Floor: {Math.Floor(sayi)}");
            Console.WriteLine($"Round: {Math.Round(sayi)}");

            Console.WriteLine($"Round2: {Math.Round(sayi,2)}");

            Console.WriteLine($"Round3: {Math.Round(sayi,4)}");







            Console.ReadLine();
        }


        
    }
}