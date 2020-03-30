/*Author: Easton Bolinger
 * File: OrderSummaryControl.xaml.cs
 * Purpose: to handle the building and editing of the order summary screen
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Extension;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// handles the event that an added item needs to be chagned
        /// </summary>
        /// <param name="sender">the listbox item being edited</param>
        /// <param name="e">information associated with the item sent</param>
        void ItemChanged(object sender, EventArgs e)
        {
            FrameworkElement screen = null;
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if(sender is ListBox lb)
                {
                    if(lb.SelectedItem is IOrderItem item)
                    {
                        if(item is AngryChicken)
                        {
                            screen = new CustomizedAngryChicken();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if(item is CowpokeChili)
                        {
                            screen = new CustomizedCowpokeChili();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if(item is TrailBurger)
                        {
                            screen = new CustomizedTrailBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if(item is DakotaDoubleBurger)
                        {
                            screen = new CustomizedDakotaDoubleBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if(item is TexasTripleBurger)
                        {
                            screen = new CustomizedTexasTripleBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if(item is PecosPulledPork)
                        {
                            screen = new CustomizedPecosPulledPork();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if(item is BakedBeans || item is ChiliCheeseFries || item is CornDodgers || item is PanDeCampo)
                        {
                            screen = new CustomizedSide(DataContext);
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if(item is CowboyCoffee)
                        {
                            screen = new CustomizedCowboyCoffee(DataContext);
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if(item is JerkedSoda)
                        {
                            screen = new CustomizedJerkSoda(DataContext);
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if(item is TexasTea)
                        {
                            screen = new CustomizedTexasTea(DataContext);
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if(item is Water)
                        {
                            screen = new CustomizedWater(DataContext);
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                    }
                }
            }
           
        }
    }
}
