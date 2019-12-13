﻿using System;
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

namespace tnation1730ex3d1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] values = {300, 500, 200, 150, 600, 750, 900, 150,
            100, 200, 250, 650, 300, 750, 800, 350, 250, 150, 100, 300};

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.valuesTextBox.Text = 
                Ex3dCalculations.ArrayToString(this.values);
        }

        private void searchValuesComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            valueCountTextBox.Text = "";
            try
            {
                var searchValue = int.Parse(this.searchValuesComboBox.Text);
                this.valueCountTextBox.Text = Ex3dCalculations.ValueCount(values, searchValue).ToString();
            }
            catch
            {

            }
        }

        private void searchRangesComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            rangeCountTextBox.Text = "";
            try
            {
                int dashIndex = this.searchRangesComboBox.Text.IndexOf('-');
                string strSearchMin = this.searchRangesComboBox.Text.Substring(0, dashIndex).Trim();
                string strSearchMax = this.searchRangesComboBox.Text.Substring(dashIndex + 1).Trim();
                int searchMin = int.Parse(strSearchMin);
                int searchMax = int.Parse(strSearchMax);
                this.rangeCountTextBox.Text = Ex3dCalculations.RangeCount(values, searchMin, searchMax).ToString();
            }
            catch
            {

            }
        }
    }
}
