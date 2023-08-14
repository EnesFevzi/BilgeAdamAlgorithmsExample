namespace _07_OOPEncapsulationOgrenciClassi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Ogrenci ogrenci =new Ogrenci("Enes","Fevzi");
            ogrenci.DogumTarihi = new DateTime(1998, 8, 2);
            ogrenci.EkranaYazdir();

            Console.ReadLine();
        }
    }
}