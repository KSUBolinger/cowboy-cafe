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
    /// Interaction logic for CustomizedWater.xaml
    /// </summary>
    public partial class CustomizedWater : UserControl
    {
        private Order order;
        public CustomizedWater(object dataContext)
        {
            order = (Order)dataContext;
            InitializeComponent();
        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            Water water = (Water)DataContext;
            if (((Button)sender).Name == "Small_Button")
            {
                water.Size = CowboyCafe.Data.Size.Small;
            }
            else if (((Button)sender).Name == "Medium_Button")
            {
                water.Size = CowboyCafe.Data.Size.Medium;
            }
            else if (((Button)sender).Name == "Large_Button")
            {
                water.Size = CowboyCafe.Data.Size.Large;
            }

            else if (((Button)sender).Name == "Lemon_Button")
            {
                water.Lemon = true;
            }
            else if (((Button)sender).Name == "NoLemon_Button")
            {
                water.Lemon = false;
            }

            else if (((Button)sender).Name == "AddIce_Button")
            {
                water.Ice = true;
            }
            else if(((Button)sender).Name == "NoIce_Button")
            {
                water.Ice = false;
            }

            order.InvokePropertyChanged();
        }
    }
}
