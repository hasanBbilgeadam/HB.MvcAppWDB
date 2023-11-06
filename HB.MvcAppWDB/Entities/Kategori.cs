namespace HB.MvcAppWDB.Entities
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Kitap> Kitaplar { get; set; } = new();
    }


}
