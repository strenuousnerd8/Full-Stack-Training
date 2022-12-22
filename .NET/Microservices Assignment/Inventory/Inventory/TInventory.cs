using System.ComponentModel.DataAnnotations;

namespace Inventory
{
    public class TInventory
    {
        [Key]
        public String airline { get; set; }

        public String from { get; set; }

        public String to { get; set; }

        public DateTime schedule { get; set; }

        public String instrument { get; set; }
    }
}
