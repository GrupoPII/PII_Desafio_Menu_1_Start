

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
        public String name;
        public String Name
        {
            get{ return name; } set {name=value;}
        }
        private ArrayList assignedTables = new ArrayList();
        public ArrayList AssignedTables
        {
            get {return assignedTables;} set {assignedTables =value;}
        }
        public Waiter(String name)
        {
            this.Name=name;
        }
        public void AssignTable(Table table)
        {
        assignedTables.Add(table);
        }
        public void TakeOrder(Table table, Dish dish)
        {
           table.AddToOrder(dish);
        }

    }
}