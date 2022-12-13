using System.Collections.ObjectModel;

namespace TutorialApp
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string? Name { get; set; }

        public virtual Collection<Product>? Products { get; set; }
    }
}
