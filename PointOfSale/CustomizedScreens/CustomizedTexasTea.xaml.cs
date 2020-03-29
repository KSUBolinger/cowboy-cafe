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
    /// Interaction logic for CustomizedTexasTea.xaml
    /// </summary>
    public partial class CustomizedTexasTea : UserControl
    {
        private Order order;
        public CustomizedTexasTea(object dataContext)
        {
            order = (Order)dataContext;
            InitializeComponent();
        }

        void Button_Clicked(object sender, RoutedEventArgs e)
        {
            TexasTea tea = (TexasTea)DataContext;
            if (((Button)sender).Name == "Small_Button")
            {
                tea.Size = CowboyCafe.Data.Size.Small;
            }
            else if (((Button)sender).Name == "Medium_Button")
            {
                tea.Size = CowboyCafe.Data.Size.Medium;
            }
            else if (((Button)sender).Name == "Large_Button")
            {
                tea.Size = CowboyCafe.Data.Size.Large;
            }

            else if (((Button)sender).Name == "Sweet_Button")
            {
                tea.Sweet = true;
            }
            else if (((Button)sender).Name == "Plain_Button")
            {
                tea.Sweet = false;
            }

            else if (((Button)sender).Name == "Lemon_Button")
            {
                tea.Lemon = true;
            }
            else if (((Button)sender).Name == "NoLemon_Button")
            {
                tea.Lemon = false;
            }

            else if (((Button)sender).Name == "Ice_Button")
            {
                tea.Ice = true;
            }
            else if (((Button)sender).Name == "NoIce_Button")
            {
                tea.Ice = false;
            }

            order.InvokePropertyChanged();
        }
    }
}
