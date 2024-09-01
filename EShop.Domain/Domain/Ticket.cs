using EShop.Domain.Identity;
using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Domain
{
    public class Ticket : BaseEntity
    {
        public Guid SportEventId { get; set; }
        public SportsEvents? SportEvent { get; set; }

        [Required]
        public double Price { get; set; }

        public virtual EShopApplicationUser? CreatedBy { get; set; }
        public virtual ICollection<TicketInShoppingCart>? ProductsInShoppingCart { get; set; }
        public ICollection<TicketInOrder>? ProductInOrders { get; set; }
    }
}
