

using System;
using System.Collections;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        /// <summary>
        /// Nombre del mozo.
        /// </summary>
        public String name;
        /// <summary>
        /// Nombre del mozo.
        /// </summary>
        public String Name
        {
            get{ return name; } set {name=value;}
        }
        private ArrayList assignedTables = new ArrayList();
        /// <summary>
        /// Mesas asignadas al mozo.
        /// </summary>
        public ArrayList AssignedTables
        {
            get {return assignedTables;} set {assignedTables =value;}
        }
        /// <summary>
        /// Inicializa un mozo con su nombre.
        /// </summary>
        /// <param name="name">Nombre del mozo.</param>
        public Waiter(String name)
        {
            this.Name=name;
        }

        /// <summary>
        /// Asigna una mesa al mozo.
        /// </summary>
        /// <param name="table">Mesa que se asignará.</param>
        public void AssignTable(Table table)
        {
        assignedTables.Add(table);
        }
        /// <summary>
        /// Toma el pedido de un plato para una mesa.
        /// </summary>
        /// <param name="table">Mesa cuyo pedido se actualizará.</param>
        /// <param name="dish">Plato que se agregará al pedido.</param>
        public void TakeOrder(Table table, Dish dish)
        {
           table.Order.Add(dish);
        }

    }
}