using System.Collections;

namespace Ucu.Poo.Restaurant
{
    public class Pedido
    {
        private ArrayList order = new ArrayList();

        public ArrayList Order
        {
            get { return this.order; }
        }

        public void AddToOrder(Dish dish)
        {
            this.order.Add(dish);
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (Dish dish in this.order)
            {
                total += dish.Price;
            }
            return total;
        }
    }
}
//holi