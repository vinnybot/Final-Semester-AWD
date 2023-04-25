namespace MVCHOT2.Models.DomainModels
{
    public class Category
    {

        public Category() => Products = new HashSet<Product>();
        public int CategoryID { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set;}
    }
}
