namespace _03_OOPEncapsulationUtuClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utu utu = new Utu()
            {
                Marka = "Tefal",
                Renk = "Beyaz",
                Sicaklik = 0
            };

            Console.WriteLine(
                $"Ütü Nesnesi Oluşturuldu!\n"
                + "\nMarkası" + utu.Marka
                + "\nRengi" + utu.Renk
                + "\nSıcaklığı" + utu.Sicaklik);

            //Ütünün sıcaklığını arttıralım

            for (int i = 0; i < 10; i++)
            {
                utu.Isin(12);
                Console.WriteLine("Ütünün şu anki sıcaklığı {0} derecedir",utu.Sicaklik);
            }
            Console.ReadLine();
        }
    }
}