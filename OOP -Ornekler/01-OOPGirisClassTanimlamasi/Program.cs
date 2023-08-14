namespace _01_OOPGirisClassTanimlamasi
{
    public class Program
    {



        static void Main(string[] args)
        {

            Utu utu1 = new Utu(); //  ==> instance yani örnek almak.....
            utu1.Marka = "Rowenta";  //Property e değer atadık..
            utu1.Renk = "Kırmızı";
            utu1.KazanliMi = true;
            utu1.Sicaklik = 0;
            Console.WriteLine($"ÜTÜ NESNESİ AŞAĞIDAKİ BİLGİLERLE YARATILDI!\nMarkası:{utu1.Marka}\nRengi:{utu1.Renk}\nSıcaklık:{utu1.Sicaklik}\nKazanli mi? {(utu1.KazanliMi ? "Evet" : "Hayır")}");

            Console.WriteLine();
            Console.WriteLine(new string('*', 30));
            Console.WriteLine();

            Utu utu2 = new Utu("Arçelik", "Beyaz", 0, false);

            Console.WriteLine();
            Console.WriteLine(new string('*', 30));
            Console.WriteLine();

            Utu utu3 = new Utu("Bosch");
            utu3.Renk = "Mavi";
            utu3.Sicaklik = 0;
            utu3.KazanliMi = true;

            Console.WriteLine();
            Console.WriteLine(new string('*', 30));
            Console.WriteLine();

            Utu utu4 = new Utu("Beko")
            {
                Renk = "Siyah",
                KazanliMi = true,
                Sicaklik = 0
            };

            Console.WriteLine();
            Console.WriteLine(new string('*', 30));
            Console.WriteLine();


            Utu utu5 = new Utu
            {
                Marka = "Tefal",
                Renk = "Siyah",
                KazanliMi = true,
                Sicaklik = 0
            };

            Console.WriteLine();
            Console.WriteLine(new string('*', 30));
            Console.WriteLine();


            Utu utu6 = new Utu("Arzum", "Mor", 0, true);
            utu6.Isin(50);



            Console.WriteLine();
            Console.WriteLine(new string('*', 30));
            Console.WriteLine();


            Utu utu7 = new Utu("Rowenta", null, default, default);
            utu7.Isin(200);

            Console.ReadLine();
        }
    }
}