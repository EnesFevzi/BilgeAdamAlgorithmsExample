namespace _02_OOPGirisClassTanimlamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel yeniPersonel = new Personel(); //new anahtar kelimesiyle yeniPersonel nesnesine Personel classın örneğini atıyoruz instance alıyoruz.
            yeniPersonel.PersonelID = 1;
            yeniPersonel.PersonelName = "Bilge";
            yeniPersonel.PersonelSurnname = "Adam";
            yeniPersonel.Unvan = "Mudur";
            yeniPersonel.PersonelMaasi = 10000;


            Console.WriteLine("Personel Bilgileri:"
                + "\n----------------------------- \n"
                + "\nPersonel ID :" + yeniPersonel.PersonelID
                + "\nPersonel Adı :" + yeniPersonel.PersonelName
                + "\nPersonel Soyadı :" + yeniPersonel.PersonelSurnname
                + "\nPersonel Unvanı :" + yeniPersonel.Unvan
                + "\nPersonel Maaşı :" + yeniPersonel.PersonelMaasi);

            Console.ReadLine();


        }
    }
}