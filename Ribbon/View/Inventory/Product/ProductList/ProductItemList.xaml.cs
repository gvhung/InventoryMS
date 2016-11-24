﻿using Ribbon.Model;
using Ribbon.View.Inventory.Product.NewProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Prism.Commands;

namespace Ribbon.View.Inventory.Product.ProductList
{
    /// <summary>
    /// Interaction logic for ProductItemList.xaml
    /// </summary>
    public partial class ProductItemList : UserControl
    {
        public ProductItemList()
        {
            InitializeComponent();
        }

        public event EventHandler Changed;    // the Event
        private void dgDownloadsInfo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is DataGrid) { 
                DataGrid grid = (DataGrid)sender;
                if (grid.SelectedItems.Count > 1) {
                    MessageBox.Show("Please select one item at a time.");
                    return;
                }

                ProductInfoNJ selectedProduct = (ProductInfoNJ) grid.SelectedItems[0];
                MessageBox.Show(selectedProduct.Name);

                
                
                ICommand c = new Prism.Commands.DelegateCommand(Ribbon.ViewModel.ManageProduct.OnProductChange);
                c.Execute(selectedProduct);
                
            }
        }

        

    }
}
