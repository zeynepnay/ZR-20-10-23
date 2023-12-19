namespace P05_StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StringMethods
            //string name = "halil Umut MELER";
            //int len = name.Length;

            //Console.WriteLine(name + " metninin uzunluğu: " + len + " karakterdir.");
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());


            //string m1 = "Bahçeşehir";
            //string m2 = "Üniversitesi";
            //int year = 1996;
            //Console.WriteLine(m1+ " " + m2);
            //Console.WriteLine(String.Concat(m1," ",m2));
            //Console.WriteLine(m1 + " " + m2 + " " + year + " yılında kurulmuştur.");
            //Console.WriteLine(String.Concat(m1, " ", m2, " ", year, " yılında kurulmuştur."));
            //string result = $"{m1} {m2}";
            //string result2 = $"{m1} {m2} {year} yılında kurulmuştur.";

            //Console.WriteLine(result);
            //Console.WriteLine(result2);

            //string name = "Ece";
            //int age = 13;
            //string school = "Yeditepe İÖO";
            //string result = $"Ad: {name}\nYaş: {age}\nOkul: {school}";
            //Console.WriteLine(result);
            //Console.WriteLine($"{name}\t{age}\t{school}");

            //string courseName = "FullStack Web Developer Eğitimi";
            //string findText = "Web";
            //bool result=courseName.ToLower().Contains(findText.ToLower());
            //Console.WriteLine(result);

            //string name = "Zeyno";
            //Console.WriteLine(name.IndexOf("y"));  //tek karakter olduğu için tek tırnak kullanabildik.
            //Console.WriteLine(name.StartsWith("z"));
            //Console.WriteLine(name.EndsWith("o"));

            //string school = "Yeditepe İlköğretim Mektebi";
            //string result = school.Replace("Mektebi", "Okulu");
            //Console.WriteLine(result);

            //string title = "C#'ta Metinsel İşlemler";
            //Console.WriteLine(title.Replace(" " , "-").ToLower());
            //string text = "Bugün hava çok güzeldi.ama akşama doğru hava bozdu.Öylesine bozdu ki.";
            //Console.WriteLine(text.Replace("a" , "").Replace(".","")); //" " değil boşluk bile yok.

            string title = "Tesla, 2 milyon'dan fazla aracı otopilot yazılımını güncellemek için geri çağıracak!";
            Console.WriteLine(title);
            title = title.ToLower();
            title = title.Replace(" ", "-");
            title = title.Replace(",", "");
            title = title.Replace("'", "");
            title = title.Replace("ç", "c");
            Console.WriteLine(title);







            #endregion

            Console.ReadLine();
        }
    }
}