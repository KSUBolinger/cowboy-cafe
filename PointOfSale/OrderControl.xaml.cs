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
            var order = new Order();
            this.DataContext = order;
        }

        private void OrderSummaryControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
