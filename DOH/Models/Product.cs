using System.Diagnostics;

namespace DOH.Models
{
    [DebuggerDisplay("Product: {Name,nq}")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}