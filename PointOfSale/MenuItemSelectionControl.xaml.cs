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
        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new AngryChicken());
            }
        }
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                OnItemAddButtonClicked(sender, e);
                order.Add(new CowpokeChili());
            }
        }
        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new TrailBurger());
            }
        }
        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new DakotaDoubleBurger());
            }
        }
        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new TexasTripleBurger());
            }
        }
        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new PecosPulledPork());
            }
        }
        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }
        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new BakedBeans());
            }
        }
        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
            }
        }
        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CornDodgers());
            }
        }
        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PanDeCampo());
            }
        }
        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowboyCoffee());
            }
        }
        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new JerkedSoda());
            }
        }
        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTea());
            }
        }
        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
            }
        }

        private OrderControl orderControl;
        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {

                if(sender is Button button)
                {
                    if((string)button.Tag == "CowpokeChili")
                    {
                        var entree = new CowpokeChili();
                        var screen = new CustomizedCowpokeChili();
                        screen.DataContext = entree;
                        order.Add(new CowpokeChili());
                        orderControl.SwapScreen(new CustomizedCowpokeChili());
                    }
                    else if((string)button.Tag == "AngryChicken")
                    {
                        var entree = new AngryChicken();
                        var screen = new CustomizedAngryChicken();
                        screen.DataContext = entree;
                        order.Add(new AngryChicken());
                        orderControl.SwapScreen(new CustomizedAngryChicken());
                    }
                }
            }
        }
    }
}
