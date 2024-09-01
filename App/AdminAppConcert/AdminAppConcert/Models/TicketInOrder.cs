using System.Net.Sockets;

namespace AdminAppConcert.Models
{
    public class TicketInOrder
    {

        public Guid Id { get; set; }
        public Guid TicketId { get; set; }
        public Ticket? OrderedProduct { get; set; }

        public Guid OrderId { get; set; }
        public Order? Order { get; set; }
        public int Quantity { get; set; }
        public  EShopApplicationUser? CreatedBy { get; set; }
        public  ICollection<TicketInShoppingCart>? ProductsInShoppingCart { get; set; }
        public ICollection<TicketInOrder>? ProductInOrders { get; set; }
    }
}
