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
        /// <summary>
        /// Obtiene o establece el nombre del plato.
        /// </summary>
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
        private int price;
        /// <summary>
        /// Obtiene o establece el precio del plato.
        /// </summary>
        public int Price
        {
            get{return price;}
            set{price = value;}
        }
        private bool isVegetarian;
        /// <summary>
        /// Obtiene o establece si el plato es vegetariano.
        /// </summary>
        public bool IsVegetarian
        {
            get {return isVegetarian;}
            set {isVegetarian=value;}
        }
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Dish"/>.
        /// </summary>
        /// <param name="name">Nombre del plato.</param>
        /// <param name="price">Precio del plato.</param>
        /// <param name="isVegetarian">Indica si el plato es vegetariano.</param>
        public Dish(string name, int price, bool isVegetarian)
        {
            this.Name = name;
            this.Price= price;
            this.IsVegetarian= isVegetarian;
        }
    }
}