//------------------------------------------------------------------------------
// <copyright file="Dish.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Text.RegularExpressions;

namespace Ucu.Poo.Restaurant
{
     /// <summary>
    /// Representa un plato en el restaurante.
    /// </summary>
    public class Dish
    {
        private string name;
        public string Name
        {
            get {return name;} 
            set {
                if (!string.IsNullOrEmpty(value))
                {
                name=value;
                }
            }
        }
        private string price;
        public string Price
        {
            get{return price;}
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    price = value;
                }
            }
        }
        private bool isvegetarian;
        public bool IsVegetarian
        {
            get {return isvegetarian;}
            set {isvegetarian=value;}
        }
    }
}