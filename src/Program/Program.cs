//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            Dish burger = new Dish("Burger", 5.99, false);
            Dish salad = new Dish("Salad", 4.99, true);
            Menu menu = new Menu();
            menu.AddDish(burger);
            menu.AddDish(salad);
            Table oneTable = new Table(1);
            Waiter waiter = new Waiter("John");
            waiter.AssignTable(oneTable);
            oneTable.Occupy();
            waiter.TakeOrder(oneTable, burger);
            Console.WriteLine(
            $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied} " +
            $"y la atiende: {waiter.Name}");
            oneTable.Free();
            Console.WriteLine(
            $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied}");
            Console.WriteLine(
            $"La ensalada tiene los atributos: {salad.Name}, {salad.Price} y es vegetariana = {salad.IsVegetarian}");
            Console.WriteLine(
            $"La hamburguesa tiene los atributos: {burger.Name}, {burger.Price} y es vegetariana = {burger.IsVegetarian}");
            Table threeTable = new Table(3);
            waiter.AssignTable(threeTable);
            threeTable.Occupy();
            waiter.TakeOrder(threeTable, burger);
            waiter.TakeOrder(threeTable, burger);
            waiter.TakeOrder(threeTable, burger);
            waiter.TakeOrder(threeTable, salad);
            Console.WriteLine(
            $"La mesa {threeTable.Number} está ocupada: {threeTable.IsOccupied} " +
            $"y la atiende: {waiter.Name}");
            Console.WriteLine($"El total de la mesa es: {waiter.GetTotal(threeTable)}");
            TakeOver takeOver1=new TakeOver();
            takeOver1.AddToOrder(burger);
            Console.WriteLine(takeOver1.GetTotal());
        }
    }
}