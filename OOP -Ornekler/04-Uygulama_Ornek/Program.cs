namespace _04_Uygulama_Ornek
{
    internal class Program
    {//Klavyeden girilen iki sayının toplamı ve farkını bulan toplama ve çıkarma isimli farklı sınıf ile yapınız.
        static void Main(string[] args)
        {
            Console.WriteLine("1.sayıyı girin");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı girin");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Toplama toplama = new(sayi1, sayi2);
            Console.WriteLine("Toplama İşslemi Sonucu :" + toplama.Toplamaİslemi());
            Cikarma cikarma = new Cikarma(sayi1, sayi2);
            Console.WriteLine("Çıkarma İşslemi Sonucu :" + cikarma.Cikarmaİslemi());
            Console.ReadLine();
        }
    }
}