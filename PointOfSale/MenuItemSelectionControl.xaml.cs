/*MenuItemSelectionControl.xaml.cs
 * Author: Easton Bolinger
 * Purpose: handles the backend for the item selection UI
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
using CowboyCafe.Data;
using CowboyCafe.Extension;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds Angry Chicken to the order
        /// </summary>
        /// <param name="sender">the angry chicken button </param>
        /// <param name="e">information associated with the button</param>
        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new AngryChicken();
                var screen = new CustomizedAngryChicken();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);

                //OnItemAddButtonClicked(sender, e);
                //order.Add(new AngryChicken());
            }
        }

        /// <summary>
        /// Adds CowpokeChili to the order 
        /// </summary>
        /// <param name="sender">the cowpoke chili button </param>
        /// <param name="e">information associated with the button</param>
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {
                var entree = new CowpokeChili();
                var screen = new CustomizedCowpokeChili();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);

                //OnItemAddButtonClicked(sender, e);
                //order.Add(new CowpokeChili());
            }
        }

        /// <summary>
        /// adds Trail Burger to the order
        /// </summary>
        /// <param name="sender">the trail burger </param>
        /// <param name="e">information associated with the button</param>
        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new TrailBurger();
                var screen = new CustomizedTrailBurger();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);

                //OnItemAddButtonClicked(sender, e);
                //order.Add(new trailBurger());
            }
        }

        /// <summary>
        /// adds dakota double burger to the order 
        /// </summary>
        /// <param name="sender">the dakota double burger</param>
        /// <param name="e">information associated with the button</param>
        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new DakotaDoubleBurger();
                var screen = new CustomizedDakotaDoubleBurger();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);

                //OnItemAddButtonClicked(sender, e);
                //order.Add(new DakotaDoubleBurger());
            }
        }

        /// <summary>
        /// adds the texas triple burger to the order 
        /// </summary>
        /// <param name="sender">the texas triple burger </param>
        /// <param name="e">information associated with the button</param>
        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new TexasTripleBurger();
                var screen = new CustomizedTexasTripleBurger();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);

                //OnItemAddButtonClicked(sender, e);
                //order.Add(new TexasTripleBurger());
            }
        }

        /// <summary>
        /// adds the pecos pulled pork to the order 
        /// </summary>
        /// <param name="sender">the pecos pulled pork</param>
        /// <param name="e">information associated with the button</param>
        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new PecosPulledPork();
                var screen = new CustomizedPecosPulledPork();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);

                //OnItemAddButtonClicked(sender, e);
                //order.Add(new PecosPulledPork());
            }
        }

        /// <summary>
        /// adds the rustlers ribs to the order
        /// </summary>
        /// <param name="sender">the rustlers ribs </param>
        /// <param name="e">information associated with the button</param>
        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }

        /// <summary>
        /// adds the baked beans to the order 
        /// </summary>
        /// <param name="sender">the baked beans</param>
        /// <param name="e">information associated with the button</param>
        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {
                var side = new BakedBeans();
                var screen = new CustomizedSide(DataContext);
                screen.DataContext = side;
                order.Add(side);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// adds the chili cheese fries to the order 
        /// </summary>
        /// <param name="sender">the chili cheese fries </param>
        /// <param name="e">information associated with the button</param>
        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var side = new ChiliCheeseFries();
                var screen = new CustomizedSide(DataContext);
                screen.DataContext = side;
                order.Add(side);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// adds the corn dodgers to the order
        /// </summary>
        /// <param name="sender">the corn dodgers</param>
        /// <param name="e">information associated with the button</param>
        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var side = new CornDodgers();
                var screen = new CustomizedSide(DataContext);
                screen.DataContext = side;
                order.Add(side);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// adds the pan de campo beans to the order 
        /// </summary>
        /// <param name="sender">the pan de campo beans</param>
        /// <param name="e">information associated with the button</param>
        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var side = new PanDeCampo();
                var screen = new CustomizedSide(DataContext);
                screen.DataContext = side;
                order.Add(side);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// adds the cowboy coffee to the order
        /// </summary>
        /// <param name="sender">the cowboy coffee</param>
        /// <param name="e">information associated with the button</param>
        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var drink = new CowboyCoffee();
                var screen = new CustomizedCowboyCoffee(DataContext);
                screen.DataContext = drink;
                order.Add(drink);
                orderControl?.SwapScreen(screen);

                //OnItemAddButtonClicked(sender, e);
                //order.Add(new CowboyCoffee());
            }
        }

        /// <summary>
        /// adds the jerked soda to the order
        /// </summary>
        /// <param name="sender">the jerked soda</param>
        /// <param name="e">information associated with the button</param>
        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var drink = new JerkedSoda();
                var screen = new CustomizedJerkSoda(DataContext);
                screen.DataContext = drink;
                order.Add(drink);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// adds texas tea to the order
        /// </summary>
        /// <param name="sender">the texas tea</param>
        /// <param name="e">information associated with the button</param>
        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var drink = new TexasTea();
                var screen = new CustomizedTexasTea(DataContext);
                screen.DataContext = drink;
                order.Add(drink);
                orderControl?.SwapScreen(screen);

                //OnItemAddButtonClicked(sender, e);
                //order.Add(new TexasTea());
            }
        }

        /// <summary>
        /// adds water to the order
        /// </summary>
        /// <param name="sender">the water</param>
        /// <param name="e">information associated with the button</param>
        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var drink = new Water();
                var screen = new CustomizedWater(DataContext);
                screen.DataContext = drink;
                order.Add(drink);
                orderControl?.SwapScreen(screen);

                //OnItemAddButtonClicked(sender, e);
                //order.Add(new Water());
            }
        }

        //private OrderControl orderControl;
        //public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        //{
        //    var orderControl = this.FindAncestor<OrderControl>();
        //    if (DataContext is Order order)
        //    {

        //        if (sender is Button button)
        //        {
        //            if ((string)button.Tag == "CowpokeChili")
        //            {
        //                var entree = new CowpokeChili();
        //                var screen = new CustomizedCowpokeChili();
        //                screen.DataContext = entree;
        //                //order.Add(new CowpokeChili());
        //                orderControl?.SwapScreen(screen);
        //            }
        //            else if ((string)button.Tag == "AngryChicken")
        //            {
        //                var entree = new AngryChicken();
        //                var screen = new CustomizedAngryChicken();
        //                screen.DataContext = entree;
        //                //order.Add(new AngryChicken());
        //                orderControl.SwapScreen(screen);
        //            }
        //            else if((string)button.Tag == "TrailBurger")
        //            {
        //                var entree = new TrailBurger();
        //                var screen = new CustomizedTrailBurger();
        //                screen.DataContext = entree;
        //                orderControl.SwapScreen(screen);
        //            }
        //            else if ((string)button.Tag == "DakotaDoubleBurger")
        //            {
        //                var entree = new DakotaDoubleBurger();
        //                var screen = new CustomizedDakotaDoubleBurger();
        //                screen.DataContext = entree;
        //                orderControl.SwapScreen(screen);
        //            }
        //            else if ((string)button.Tag == "TexasTripleBurger")
        //            {
        //                var entree = new TexasTripleBurger();
        //                var screen = new CustomizedTexasTripleBurger();
        //                screen.DataContext = entree;
        //                orderControl.SwapScreen(screen);
        //            }
        //            else if ((string)button.Tag == "PecosPulledPork")
        //            {
        //                var entree = new PecosPulledPork();
        //                var screen = new CustomizedPecosPulledPork();
        //                screen.DataContext = entree;
        //                orderControl.SwapScreen(screen);
        //            }
        //            else if ((string)button.Tag == "CowboyCoffee")
        //            {
        //                var entree = new CowboyCoffee();
        //                var screen = new CustomizedCowboyCoffee(DataContext);
        //                screen.DataContext = entree;
        //                orderControl.SwapScreen(screen);
        //            }
        //            else if ((string)button.Tag == "TexasTea")
        //            {
        //                var entree = new TexasTea();
        //                //var screen = new CustomizedTexasTea();
        //                //screen.DataContext = entree;
        //                //orderControl.SwapScreen(screen);
        //            }
        //            else if ((string)button.Tag == "Water")
        //            {
        //                var entree = new Water();
        //                var screen = new CustomizedWater();
        //                screen.DataContext = entree;
        //                orderControl.SwapScreen(screen);
        //            }
        //        }
          //  }
       // }
    }
}
