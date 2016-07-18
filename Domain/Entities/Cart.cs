using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Cinema cinema, int quantity)
        {
            CartLine line = lineCollection
                .Where(g => g.Cinema.CinemaId == cinema.CinemaId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Cinema = cinema,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Cinema cinema)
        {
            lineCollection.RemoveAll(l => l.Cinema.CinemaId == cinema.CinemaId);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Cinema.Price * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }
    public class CartLine
    {
        public Cinema Cinema { get; set; }
        public int Quantity { get; set; }
    }
}
