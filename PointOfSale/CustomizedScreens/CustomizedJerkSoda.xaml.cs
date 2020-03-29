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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizedJerkSoda.xaml
    /// </summary>
    public partial class CustomizedJerkSoda : UserControl
    {
        private Order order;
        public CustomizedJerkSoda(object dataContext)
        {
            order = (Order)dataContext;
            InitializeComponent();
        }

        void Button_Clicked(object sender, RoutedEventArgs e)
        {
            JerkedSoda soda = (JerkedSoda)DataContext;

            if(((Button)sender).Name == "Small_Button")
            {
                soda.Size = CowboyCafe.Data.Size.Small;
            }
            else if(((Button)sender).Name == "Medium_Button")
            {
                soda.Size = CowboyCafe.Data.Size.Medium;
            }
            else if(((Button)sender).Name == "Large_Button")
            {
                soda.Size = CowboyCafe.Data.Size.Large;
            }

            else if(((Button)sender).Name == "BirchBeer_Button")
            {
                soda.Flavor = SodaFlavor.BirchBeer;
            }
            else if(((Button)sender).Name == "Rootbeer_Button")
            {
                soda.Flavor = SodaFlavor.RootBeer;
            }
            else if(((Button)sender).Name == "CreamSoda")
            {
                soda.Flavor = SodaFlavor.CreamSoda;
            }
            else if(((Button)sender).Name == "OrangeSoda_Button")
            {
                soda.Flavor = SodaFlavor.OrangeSoda;
            }
            else if(((Button)sender).Name == "Sarsparilla_Button")
            {
                soda.Flavor = SodaFlavor.Sarsparilla;
            }

            else if(((Button)sender).Name == "Ice_Button")
            {
                soda.Ice = true;
            }
            else if(((Button)sender).Name == "NoIce_Button")
            {
                soda.Ice = false;
            }

            order.InvokePropertyChanged();
        }
    }
}
