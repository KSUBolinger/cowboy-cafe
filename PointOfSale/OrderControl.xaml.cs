/*
 * Author: Easton Bolinger
 * Class: OrderControl.xaml.cs
 * Purpose: Handle the click events from the Order control screen
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            //AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            var order = new Order(1);
            this.DataContext = order;
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        private void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            Order order = (Order)this.DataContext;
            this.DataContext = new Order(order.OrderNumber + 1);
        }

        private void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            Order order = (Order)this.DataContext;
            this.DataContext = new Order(order.OrderNumber + 1);
        }

        private void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
