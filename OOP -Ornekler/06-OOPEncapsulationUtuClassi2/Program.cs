namespace _06_OOPEncapsulationUtuClassi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utu utu = new Utu();
            Console.Write("Lütfen ütünün markasını giriniz");
            utu.Marka = Console.ReadLine();
            Console.Write("Lütfen ütünün rengini giriniz");
            utu.Renk = Console.ReadLine();

            utu.Sicaklik = 0;

            Console.WriteLine(new string('#', 30));


            Console.WriteLine($"ÜTÜ YARATILDI!\nMarkası: {utu.Marka} \nSıcaklığı {utu.Sicaklik} \nRengi: {utu.Renk}");

            Console.ReadLine();
        }
    }
}