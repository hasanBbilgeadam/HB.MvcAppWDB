namespace HB.MvcAppWDB.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; } 
    }


    public class Kitap
    {

        public int Id { get; set; }
        public DateTime? BasımTarihi { get; set; }
        public string YazarAdı  { get; set; }
        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
    }
    public class Kategori
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Kitap> Kitaplar { get; set; } = new();
    }


}
