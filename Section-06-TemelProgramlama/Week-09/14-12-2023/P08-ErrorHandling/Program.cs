namespace P08_ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            //int sayi1=Convert.ToInt32(Console.ReadLine());
            //int sayi2=Convert.ToInt32(Console.ReadLine());  

            //double result = Convert.ToDouble(sayi1/sayi2);

            //Console.WriteLine(result);

            /*uygulamalarımız çalıştıkları esnada bir takım hatalardan dolayı durabilir.
             * bu tür hatalara Run Time Errors(çalışma zamanı hataları) denir.
             * Run Time Errors'ı kontrol altına alabilmek için Try-Catch-Finally yapısını kullanacağız.
             *try
             *{
             *      Çalışmasını beklediğimiz kodları buraya yazacağız. yani hata verme olasılığı olan kodlar.dolayısıyla
             *      buraya yazdığımız kodları şu şekilde düşünebiliriz.Bu kodları çalıştırmayı DENE! çalışıyorsa
             *      hiçbir sorun olmadan devam eder,yani catch scope'unu atlar,çalıştırmaz.Çalışmıyorsa,hata varsa catch scope'una geçer.
             *} 
             *catch 
             *{
             *      eğer try scope'undaki kodda bir hata meydana gelirse bu bölümdeki kodlar çalışır.
             *}
             *finally
             *{
             *      try ya da catch scope'larından hangisi çalışmış olursa olsun , herhalükarda bu kısımda yazan kodlar çalıştırılır.
             *}
             
             */

            #endregion

            #region Sample01

            //Console.Write("Lütfen karesi alınacak sayıyı giriniz: ");
            //try
            //{
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    int sonuc = Convert.ToInt32(Math.Pow(sayi, 2));
            //    Console.WriteLine(sonuc);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Sample2
            try
            {
                Console.Write("Bölünen: ");
                int bolunen = int.Parse(Console.ReadLine());
                Console.WriteLine("bölen: ");
                int bolen = int.Parse(Console.ReadLine());
                int sonuc = bolunen / bolen;
                Console.WriteLine($"{bolunen} / {bolen} = {sonuc}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("0'a bölme yapılamaz.");

            }
            catch(FormatException ex)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata var.");
            }
            #endregion




            Console.ReadLine();
        }
    }
}