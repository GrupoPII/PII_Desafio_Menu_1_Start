//------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private ArrayList dishes = new ArrayList();
                /// <summary>
    ///agregar plato 
    /// </summary>
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }
                /// <summary>
    ///Remover plato
    /// </summary>
        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }
        /// <summary>
    ///Acceder al plato por nombre
    /// </summary>
        public Dish GetDishByName(string buscado)
        {

            foreach (Dish dish in dishes)
            {
                if (buscado == dish.Name)
                {
                 return dish;   
                }
            }
            return null;

        }

    }
    
}