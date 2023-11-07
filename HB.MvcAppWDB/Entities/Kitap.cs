namespace HB.MvcAppWDB.Entities
{
    public class Kitap
    {

        public int Id { get; set; }
        public DateTime? BasımTarihi { get; set; }

        public string? KitapAdı { get; set; }
        public string YazarAdı  { get; set; }
        public int? KategoriID { get; set; }
        public Kategori Kategori { get; set; }
    }


}
