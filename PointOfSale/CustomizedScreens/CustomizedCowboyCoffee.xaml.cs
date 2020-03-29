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
    /// Interaction logic for CustomizedCowboyCoffee.xaml
    /// </summary>
    public partial class CustomizedCowboyCoffee : UserControl
    {
        private Order order;
        public CustomizedCowboyCoffee(object DataContext)
        {
            order = (Order)DataContext;
            InitializeComponent();
        }

        void Button_Click(Object sender, RoutedEventArgs e)
        {
            CowboyCoffee coffee = (CowboyCoffee)DataContext;

            if(((Button)sender).Name == "Small_Button")
            {
                coffee.Size = CowboyCafe.Data.Size.Small;
            }
            else if(((Button)sender).Name == "Medium_Button")
            {
                coffee.Size = CowboyCafe.Data.Size.Medium;
            }
            else if(((Button)sender).Name == "Large_Button")
            {
                coffee.Size = CowboyCafe.Data.Size.Large;
            }

            else if(((Button)sender).Name == "Decaf_Button")
            {
                coffee.Decaf = true;
            }
            else if(((Button)sender).Name == "NonDecaf_Button")
            {
                coffee.Decaf = false;
            }

            else if(((Button)sender).Name == "Cream_Button")
            {
                coffee.RoomForCream = true;
            }
            else if(((Button)sender).Name == "NoCream_Button")
            {
                coffee.RoomForCream = false;
            }

            else if(((Button)sender).Name == "Ice_Button")
            {
                coffee.Ice = true;
            }
            else if(((Button)sender).Name == "NoIce_Button")
            {
                coffee.Ice = false;
            }

            order.InvokePropertyChanged();
        }
    }
}
