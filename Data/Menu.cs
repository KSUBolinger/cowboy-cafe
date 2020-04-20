/* Menu.cs
 * Author: Easton Bolinger
 * Purpose: to implement the static methods listed in the directions 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// the method populates the IEnumerable for the entrees
        /// </summary>
        /// <returns>IEnumerable list full of entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<Entree> order = new List<Entree>();

            order.Add(new AngryChicken());
            order.Add(new CowpokeChili());
            order.Add(new TrailBurger());
            order.Add(new DakotaDoubleBurger());
            order.Add(new TexasTripleBurger());
            order.Add(new PecosPulledPork());
            order.Add(new RustlersRibs());

            IEnumerable<IOrderItem> EntreeOrder = order.AsEnumerable();
            return EntreeOrder;
        }

        /// <summary>
        /// This method populates the IEnumberable for the sides 
        /// </summary>
        /// <returns>IEnumerable full of sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<Side> order = new List<Side>();

            order.Add(new BakedBeans());
            order.Add(new ChiliCheeseFries());
            order.Add(new CornDodgers());
            order.Add(new PanDeCampo());

            IEnumerable<IOrderItem> SideOrder = order.AsEnumerable();
            return SideOrder;
        }

        /// <summary>
        /// This method populates the IEnumerable for the drinks
        /// </summary>
        /// <returns>IEnumerable full of drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<Drink> order = new List<Drink>();

            order.Add(new CowboyCoffee());
            order.Add(new JerkedSoda());
            order.Add(new TexasTea());
            order.Add(new Water());

            IEnumerable<IOrderItem> DrinkOrder = order.AsEnumerable();
            return DrinkOrder;
        }

        public static IEnumerable<IOrderItem> CompleteOrder()
        {
            List<IEnumerable<IOrderItem>> order = new List<IEnumerable<IOrderItem>>();

            order.Add(Entrees());
            order.Add(Drinks());
            order.Add(Sides());

            order = order.AsEnumerable();
            return order;
        }
    }
}
