//------------------------------------------------------------------------------
// <copyright file="Table.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {

        private ArrayList order = new ArrayList();
        /// <summary>
        /// Número de la mesa.
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// Indica si la mesa está ocupada.
        /// </summary>
        public bool IsOccupied { get; private set; }

        /// <summary>
        /// Obtiene la orden actual asociada a la mesa.
        /// </summary>
        public ArrayList Order
        {
            get { return this.order; }
        }

        /// <summary>
        /// Inicializa una nueva mesa con el número indicado.
        /// </summary>
        /// <param name="number">Número de la mesa.</param>
        public Table(int number)
        {
            this.Number = number;
            this.IsOccupied = false;
        }

        /// <summary>
        /// Ocupa la mesa.
        /// </summary>
        public void Occupy()
        {
            this.IsOccupied = true;
        }

        /// <summary>
        /// Libera la mesa y vacía la orden.
        /// </summary>
        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear();
        }

        /// <summary>
        /// Agrega un platillo a la orden de la mesa.
        /// </summary>
        /// <param name="dish">Platillo a agregar.</param>
        public void AddToOrder(Dish dish)
        {
            this.order.Add(dish);
        }

        /// <summary>
        /// Verifica si la mesa tiene algún platillo en la orden.
        /// </summary>
        /// <returns><c>true</c> si la mesa tiene pedidos; en caso contrario, <c>false</c>.</returns>
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
} 