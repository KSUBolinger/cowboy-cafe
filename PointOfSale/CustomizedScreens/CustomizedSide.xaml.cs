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
    /// Interaction logic for CustomizedSide.xaml
    /// </summary>
    public partial class CustomizedSide : UserControl
    {
        private Order order;
        public CustomizedSide(object dataContext)
        {
            order = (Order)dataContext;
            InitializeComponent();
        }

        void Button_Clicked(object sender, RoutedEventArgs e)
        {
            Side side;
            if(DataContext is BakedBeans)
            {
                side = (BakedBeans)DataContext;
            }
            else if(DataContext is CornDodgers)
            {
                side = (CornDodgers)DataContext;
            }
            else if(DataContext is ChiliCheeseFries)
            {
                side = (ChiliCheeseFries)DataContext;
            }
            else
            {
                side = (PanDeCampo)DataContext;
            }


            if(((RadioButton)sender).Name == "Small_Button")
            {
                side.Size = CowboyCafe.Data.Size.Small;
            }
            else if(((RadioButton)sender).Name == "Medium_Button")
            {
                side.Size = CowboyCafe.Data.Size.Medium;
            }
            else
            {
                side.Size = CowboyCafe.Data.Size.Large;
            }

            order.InvokePropertyChanged();
        }
    }
}
