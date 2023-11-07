namespace HB.MvcAppWDB.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; } 
    }

 
    public enum işlem
    {
        boya=1,
        kesme=2,
        perma=3
    }
    public class Randevu
    {

        public int Id { get; set; }
        public string MüşteriAdı { get; set; }
        public  işlem İşlem { get; set; }
        public DateTime RandevuTarih { get; set; }
    }
}
